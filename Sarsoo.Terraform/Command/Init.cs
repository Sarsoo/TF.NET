using System.Threading.Channels;
using Sarsoo.Terraform.MachineReadableUI;
using Sarsoo.Terraform.MachineReadableUI.Json;

namespace Sarsoo.Terraform.Command;

public class Init
{
    private readonly TerraformStreamCommand<FullMessage> _command;

    public ChannelReader<FullMessage> Output => _command.Output;
    private bool _includeUpgrade = false;
    private bool _lockState = true;
    private bool _initBackend = true;

    public Init(string executable, string workingDirectory)
    {
        _command = new TerraformStreamCommand<FullMessage>(executable, MruiContext.Default.FullMessage)
            .Configure(b => b.WithWorkingDirectory(workingDirectory));
    }

    public Init WithUpgrade()
    {
        _includeUpgrade = true;
        return this;
    }

    public Init WithoutLock()
    {
        _lockState = false;
        return this;
    }

    public Init WithoutBackend()
    {
        _initBackend = false;
        return this;
    }

    public Task Run() => _command
        .Configure(x =>
            x.WithArguments(b =>
                {
                    b.Add("init")
                        .Add("-json");

                    if (_includeUpgrade)
                    {
                        b.Add("-upgrade");
                    }
                    if (!_lockState)
                    {
                        b.Add("-lock=false");
                    }
                    if (!_initBackend)
                    {
                        b.Add("-backend=false");
                    }
                })).Run();
}