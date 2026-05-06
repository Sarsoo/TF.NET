using System.Text.Json;
using System.Text.Json.Serialization;
using TF.JsonOutput.State;
using TF.JsonOutput.Value;

namespace TF.JsonOutput.Plan;

public class PlanRepresentation
{
    public string FormatVersion { get; set; }

    /// <summary>
    /// "prior_state" is a representation of the state that the configuration is being applied to, using the state representation described above.
    /// </summary>
    public StateRepresentation PriorState { get; set; }

    /// <summary>
    /// "applyable" indicates that it would make sense for a wrapping automation
    /// to try to apply this plan, possibly after asking a human operator for
    /// approval.
    ///
    /// Other attributes may give additional context about why the plan is not
    /// applyable, but wrapping automations should use this flag as their
    /// primary condition to accommodate potential changes to the exact definition
    /// of "applyable" in future Terraform versions.
    /// </summary>
    public bool Applyable { get; set; }

    /// <summary>
    /// "complete" indicates that Terraform expects that after applying this
    /// plan the actual state will match the desired state.
    ///
    /// An incomplete plan is expected to require at least one additional
    /// plan/apply round to achieve convergence, and so wrapping automations
    /// should ideally either automatically start a new plan/apply round after
    /// this plan is applied, or prompt the operator that they should do so.
    ///
    /// Other attributes may give additional context about why the plan is not
    /// complete, but wrapping automations should use this flag as their
    /// primary condition to accommodate potential changes to the exact definition
    /// of "complete" in future Terraform versions.
    /// </summary>
    public bool Complete { get; set; }

    /// <summary>
    /// "errored" indicates whether planning failed. An errored plan cannot be applied, but the actions planned before failure may help to understand the error.
    /// </summary>
    public bool Errored { get; set; }

    // public __ Configuration { get; set; }

    /// <summary>
    /// "planned_values" is a description of what is known so far of the outcome in
    /// the standard value representation, with any as-yet-unknown values omitted.
    /// </summary>
    [JsonPropertyName("planned_values")]
    public ValuesRepresentation PlannedValues { get; set; }

    /// <summary>
    /// "proposed_unknown" is a representation of the attributes, including any
    /// potentially-unknown attributes. Each value is replaced with "true" or
    /// "false" depending on whether it is known in the proposed plan.
    /// </summary>
    [JsonPropertyName("proposed_unknown")]
    public ValuesRepresentation ProposedUnknown { get; set; }

    /// <summary>
    /// "variables" is a representation of all the variables provided for the given
    /// plan. This is structured as a map similar to the output map so we can add
    /// additional fields in later.
    /// </summary>
    public JsonElement Variables { get; set; }

}