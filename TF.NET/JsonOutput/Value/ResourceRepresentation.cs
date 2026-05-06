using System.Text.Json;
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
    public JsonElement Values { get; set; }
    public JsonElement SensitiveValues { get; set; }
}