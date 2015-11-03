namespace ArtistSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface IArtistSystemDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Song> Songs { get; set; }

        IDbSet<Artist> Artists { get; set; }

        void SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}



