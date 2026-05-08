using System.Text.Json.Serialization;

namespace Sarsoo.Terraform.MachineReadableUI.Validate;

public struct SourcePosition
{
    /// <summary>
    /// A zero-based byte offset into the indicated file.
    /// </summary>
    [JsonPropertyName("byte")]
    public int ByteOffset { get; set; }
    /// <summary>
    /// A one-based line count for the line containing the relevant position in the indicated file.
    /// </summary>
    [JsonPropertyName("line")]
    public int LineNumber { get; set; }
    /// <summary>
    /// A one-based count of Unicode characters from the start of the line indicated in line.
    /// </summary>
    [JsonPropertyName("column")]
    public int ColumnNumber { get; set; }
}