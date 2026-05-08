namespace Sarsoo.Terraform.FileSystem;

public static class SourceResolver
{
    public static IEnumerable<string> FindSourceDirectories(string path)
    {
        foreach (var subValue in Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories))
        {
            if (!subValue.Contains(".terraform"))
            {
                if (Directory.EnumerateFiles(subValue, "*", SearchOption.TopDirectoryOnly)
                    .Any(s => Path.GetExtension(s).Equals(".tf")))
                {
                    yield return subValue;
                }
            }
        }
    }
}