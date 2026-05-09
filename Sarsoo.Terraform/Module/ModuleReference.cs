namespace Sarsoo.Terraform.Module;

public record struct ModuleReference(string Source, ModuleSourceType SourceType, string? Version);