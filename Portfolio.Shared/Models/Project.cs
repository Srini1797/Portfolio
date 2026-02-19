namespace Portfolio.Shared.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Scope { get; set; } = string.Empty;
    public List<string> Contributions { get; set; } = new();
    public List<string> Technologies { get; set; } = new();
    public string? ImageUrl { get; set; }
    public string? LiveUrl { get; set; }
    public string? GitHubUrl { get; set; }
    public int DisplayOrder { get; set; }
}
