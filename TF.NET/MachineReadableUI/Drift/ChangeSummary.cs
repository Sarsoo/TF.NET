using System.Text.Json.Serialization;

namespace TF.NET.MachineReadableUI.Drift;

/// <summary>
/// Terraform outputs a change summary when a plan or apply operation completes. Both message types include a changes object, which has the following keys:
/// </summary>
public struct ChangeSummary
{
    /// <summary>
    /// count of resources to be created (including as part of replacement)
    /// </summary>
    [JsonPropertyName("add")]
    public int Add { get; set; }
    /// <summary>
    /// count of resources to be changed in-place
    /// </summary>
    [JsonPropertyName("change")]
    public int Change { get; set; }
    /// <summary>
    /// count of resources to be destroyed (including as part of replacement)
    /// </summary>
    [JsonPropertyName("remove")]
    public int Remove { get; set; }
    /// <summary>
    /// one of plan, apply, or destroy
    /// </summary>
    [JsonPropertyName("operation")]
    public ChangeOperation Operation { get; set; }
}