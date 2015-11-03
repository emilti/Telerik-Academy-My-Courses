namespace StudentsSystem.Api.Controllers
{
    using Models;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    public class StudentsController : ApiController
    {
        private readonly IStudentsSystemData data;

        public StudentsController()
             : this(new StudentsSystemData())
        {
        }

        public StudentsController(IStudentsSystemData data)
        {
            this.data = data;
        }


        [HttpGet]
        public IHttpActionResult Get()
        {
            var students = this.data.Students.All().ToList();
            return this.Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentsRequestModel student)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Students
                .Add(new Student
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Level = student.Level
                });

            this.data.Students.SaveChanges();

            return Ok(student);

        }

        [HttpPut]
        public IHttpActionResult Update(int id, StudentsRequestModel student)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var studentInDb = this.data.Students
                .All()
                .FirstOrDefault(c => c.StudentIdentification == id);

            studentInDb.FirstName = student.FirstName;
            studentInDb.LastName = student.LastName;
            studentInDb.Level = student.Level;

            this.data.Students.SaveChanges();

            return Ok(studentInDb);

        }
    }
}