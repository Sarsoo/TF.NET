using System.Threading.Channels;
using TF.MachineReadableUI;
using TF.MachineReadableUI.Json;

namespace TF.Command;

public class Plan
{
    private readonly TerraformStreamCommand<FullMessage> _command;

    public ChannelReader<FullMessage> Output => _command.Output;

    public Plan(string executable, string workingDirectory)
    {
        _command = new TerraformStreamCommand<FullMessage>(executable, MruiContext.Default.FullMessage)
            .Configure(x =>
                x.WithArguments(["plan", "-json", "-detailed-exitcode"])
                    .WithWorkingDirectory(workingDirectory));
    }

    public Task Run() => _command.Run();
}