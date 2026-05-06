using TF.MachineReadableUI.Json;
using TF.MachineReadableUI.Validate;

namespace TF.Command;

public class Validate
{
    private readonly TerraformCommand<ValidationOutput> _command;

    public Validate(string executable, string workingDirectory)
    {
        _command = new TerraformCommand<ValidationOutput>(executable, MruiContext.Default.ValidationOutput)
            .Configure(x =>
                x.WithArguments(["validate", "-json"])
                    .WithWorkingDirectory(workingDirectory));
    }

    public Task<ValidationOutput?> Run() => _command.Run();
}