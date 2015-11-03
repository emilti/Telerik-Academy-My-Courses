namespace ArtistSystem.Data
{
    using Models;  
    using System.Data.Entity;

    public class ArtistSystemDbContext : DbContext, IArtistSystemDbContext
    {
        public ArtistSystemDbContext()
            : base("DefaultConnection")
        {
        }

        public virtual IDbSet<Song> Songs { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Album> Albums { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public static ArtistSystemDbContext Create()
        {
            return new ArtistSystemDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
