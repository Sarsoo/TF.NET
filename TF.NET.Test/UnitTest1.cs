namespace TF.NET.Test;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await Plan.Plan.Run();
    }
}