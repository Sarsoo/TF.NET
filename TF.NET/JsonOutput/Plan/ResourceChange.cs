using TF.JsonOutput.Change;
using TF.JsonOutput.Value;

namespace TF.JsonOutput.Plan;

public class ResourceChange
{
    public string Address { get; set; }
    public string? PreviousAddress { get; set; }
    public string? ModuleAddress { get; set; }
    public ResourceMode Mode { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string? Index { get; set; }
    public string? Deposed { get; set; }
    public ChangeRepresentation? Change { get; set; }

    public ActionReason ActionReason { get; set; }
}