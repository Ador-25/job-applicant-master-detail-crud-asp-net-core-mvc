using Microsoft.EntityFrameworkCore;
using ResumeManager.Models;

namespace ResumeManager.Contexts
{
    public class ResumeDbContext:DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options):base (options)
        {

        }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
