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
    }
}
