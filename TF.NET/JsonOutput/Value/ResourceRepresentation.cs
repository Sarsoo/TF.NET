using System.Text.Json.Serialization;

namespace TF.JsonOutput.Value;

public class ResourceRepresentation
{
    public string Address { get; set; }
    public ResourceMode Mode { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string? Index { get; set; }
    [JsonPropertyName("provider_name")]
    public string Provider { get; set; }
    public int SchemaVersion { get; set; }

    // commented out while serilialisation doesn't work
    // public string Values { get; set; }
    // public Dictionary<string, bool> SensitiveValues { get; set; }
}