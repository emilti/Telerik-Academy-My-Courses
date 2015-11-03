namespace ArtistSystem.Api.Controllers
{
    using System.Linq;
    using Data;
    using Models;
    using System.Web.Http;
    using Services.Models;

    public class SongsController : ApiController
    {
        private readonly IArtistSystemData data;

        public SongsController()
             : this(new ArtistSystemData())
        {
        }

        public SongsController(IArtistSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var songs = this.data.Songs.All().ToList();
            return this.Ok(songs);
        }

        [HttpPost]
        public IHttpActionResult Create(SongRequestModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Songs
                .Add(new Song
                {
                    Title = song.Title,
                    Year = song.Year,
                    Genre = song.Genre                    
                });

            this.data.Songs.SaveChanges();

            return Ok(song);

        }

        [HttpPut]
        public IHttpActionResult Update(int id, SongRequestModel song)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var songInDb = this.data.Songs
                .All()
                .FirstOrDefault(c => c.Id == id);

            songInDb.Title = song.Title;
            songInDb.Year = song.Year;
            songInDb.Genre = song.Genre;

            this.data.Songs.SaveChanges();

            return Ok(songInDb);

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var songFromDatabase = this.data.Songs.All()
                          .FirstOrDefault(a => a.Id == id);

            if (songFromDatabase == null)
            {
                return BadRequest("Song does not exist - invalid id");
            }

            this.data.Songs.Delete(songFromDatabase);
            this.data.Songs.SaveChanges();

            return Ok();
        }
    }
}