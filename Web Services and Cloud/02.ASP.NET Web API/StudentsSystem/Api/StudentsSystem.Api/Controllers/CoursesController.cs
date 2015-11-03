namespace StudentsSystem.Api.Controllers
{
    using Models;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System.Web.Http;

    public class CoursesController : ApiController
    {
        private readonly IStudentsSystemData data;

        public CoursesController()
             : this(new StudentsSystemData())
        {
        }

        public CoursesController(IStudentsSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var courses = this.data.Courses.All().ToList();    
            return this.Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseRequestModel course)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Courses
                .Add(new Course
                {
                    Name = course.Name,
                    Description = course.Description
                });

            this.data.Courses.SaveChanges();

            return Ok(course);
           
        }

        [HttpPut]
        public IHttpActionResult Update(int id, CourseRequestModel course)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var courseInDb = this.data.Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            courseInDb.Description = course.Description;
            courseInDb.Name = course.Name;

            this.data.Courses.SaveChanges();

            return Ok(course);

        }
    }
}