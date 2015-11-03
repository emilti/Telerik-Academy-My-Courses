namespace ArtistSystem.Api.Controllers
{
    using System.Linq;
    using Data;
    using Models;
    using System.Web.Http;
    using Services.Models;

    public class ArtistsController : ApiController
    {
        private readonly IArtistSystemData data;

        public ArtistsController()
             : this(new ArtistSystemData())
        {
        }

        public ArtistsController(IArtistSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var courses = this.data.Artists.All().ToList();
            return this.Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistRequestModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Artists
                .Add(new Artist
                {
                    Name = artist.Name,
                    Country = artist.Country,
                    DateOfBirth = artist.DateOfBirth
                });

            this.data.Artists.SaveChanges();

            return Ok(artist);

        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistRequestModel artist)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var artistInDb = this.data.Artists
                .All()
                .FirstOrDefault(c => c.Id == id);

            artistInDb.Name = artist.Name;
            artistInDb.Country = artist.Country;
            artistInDb.DateOfBirth = artist.DateOfBirth;

            this.data.Artists.SaveChanges();

            return Ok(artistInDb);

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var artistFromDatabase = this.data.Artists.All()
                          .FirstOrDefault(a => a.Id == id);

            if (artistFromDatabase == null)
            {
                return BadRequest("Artist not exist - invalid id");
            }

            this.data.Artists.Delete(artistFromDatabase);
            this.data.Artists.SaveChanges();

            return Ok();
        }
    }
}