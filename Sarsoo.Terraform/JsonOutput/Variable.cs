namespace Sarsoo.Terraform.JsonOutput;

public struct Variable
{
    public string Value { get; set; }
    public string Type { get; set; }
    public bool Sensitive { get; set; }
}