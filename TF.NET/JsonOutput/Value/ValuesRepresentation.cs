namespace TF.JsonOutput.Value;

public class ValuesRepresentation
{
    public Dictionary<string, Variable> Outputs { get; set; }
    public ModuleRepresentation RootModule { get; set; }
}