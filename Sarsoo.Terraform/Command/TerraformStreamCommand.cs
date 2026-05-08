using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Channels;
using CliWrap;
using CliWrap.EventStream;

namespace Sarsoo.Terraform.Command;

public class TerraformStreamCommand<T>  where T: notnull
{
    private readonly JsonTypeInfo<T> _serialiserInfo;
    private readonly Channel<T> Messages = Channel.CreateUnbounded<T>();
    private CliWrap.Command Command { get; set; }

    public ChannelReader<T> Output => Messages.Reader;

    public TerraformStreamCommand(string executable, JsonTypeInfo<T> serialiserInfo)
    {
        _serialiserInfo = serialiserInfo;
        Command = Cli.Wrap(executable)
            .WithValidation(CommandResultValidation.None);
    }

    public TerraformStreamCommand<T> Configure(Func<CliWrap.Command, CliWrap.Command> configure)
    {
        Command = configure.Invoke(Command);

        return this;
    }

    public async Task Run()
    {
        await foreach (var cmdEvent in Command.ListenAsync())
        {
            try
            {
                switch (cmdEvent)
                {
                    case StartedCommandEvent started:
                        Console.WriteLine($"Process started; ID: {started.ProcessId}");
                        break;
                    case StandardOutputCommandEvent stdOut:

                        var message = JsonSerializer.Deserialize(stdOut.Text, _serialiserInfo);

                        await Messages.Writer.WriteAsync(message);

                        break;
                    case StandardErrorCommandEvent stdErr:
                        Console.WriteLine($"Err> {stdErr.Text}");
                        break;
                    case ExitedCommandEvent exited:
                        Console.WriteLine($"Process exited; Code: {exited.ExitCode}");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }
    }
}