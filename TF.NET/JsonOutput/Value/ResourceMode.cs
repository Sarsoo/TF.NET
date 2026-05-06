using System.Text.Json.Serialization;
using TF.MachineReadableUI;

namespace TF.JsonOutput.Value;

[JsonConverter(typeof(JsonStringEnumConverter<ResourceMode>))]
public enum ResourceMode
{
    [JsonStringEnumMemberName("managed")]
    Managed,
    [JsonStringEnumMemberName("data")]
    Data
}