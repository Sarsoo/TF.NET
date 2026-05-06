using System.Threading.Channels;
using TF.MachineReadableUI;
using TF.MachineReadableUI.Json;

namespace TF.Command;

public class Apply
{
    private readonly TerraformStreamCommand<FullMessage> _command;

    public ChannelReader<FullMessage> Output => _command.Output;

    public Apply(string executable, string workingDirectory)
    {
        _command = new TerraformStreamCommand<FullMessage>(executable, MruiContext.Default.FullMessage)
            .Configure(x =>
                x.WithArguments(["apply", "-json"])
                    .WithWorkingDirectory(workingDirectory));
    }

    public Task Run() => _command.Run();
}