using System.Text.Json.Serialization;
using TF.NET.MachineReadableUI.Apply;
using TF.NET.MachineReadableUI.Drift;

namespace TF.NET.MachineReadableUI.Json;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
[JsonSerializable(typeof(BaseMessage))]
[JsonSerializable(typeof(Resource))]
[JsonSerializable(typeof(ResourceDriftChange))]
[JsonSerializable(typeof(DriftAction))]
[JsonSerializable(typeof(ChangeSummary))]
[JsonSerializable(typeof(ChangeOperation))]
[JsonSerializable(typeof(Hook))]
[JsonSerializable(typeof(ApplyAction))]
public partial class MruiContext : JsonSerializerContext
{ }