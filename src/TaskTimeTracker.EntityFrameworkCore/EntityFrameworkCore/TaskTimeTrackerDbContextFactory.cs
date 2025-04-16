using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TaskTimeTracker.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TaskTimeTrackerDbContextFactory : IDesignTimeDbContextFactory<TaskTimeTrackerDbContext>
{
    public TaskTimeTrackerDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        TaskTimeTrackerEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<TaskTimeTrackerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new TaskTimeTrackerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TaskTimeTracker.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
