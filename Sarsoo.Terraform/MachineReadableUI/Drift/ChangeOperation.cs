using System.Text.Json.Serialization;

namespace Sarsoo.Terraform.MachineReadableUI.Drift;

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