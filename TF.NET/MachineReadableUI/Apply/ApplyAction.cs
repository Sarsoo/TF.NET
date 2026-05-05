using System.Text.Json.Serialization;
using TF.NET.MachineReadableUI.Drift;

namespace TF.NET.MachineReadableUI.Apply;

[JsonConverter(typeof(JsonStringEnumConverter<ApplyAction>))]
public enum ApplyAction
{
    [JsonStringEnumMemberName("noop")]
    NoOp,
    [JsonStringEnumMemberName("create")]
    Create,
    [JsonStringEnumMemberName("read")]
    Read,
    [JsonStringEnumMemberName("update")]
    Update,
    [JsonStringEnumMemberName("replace")]
    Replace,
    [JsonStringEnumMemberName("delete")]
    Delete
}