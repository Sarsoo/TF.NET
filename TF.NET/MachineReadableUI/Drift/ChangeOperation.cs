using System.Text.Json.Serialization;

namespace TF.MachineReadableUI.Drift;

[JsonConverter(typeof(JsonStringEnumConverter<ChangeOperation>))]
public enum ChangeOperation
{
    [JsonStringEnumMemberName("plan")]
    Plan,
    [JsonStringEnumMemberName("apply")]
    Apply,
    [JsonStringEnumMemberName("destroy")]
    Destroy
}