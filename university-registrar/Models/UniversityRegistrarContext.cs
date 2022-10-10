using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<CourseStudent> CourseStudent { get; set; }
    public DbSet<CourseDepartment> CourseDepartment { get; set; }
    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}