using CliWrap;
using CliWrap.Buffered;
using TF.NET.Command;

namespace TF.NET.Plan;

public static class Plan
{
    public static async Task Run()
    {
        var c = new TerraformCommand("terraform").Configure(x =>
            x.WithArguments(["plan", "-json", "-detailed-exitcode"])
                .WithWorkingDirectory("/Users/andy/dev/infra/terraform/CLOUDFLARE/sas&sam"));

        await c.Run();
    }
}