using Sarsoo.Terraform.FileSystem;
// using TerraformDotnet.Module;
using Sarsoo.Terraform.Plan;

namespace Sarsoo.Terraform.Test;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var files = SourceResolver.FindSourceDirectories("/Users/andy/dev/infra/terraform").ToArray();

        // var source = files.Select(TerraformModule.LoadFromDirectory).ToArray();
        // var source = files.ToDictionary(x => x, TerraformModule.LoadFromDirectory);
    }
}