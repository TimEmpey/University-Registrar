using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContextFactory : IDesignTimeDbContextFactory<UniversityRegistrarContext>
  {

    UniversityRegistrarContext IDesignTimeDbContextFactory<UniversityRegistrarContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<UniversityRegistrarContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new UniversityRegistrarContext(builder.Options);
    }
  }
}