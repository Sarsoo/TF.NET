using System.Text.Json.Serialization;
using Sarsoo.Terraform.JsonOutput.Change;
using Sarsoo.Terraform.JsonOutput.Plan;
using Sarsoo.Terraform.JsonOutput.State;
using Sarsoo.Terraform.JsonOutput.Value;

namespace Sarsoo.Terraform.JsonOutput;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower)]
[JsonSerializable(typeof(ValuesRepresentation))]
[JsonSerializable(typeof(ModuleRepresentation))]
[JsonSerializable(typeof(ResourceRepresentation))]
[JsonSerializable(typeof(ResourceMode))]

[JsonSerializable(typeof(StateRepresentation))]

[JsonSerializable(typeof(PlanRepresentation))]
[JsonSerializable(typeof(ResourceChange))]
[JsonSerializable(typeof(ResourceAttributeReference))]
[JsonSerializable(typeof(ActionReason))]

[JsonSerializable(typeof(ChangeRepresentation))]

[JsonSerializable(typeof(Variable))]
public partial class JsonOutputContext : JsonSerializerContext
{ }