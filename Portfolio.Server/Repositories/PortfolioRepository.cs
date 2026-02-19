using Microsoft.EntityFrameworkCore;
using Portfolio.Server.Data;
using Portfolio.Shared.Models;

namespace Portfolio.Server.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    private readonly AppDbContext _context;

    public PortfolioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Profile?> GetProfileAsync() =>
        await _context.Profiles.FirstOrDefaultAsync();

    public async Task<IEnumerable<Skill>> GetSkillsAsync() =>
        await _context.Skills.OrderBy(s => s.DisplayOrder).ToListAsync();

    public async Task<IEnumerable<Experience>> GetExperiencesAsync() =>
        await _context.Experiences.OrderBy(e => e.DisplayOrder).ToListAsync();

    public async Task<IEnumerable<Project>> GetProjectsAsync() =>
        await _context.Projects.OrderBy(p => p.DisplayOrder).ToListAsync();

    public async Task<IEnumerable<Education>> GetEducationAsync() =>
        await _context.Educations.ToListAsync();

    public async Task AddContactMessageAsync(ContactMessage message)
    {
        _context.ContactMessages.Add(message);
        await _context.SaveChangesAsync();
    }
}
