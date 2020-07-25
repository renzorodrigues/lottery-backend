using lotteryBack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace lotteryBack.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<UserGroup> UserGroup { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<UserGroup>().HasKey(ug => new { ug.UserId, ug.GroupId });

      // modelBuilder.Entity<UserGroup>()
      // .HasOne<User>(ug => ug.User)
      // .WithMany(u => u.UserGroup)
      // .HasForeignKey(ug => ug.UserId);

      // modelBuilder.Entity<UserGroup>()
      // .HasOne<Group>(ug => ug.Group)
      // .WithMany(g => g.UserGroup)
      // .HasForeignKey(ug => ug.GroupId);
    }
  }
}