using System.Text.Json.Serialization;
using TF.MachineReadableUI.Apply;
using TF.MachineReadableUI.Drift;
using TF.MachineReadableUI.Validate;

namespace TF.MachineReadableUI.Json;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower)]
[JsonSerializable(typeof(BaseMessage))]
[JsonSerializable(typeof(FullMessage))]

[JsonSerializable(typeof(Resource))]
[JsonSerializable(typeof(ResourceDriftChange))]
[JsonSerializable(typeof(ResourceAction))]

[JsonSerializable(typeof(ChangeSummary))]
[JsonSerializable(typeof(ChangeOperation))]
[JsonSerializable(typeof(ChangeReason))]

[JsonSerializable(typeof(Hook))]

[JsonSerializable(typeof(ValidationOutput))]
[JsonSerializable(typeof(ValidationDiagnostic))]
[JsonSerializable(typeof(ValidationDiagnosticRange))]
[JsonSerializable(typeof(ValidationOutput))]
[JsonSerializable(typeof(ValidationSnippet))]
[JsonSerializable(typeof(ValidationValueContext))]
[JsonSerializable(typeof(SourcePosition))]
public partial class MruiContext : JsonSerializerContext
{ }