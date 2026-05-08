namespace Sarsoo.Terraform.MachineReadableUI.Validate;

/// <summary>
/// An optional object referencing a portion of the configuration source code that the diagnostic message relates to. For errors, this will typically indicate the bounds of the specific block header, attribute, or expression which was detected as invalid.
///
/// A source range is an object with a property filename that gives the filename as a relative path from the current working directory, and then two properties start and end which are both themselves objects describing source positions, as described below.
///
/// Not all diagnostic messages are connected with specific portions of the configuration, so range will be omitted or null for diagnostic messages where it isn't relevant.
/// </summary>
public struct ValidationDiagnosticRange
{
    public string Filename { get; set; }
    public SourcePosition Start { get; set; }
    public SourcePosition End { get; set; }
}