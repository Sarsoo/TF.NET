using System.Text.Json.Serialization;
using Sarsoo.Terraform.MachineReadableUI;

namespace Sarsoo.Terraform.JsonOutput.Value;

[JsonConverter(typeof(JsonStringEnumConverter<ResourceMode>))]
public enum ResourceMode
{
    [JsonStringEnumMemberName("managed")]
    Managed,
    [JsonStringEnumMemberName("data")]
    Data
}