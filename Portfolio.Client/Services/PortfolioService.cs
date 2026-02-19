using System.Net.Http.Json;
using Portfolio.Shared.Models;

namespace Portfolio.Client.Services;

public interface IPortfolioService
{
    Task<Profile?> GetProfileAsync();
    Task<IEnumerable<SkillGroup>?> GetSkillsAsync();
    Task<IEnumerable<Experience>?> GetExperiencesAsync();
    Task<IEnumerable<Project>?> GetProjectsAsync();
    Task<IEnumerable<Education>?> GetEducationAsync();
    Task<bool> SendContactMessageAsync(ContactMessage message);
}

public class SkillGroup
{
    public string Category { get; set; } = string.Empty;
    public List<Skill> Skills { get; set; } = new();
}

public class PortfolioService : IPortfolioService
{
    private readonly HttpClient _http;

    public PortfolioService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Profile?> GetProfileAsync() =>
        await _http.GetFromJsonAsync<Profile>("api/profile");

    public async Task<IEnumerable<SkillGroup>?> GetSkillsAsync() =>
        await _http.GetFromJsonAsync<IEnumerable<SkillGroup>>("api/skills");

    public async Task<IEnumerable<Experience>?> GetExperiencesAsync() =>
        await _http.GetFromJsonAsync<IEnumerable<Experience>>("api/experience");

    public async Task<IEnumerable<Project>?> GetProjectsAsync() =>
        await _http.GetFromJsonAsync<IEnumerable<Project>>("api/projects");

    public async Task<IEnumerable<Education>?> GetEducationAsync() =>
        await _http.GetFromJsonAsync<IEnumerable<Education>>("api/education");

    public async Task<bool> SendContactMessageAsync(ContactMessage message)
    {
        var response = await _http.PostAsJsonAsync("api/contact", message);
        return response.IsSuccessStatusCode;
    }
}
