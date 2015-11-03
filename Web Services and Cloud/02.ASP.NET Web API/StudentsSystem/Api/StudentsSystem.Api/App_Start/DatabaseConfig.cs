using StudentsSystem.Data;
using System.Data.Entity;
using StudentsSystem.Data.Migrations;

namespace StudentsSystem.Api.App_Start
{

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsSystemDbContext, Configuration>());
            StudentsSystemDbContext.Create().Database.Initialize(true);
        }
    }
}