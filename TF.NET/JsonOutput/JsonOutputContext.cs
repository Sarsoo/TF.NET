using System.Text.Json.Serialization;
using TF.JsonOutput.Change;
using TF.JsonOutput.Plan;
using TF.JsonOutput.State;
using TF.JsonOutput.Value;

namespace TF.JsonOutput;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower)]
[JsonSerializable(typeof(ValuesRepresentation))]
[JsonSerializable(typeof(ModuleRepresentation))]
[JsonSerializable(typeof(ResourceRepresentation))]
[JsonSerializable(typeof(ResourceMode))]

[JsonSerializable(typeof(StateRepresentation))]

[JsonSerializable(typeof(PlanRepresentation))]
[JsonSerializable(typeof(ResourceChange))]
[JsonSerializable(typeof(ActionReason))]

[JsonSerializable(typeof(ChangeRepresentation))]

[JsonSerializable(typeof(Variable))]
public partial class JsonOutputContext : JsonSerializerContext
{ }