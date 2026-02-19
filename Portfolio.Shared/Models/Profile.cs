namespace Portfolio.Shared.Models;

public class Profile
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;
    public string? GitHubUrl { get; set; }
    public string? Contact { get; set; }
    public string? Location { get; set; }
    public string? ProfileImageUrl { get; set; }
}
