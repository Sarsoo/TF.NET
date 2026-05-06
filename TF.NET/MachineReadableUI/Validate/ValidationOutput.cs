namespace TF.MachineReadableUI.Validate;

public class ValidationOutput
{
    /// <summary>
    /// Summarizes the overall validation result, by indicating true if Terraform considers the current configuration to be valid or false if it detected any errors.
    /// </summary>
    public bool Valid { get; set; }
    /// <summary>
    /// A zero or positive whole number giving the count of errors Terraform detected. If valid is true then error_count will always be zero, because it is the presence of errors that indicates that a configuration is invalid.
    /// </summary>
    public int ErrorCount { get; set; }
    /// <summary>
    /// A zero or positive whole number giving the count of warnings Terraform detected. Warnings do not cause Terraform to consider a configuration to be invalid, but they do indicate potential caveats that a user should consider and possibly resolve.
    /// </summary>
    public int WarningCount { get; set; }
    /// <summary>
    /// A JSON array of nested objects that each describe an error or warning from Terraform.
    /// </summary>
    public List<ValidationDiagnostic>? Diagnostics { get; set; }
}