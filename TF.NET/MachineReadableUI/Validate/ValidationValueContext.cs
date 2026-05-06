namespace TF.MachineReadableUI.Validate;

/// <summary>
/// An expression value object gives additional information about a value that is part of the expression which triggered the diagnostic. This is especially useful when using for_each or similar constructs, in order to identify exactly which values are responsible for an error. The object has two properties:
/// </summary>
public struct ValidationValueContext
{
    /// <summary>
    /// An HCL-like traversal string, such as var.instance_count. Complex index key values may be elided, so this will not always be valid, parseable HCL. The contents of this string are intended to be human-readable.
    /// </summary>
    public string Traversal { get; set; }
    /// <summary>
    /// A short English-language fragment describing the value of the expression when the diagnostic was triggered. The contents of this string are intended to be human-readable and are subject to change in future versions of Terraform.
    /// </summary>
    public string Statement { get; set; }
}