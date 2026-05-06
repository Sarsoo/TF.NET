using TF.Command;

namespace TF.Test;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var validate = new Validate("terraform", "/Users/andy/dev/infra/terraform/CLOUDFLARE/sas&sam");

        // var result = await validate.Run();
    }
}