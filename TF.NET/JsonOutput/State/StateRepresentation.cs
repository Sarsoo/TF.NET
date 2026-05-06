using System.Text.Json.Serialization;
using TF.JsonOutput.Value;

namespace TF.JsonOutput.State;

public class StateRepresentation
{
    [JsonPropertyName("terraform_version")]
    public string TerraformVersion { get; set; }
    public ValuesRepresentation Values { get; set; }
}