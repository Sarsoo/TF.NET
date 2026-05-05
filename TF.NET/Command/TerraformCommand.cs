using System.Text.Json;
using System.Threading.Channels;
using CliWrap;
using CliWrap.EventStream;
using TF.NET.MachineReadableUI;
using TF.NET.MachineReadableUI.Json;

namespace TF.NET.Command;

public class TerraformCommand
{
    private readonly Channel<FullMessage> Messages = Channel.CreateUnbounded<FullMessage>();
    private CliWrap.Command Command { get; set; }

    public TerraformCommand(string executable)
    {
        Command = Cli.Wrap(executable)
            .WithValidation(CommandResultValidation.None);
    }

    public TerraformCommand Configure(Func<CliWrap.Command, CliWrap.Command> configure)
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

                        var message = JsonSerializer.Deserialize(stdOut.Text, MruiContext.Default.FullMessage);

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