namespace ArtistSystem.Data
{    
    using Models;
    using ArtistSystem.Data.Repositories;

    public interface IArtistSystemData
    {
        IRepository<Song> Songs { get; }

        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        void SaveChanges();
    }
}


