namespace Sarsoo.Terraform.MachineReadableUI.Validate;

public struct ValidationDiagnostic
{
    /// <summary>
    /// A string keyword, either "error" or "warning", indicating the diagnostic severity.
    ///
    /// The presence of errors causes Terraform to consider a configuration to be invalid, while warnings are just advice or caveats to the user which do not block working with the configuration. Later versions of Terraform may introduce new severity keywords, so consumers should be prepared to accept and ignore severity values they don't understand.
    /// </summary>
    public string Severity { get; set; }
    /// <summary>
    /// A short description of the nature of the problem that the diagnostic is reporting.
    ///
    /// In Terraform's usual human-oriented diagnostic messages, the summary serves as a sort of "heading" for the diagnostic, printed after the "Error:" or "Warning:" indicator.
    ///
    /// Summaries are typically short, single sentences, but can sometimes be longer as a result of returning errors from subsystems that are not designed to return full diagnostics, where the entire error message becomes the summary. In those cases, the summary might include newline characters which a renderer should honor when presenting the message visually to a user.
    /// </summary>
    public string Summary { get; set; }
    /// <summary>
    /// An optional additional message giving more detail about the problem.
    ///
    /// In Terraform's usual human-oriented diagnostic messages, the detail provides the paragraphs of text that appear after the heading and the source location reference.
    ///
    /// Detail messages are often multiple paragraphs and possibly interspersed with non-paragraph lines, so tools that aim to present detailed messages to the user should distinguish between lines without leading spaces, treating them as paragraphs, and lines with leading spaces, treating them as preformatted text. Renderers should then soft-wrap the paragraphs to fit the width of the rendering container, but leave the preformatted lines unwrapped.
    ///
    /// Some Terraform detail messages contain an approximation of bullet lists using ASCII characters to mark the bullets. This is not a contractual formatting convention, so renderers should avoid depending on it and should instead treat those lines as either paragraphs or preformatted text.
    /// </summary>
    public string Detail { get; set; }
    /// <summary>
    /// An optional object referencing a portion of the configuration source code that the diagnostic message relates to. For errors, this will typically indicate the bounds of the specific block header, attribute, or expression which was detected as invalid.
    ///
    /// A source range is an object with a property filename that gives the filename as a relative path from the current working directory, and then two properties start and end which are both themselves objects describing source positions, as described below.
    ///
    /// Not all diagnostic messages are connected with specific portions of the configuration, so range will be omitted or null for diagnostic messages where it isn't relevant.
    /// </summary>
    public ValidationDiagnosticRange? Range { get; set; }
}