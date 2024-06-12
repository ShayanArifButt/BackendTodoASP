using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackendTodoASP.Models;
using System;
using System.Linq;

namespace BackendTodoASP.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (context.Tasks.Any())
            {
                return;   // DB has been seeded
            }

            context.Tasks.AddRange(
                new TaskItem
                {
                    Description = "Task 1",
                    IsDone = false,
                    Deadline = DateTime.Now.AddDays(1)
                },
                new TaskItem
                {
                    Description = "Task 2",
                    IsDone = true,
                    Deadline = DateTime.Now.AddDays(2)
                }
            );

            context.SaveChanges();
        }
    }
}
