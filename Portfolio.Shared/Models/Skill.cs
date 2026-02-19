namespace Portfolio.Shared.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // "Frontend", "Backend", "Cloud", "Database", "Tools"
    public int Proficiency { get; set; } // 1-100
    public int DisplayOrder { get; set; }
}
