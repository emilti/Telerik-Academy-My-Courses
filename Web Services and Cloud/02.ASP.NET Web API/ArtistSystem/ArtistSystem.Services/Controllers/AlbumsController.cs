namespace ArtistSystem.Api.Controllers
{
    using System.Linq;
    using Data;
    using Models;
    using System.Web.Http;
    using Services.Models;

    public class AlbumsController : ApiController
    {
        private readonly IArtistSystemData data;

        public AlbumsController()
             : this(new ArtistSystemData())
        {
        }

        public AlbumsController(IArtistSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var albums = this.data.Albums.All().ToList();
            return this.Ok(albums);
        }

        [HttpPost]
        public IHttpActionResult Create(AlbumRequestModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Albums
                .Add(new Album
                {
                    Title = album.Title,
                    Year = album.Year,
                    Price = album.Price,
                    Producer = album.Producer
                });

            this.data.Albums.SaveChanges();

            return Ok(album);

        }

        [HttpPut]
        public IHttpActionResult Update(int id, AlbumRequestModel album)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var albumInDb = this.data.Albums
                .All()
                .FirstOrDefault(c => c.Id == id);

            albumInDb.Title = album.Title;
            albumInDb.Year = album.Year;
            albumInDb.Price = album.Price;
            albumInDb.Producer = album.Producer;

            this.data.Albums.SaveChanges();

            return Ok(albumInDb);

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var albumFromDatabase = this.data.Albums.All()
                          .FirstOrDefault(a => a.Id == id);

            if (albumFromDatabase == null)
            {
                return BadRequest("Song does not exist - invalid id");
            }

            this.data.Albums.Delete(albumFromDatabase);
            this.data.Albums.SaveChanges();

            return Ok();
        }
    }
}