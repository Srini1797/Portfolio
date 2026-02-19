using Portfolio.Shared.Models;

namespace Portfolio.Server.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        if (context.Profiles.Any())
        {
            return; // DB has been seeded
        }

        var profile = new Profile
        {
            FullName = "Srinivasan Venkatesan",
            Title = "Senior Full Stack Developer",
            Summary = "6+ years building enterprise solutions with .NET, Angular, and cloud technologies. Proven leader in architecting scalable systems and mentoring high-performing teams.",
            Email = "sriseenu1797@gmail.com",
            LinkedInUrl = "http://www.linkedin.com/in/srinivasan-venkatesan-64a0ab1a0",
            Location = "India",
            ProfileImageUrl = "images/Profile.jpeg",
            Contact = "+916380999052",
        };

        context.Profiles.Add(profile);

        context.Skills.AddRange(
            new Skill { Name = ".NET Core / C#", Category = "Backend", Proficiency = 95, DisplayOrder = 1 },
            new Skill { Name = "ASP.NET Core Minimal APIs", Category = "Backend", Proficiency = 90, DisplayOrder = 2 },
            new Skill { Name = "Angular", Category = "Frontend", Proficiency = 90, DisplayOrder = 3 },
            new Skill { Name = "TypeScript / JavaScript", Category = "Frontend", Proficiency = 85, DisplayOrder = 4 },
            new Skill { Name = "SQL Server / EF Core", Category = "Database", Proficiency = 90, DisplayOrder = 5 },
            new Skill { Name = "Azure Cloud Services", Category = "Cloud", Proficiency = 80, DisplayOrder = 6 },
            new Skill { Name = "Docker / Kubernetes", Category = "Cloud", Proficiency = 75, DisplayOrder = 7 },
            new Skill { Name = "RESTful APIs", Category = "Backend", Proficiency = 95, DisplayOrder = 8 },
            new Skill { Name = "HTML5 / CSS3 / SCSS", Category = "Frontend", Proficiency = 85, DisplayOrder = 9 },
            new Skill { Name = "Git / CI CD", Category = "Tools", Proficiency = 90, DisplayOrder = 10 }
        );

        context.Experiences.AddRange(
            new Experience
            {
                Company = "",
                Role = "Senior Full Stack Developer",
                StartDate = "Oct 2024",
                EndDate = "Present",
                Description = "Leading the development of scalable cloud-native applications.",
                Highlights = new List<string> { 
                    "Architected microservices-based architecture handling 1M+ requests daily",
                    "Mentored 10+ junior developers in .NET and Angular best practices",
                    "Optimized database queries reducing latency by 40%"
                },
                DisplayOrder = 1
            },
            new Experience
            {
                Company = "Twilight IT Solutions",
                Role = "Full Stack Developer",
                StartDate = "Jul 2019",
                EndDate = "Aug 2024",
                Description = "Developed and maintained various web applications for retail clients.",
                Highlights = new List<string> { 
                    "Migrated manual legacy workflows to a structured digital system",
                    "Developed role-based access control and secure authentication modules",
                    "Built responsive front-end dashboards using Angular"
                },
                DisplayOrder = 2
            }
        );

        context.Projects.AddRange(
            new Project
            {
                Name = "Background Screening Platform (Team Lead)",
                Scope = "Screening employees applying for US/UK jobs",
                Description = "A comprehensive platform for background verification and onboarding.",
                Technologies = new List<string> { ".NET Core 6", "Angular 19", "EF Core", "SQL Server", "AWS S3" },
                Contributions = new List<string>
                {
                    "Led end-to-end module design and full-stack development",
                    "Designed scalable onboarding workflows & integrated verification engines",
                    "Implemented background check APIs and secure document-storage workflow",
                    "Improved data processing speed via optimized EF Core LINQ operations"
                },
                DisplayOrder = 1
            },
            new Project
            {
                Name = "Digital Entry System (DES)",
                Scope = "Automate manual visitor entry with a digital registry",
                Description = "Digital registry system for visitor management and entry automation.",
                Technologies = new List<string> { ".NET Core 3", "Angular 9", "ADO.NET", "SQL Server", "IIS" },
                Contributions = new List<string>
                {
                    "Built front-end dashboards and backend REST APIs",
                    "Developed role-based access & secure authentication",
                    "Migrated manual workflows to a structured digital system"
                },
                DisplayOrder = 2
            },
            new Project
            {
                Name = "Logistics Management Platform (Senior Developer)",
                Scope = "Freight forwarding, finance, linear agency operations",
                Description = "Large-scale logistics platform managing cargo and shipping operations.",
                Technologies = new List<string> { ".NET Core 6", "Angular 15", "SQL Server", "Microservices" },
                Contributions = new List<string>
                {
                    "Implemented microservices for cargo, billing, and shipment workflows",
                    "Created data-sync services for real-time logistics updates",
                    "Optimized heavy financial reconciliation modules"
                },
                DisplayOrder = 3
            },
            new Project
            {
                Name = "Healthcare Appointment & Management System",
                Scope = "Schedules, operations & patient management",
                Description = "Healthcare system for managing patient appointments and hospital operations.",
                Technologies = new List<string> { ".NET Framework", "EF", "Angular", "MySQL", "Azure" },
                Contributions = new List<string>
                {
                    "Developed appointment scheduling engine",
                    "Built UI modules for patient record management",
                    "Created secure REST endpoints for hospital operations"
                },
                DisplayOrder = 4
            },
            new Project
            {
                Name = "Student Project Lifecycle Platform",
                Scope = "Educational simulation platform for SimProject & SimAgile",
                Description = "Simulation platform for educational project management and agile learning.",
                Technologies = new List<string> { ".NET Core", "React.js", "MySQL", "JIRA" },
                Contributions = new List<string>
                {
                    "Developed React-based UI components",
                    "Built backend micro-APIs for learning workflows",
                    "Integrated JIRA automation"
                },
                DisplayOrder = 5
            }
        );

        context.Educations.AddRange(
            new Education
            {
                Degree = "Bachelor of Computer Science",
                Institution = "Thiruvallur University",
                StartDate = "2016",
                EndDate = "2019"
            },
            new Education
            {
                Degree = "Master of Computer Science",
                Institution = "Thiruvallur University",
                StartDate = "2020",
                EndDate = "2022"
            });

        context.SaveChanges();
    }
}
