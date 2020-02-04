using dot_social.Entities;
using System.Data.Entity;
using dot_social.DatabaseConfig;

namespace dot_social.Database
{
  [DbConfigurationType(typeof(DbConfig))]
  public class DataContext : DbContext
  {
    public DbSet<Location> Locations { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Relationship> Relationships { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Like> Likes { get; set; }
  }
}

