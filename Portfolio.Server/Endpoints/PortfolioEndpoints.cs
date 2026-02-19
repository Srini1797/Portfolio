using Portfolio.Server.Repositories;
using Portfolio.Shared.Models;

namespace Portfolio.Server.Endpoints;

public static class PortfolioEndpoints
{
    public static void MapPortfolioEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api");

        group.MapGet("/profile", async (IPortfolioRepository repo) =>
            await repo.GetProfileAsync())
            .WithName("GetProfile");

        group.MapGet("/skills", async (IPortfolioRepository repo) =>
        {
            var skills = await repo.GetSkillsAsync();
            return Results.Ok(skills.GroupBy(s => s.Category)
                .Select(g => new { Category = g.Key, Skills = g.ToList() }));
        })
        .WithName("GetSkills");

        group.MapGet("/experience", async (IPortfolioRepository repo) =>
            await repo.GetExperiencesAsync())
            .WithName("GetExperience");

        group.MapGet("/projects", async (IPortfolioRepository repo) =>
            await repo.GetProjectsAsync())
            .WithName("GetProjects");

        group.MapGet("/education", async (IPortfolioRepository repo) =>
            await repo.GetEducationAsync())
            .WithName("GetEducation");

        group.MapPost("/contact", async (ContactMessage message, IPortfolioRepository repo) =>
        {
            await repo.AddContactMessageAsync(message);
            return Results.Ok(new { Success = true, Message = "Message sent successfully" });
        })
        .WithName("PostContact");
    }
}
