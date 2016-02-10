using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TwitterSystem.Data;
using TwitterSystem.Data.Migrations;

namespace TwitterSystem.Api.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterSystemDbContext, Configuration>());
            TwitterSystemDbContext.Create().Database.Initialize(true);
        }
    }
}