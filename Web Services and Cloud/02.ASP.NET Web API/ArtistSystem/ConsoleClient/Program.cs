namespace ConsoleClient
{
    using ArtistSystem.Data;
    using StudentsSystem.Api.App_Start;
    using System;

    public class Startup
    {
        private static readonly IArtistSystemData Data = new ArtistSystemData();

        internal static void Main()
        {
            DatabaseConfig.Initialize();         
            var connection = new Uri("http://localhost:1929/");
        }
    }
}
