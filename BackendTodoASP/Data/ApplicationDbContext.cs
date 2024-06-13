using Microsoft.EntityFrameworkCore;
using BackendTodoASP.Models;

namespace BackendTodoASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data conditionally
            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem
                {
                    Description = "This is a seeded Task 1 on app start",
                    IsDone = false,
                    Deadline = DateTime.Now.AddDays(1)
                },
                new TaskItem
                {
                    Description = "This is a seeded Task 2 on app start",
                    IsDone = true,
                    Deadline = DateTime.Now.AddDays(2)
                }
            );
        }
    }
}
