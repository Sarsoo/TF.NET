using CliWrap;
using CliWrap.Buffered;

namespace TF.NET.Plan;

public static class Plan
{
    public static async Task Run()
    {
        var result = await Cli.Wrap("terraform")
            .WithArguments(["plan", "-json", "-detailed-exitcode"])
            .WithWorkingDirectory("/Users/andy/dev/infra/terraform/CLOUDFLARE/sas&sam")
            .WithValidation(CommandResultValidation.None)
            .ExecuteBufferedAsync();

        var split = result.StandardOutput.Split(Environment.NewLine);
    }
}