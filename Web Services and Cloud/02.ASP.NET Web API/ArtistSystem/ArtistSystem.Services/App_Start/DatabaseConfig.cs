namespace StudentsSystem.Api.App_Start
{
    using ArtistSystem.Data;
    using ArtistSystem.Data.Migrations;
    using System.Data.Entity;
    // using ArtistSystem.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArtistSystemDbContext, Configuration>());
            ArtistSystemDbContext.Create().Database.Initialize(true);
        }
    }
}