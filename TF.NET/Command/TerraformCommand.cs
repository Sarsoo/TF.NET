using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using CliWrap;
using CliWrap.Buffered;

namespace TF.Command;

public class TerraformCommand<T> where T: notnull
{
    private readonly JsonTypeInfo<T> _serialiserInfo;
    private CliWrap.Command Command { get; set; }

    public TerraformCommand(string executable, JsonTypeInfo<T> serialiserInfo)
    {
        _serialiserInfo = serialiserInfo;
        Command = Cli.Wrap(executable)
            .WithValidation(CommandResultValidation.None);
    }

    public TerraformCommand<T> Configure(Func<CliWrap.Command, CliWrap.Command> configure)
    {
        Command = configure.Invoke(Command);

        return this;
    }

    public async Task<T?> Run()
    {
        var result = await Command.ExecuteBufferedAsync();

        return JsonSerializer.Deserialize(result, _serialiserInfo);
    }
}