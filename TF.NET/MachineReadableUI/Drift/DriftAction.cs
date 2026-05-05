using System.Text.Json.Serialization;

namespace TF.NET.MachineReadableUI.Drift;

[JsonConverter(typeof(JsonStringEnumConverter<DriftAction>))]
public enum DriftAction
{
    [JsonStringEnumMemberName("update")]
    Update,
    [JsonStringEnumMemberName("delete")]
    Delete
}