using System.Globalization;
using System.Threading.Channels;
using TF.Command;
using TF.JsonOutput.Plan;
using TF.MachineReadableUI;

namespace TF.Plan;

public class PlanGenerator
{
    private Command.Plan _generate;
    private ShowPlan _parse;

    public ChannelReader<FullMessage> PlanOutput => _generate.Output;

    public PlanGenerator(string executable, string workingDirectory)
    {
        _generate = new Command.Plan(executable, workingDirectory);
        _parse = new ShowPlan(executable, workingDirectory);
    }

    public async Task<PlanRepresentation?> Run()
    {
        var tempPath = $"plan-{DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmssfffzzz", DateTimeFormatInfo.InvariantInfo)}.tfplan";

        _generate.WithOutputFile(tempPath);
        await _generate.Run();

        _parse.WithPlanFile(tempPath);
        return await _parse.Run();
    }
}