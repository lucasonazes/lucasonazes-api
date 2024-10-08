using Microsoft.EntityFrameworkCore;

public class TaskSystemDBContext : DbContext
{
    public TaskSystemDBContext(DbContextOptions<TaskSystemDBContext> options)
        : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }
    public DbSet<TaskModel> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}