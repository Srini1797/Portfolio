namespace Portfolio.Shared.Models;

public class Experience
{
    public int Id { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string? EndDate { get; set; } // null = "Present"
    public string Description { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = new();
    public int DisplayOrder { get; set; }
}
