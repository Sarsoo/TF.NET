using System.Text.Json.Serialization;

namespace Sarsoo.Terraform.JsonOutput.Plan;

[JsonConverter(typeof(JsonStringEnumConverter<ActionReason>))]
public enum ActionReason
{
    [JsonStringEnumMemberName("replace_because_tainted")]
    Tainted,
    [JsonStringEnumMemberName("replace_because_cannot_update")]
    ReplaceCannotUpdate,
    [JsonStringEnumMemberName("replace_by_request")]
    ReplaceRequest,
    [JsonStringEnumMemberName("delete_because_no_resource_config")]
    DeleteMissingConfig,
    [JsonStringEnumMemberName("delete_because_no_module")]
    DeleteMissingModule,
    [JsonStringEnumMemberName("delete_because_wrong_repetition")]
    DeleteMissingRepetition,
    [JsonStringEnumMemberName("delete_because_count_index")]
    DeleteCountIndex,
    [JsonStringEnumMemberName("delete_because_each_key")]
    DeleteForEachKey,
    [JsonStringEnumMemberName("read_because_config_unknown")]
    ReadConfigUnknown,
    [JsonStringEnumMemberName("read_because_dependency_pending")]
    ReadDependencyPending,
}