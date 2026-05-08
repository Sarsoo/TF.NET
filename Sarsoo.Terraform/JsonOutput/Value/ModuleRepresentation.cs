namespace Sarsoo.Terraform.JsonOutput.Value;

public class ModuleRepresentation
{
    public string? Address { get; set; }
    public List<ResourceRepresentation> Resources { get; set; }
    public List<ModuleRepresentation> ChildModules { get; set; }
}