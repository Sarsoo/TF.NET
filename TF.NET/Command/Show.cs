using TF.JsonOutput;
using TF.JsonOutput.State;

namespace TF.Command;

public class Show
{
    private readonly TerraformCommand<StateRepresentation> _command;

    public Show(string executable, string workingDirectory)
    {
        _command = new TerraformCommand<StateRepresentation>(executable, JsonOutputContext.Default.StateRepresentation)
            .Configure(x =>
                x.WithArguments(["show", "-json"])
                    .WithWorkingDirectory(workingDirectory));
    }

    public Task<StateRepresentation?> Run() => _command.Run();
}