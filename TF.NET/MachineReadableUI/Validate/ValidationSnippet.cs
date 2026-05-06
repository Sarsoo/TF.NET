using System.Text.Json.Serialization;

namespace TF.MachineReadableUI.Validate;

/// <summary>
/// An optional object including an excerpt of the configuration source code that the diagnostic message relates to.
/// </summary>
public struct ValidationSnippet
{
    /// <summary>
    /// An optional summary of the root context of the diagnostic. For example, this might be the resource block containing the expression that triggered the diagnostic. For some diagnostics, this information is not available, and then this property will be null.
    /// </summary>
    public string? Context { get; set; }
    /// <summary>
    /// A snippet of Terraform configuration including the source of the diagnostic. This can be multiple lines and may include additional configuration source code around the expression which triggered the diagnostic.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// A one-based line count representing the position in the source file at which the code excerpt begins. This is not necessarily the same value as range.start.line, as it is possible for code to include one or more lines of context before the source of the diagnostic.
    /// </summary>
    [JsonPropertyName("start_line")]
    public int StartLine { get; set; }
    /// <summary>
    /// A zero-based character offset into the code string, pointing at the start of the expression which triggered the diagnostic.
    /// </summary>
    [JsonPropertyName("highlight_start_offset")]
    public int HighlightStartOffset { get; set; }
    /// <summary>
    /// A zero-based character offset into the code string, pointing at the end of the expression which triggered the diagnostic.
    /// </summary>
    [JsonPropertyName("highlight_end_offset")]
    public int HighlightEndOffset { get; set; }
    /// <summary>
    /// Contains zero or more expression values which may be useful in understanding the source of a diagnostic in a complex expression. These expression value objects are described below.
    /// </summary>
    public List<ValidationValueContext> Values { get; set; }
}