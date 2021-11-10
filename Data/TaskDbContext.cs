using Microsoft.EntityFrameworkCore;
using tasks.entities;

namespace Tasks.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskDbContext(DbContextOptions options)
            : base(options) { }
    }
}