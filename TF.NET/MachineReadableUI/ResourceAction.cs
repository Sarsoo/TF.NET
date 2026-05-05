using System.Text.Json.Serialization;

namespace TF.NET.MachineReadableUI;

[JsonConverter(typeof(JsonStringEnumConverter<ResourceAction>))]
public enum ResourceAction
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
    Delete,
    [JsonStringEnumMemberName("move")]
    Move,
    [JsonStringEnumMemberName("import")]
    Import
}