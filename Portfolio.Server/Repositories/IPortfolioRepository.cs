using Portfolio.Shared.Models;

namespace Portfolio.Server.Repositories;

public interface IPortfolioRepository
{
    Task<Profile?> GetProfileAsync();
    Task<IEnumerable<Skill>> GetSkillsAsync();
    Task<IEnumerable<Experience>> GetExperiencesAsync();
    Task<IEnumerable<Project>> GetProjectsAsync();
    Task<IEnumerable<Education>> GetEducationAsync();
    Task AddContactMessageAsync(ContactMessage message);
}
