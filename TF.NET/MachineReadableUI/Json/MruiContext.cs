using System.Text.Json.Serialization;
using TF.NET.MachineReadableUI.Apply;
using TF.NET.MachineReadableUI.Drift;

namespace TF.NET.MachineReadableUI.Json;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
[JsonSerializable(typeof(BaseMessage))]
[JsonSerializable(typeof(FullMessage))]

[JsonSerializable(typeof(Resource))]
[JsonSerializable(typeof(ResourceDriftChange))]
[JsonSerializable(typeof(ResourceAction))]

[JsonSerializable(typeof(ChangeSummary))]
[JsonSerializable(typeof(ChangeOperation))]
[JsonSerializable(typeof(ChangeReason))]

[JsonSerializable(typeof(Hook))]
public partial class MruiContext : JsonSerializerContext
{ }