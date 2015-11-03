using StudentsSystem.Api.Models;
using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentsSystem.Api.Controllers
{
    public class HomeworksController : ApiController
    {
        private readonly IStudentsSystemData data;

        public HomeworksController()
             : this(new StudentsSystemData())
        {
        }

        public HomeworksController(IStudentsSystemData data)
        {
            this.data = data;
        }


        [HttpGet]
        public IHttpActionResult Get()
        {
            var homeworks = this.data.Homeworks.All().ToList();
            return this.Ok(homeworks);
        }

        [HttpPost]
        public IHttpActionResult Create(HomeworkRequestModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            this.data
                .Homeworks
                .Add(new Homework
                {
                    FileUrl = homework.FileUrl,
                    // StudentIdentification = homework.StudentIdentification,
                    // CourseId = homework.CourseId                  
                });

            this.data.Homeworks.SaveChanges();

            return Ok(homework);

        }

        [HttpPut]
        public IHttpActionResult Update(int id, HomeworkRequestModel homework)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var homeworkInDb = this.data.Homeworks
                .All()
                .FirstOrDefault(c => c.Id == id);

            homeworkInDb.FileUrl = homework.FileUrl;           

            this.data.Homeworks.SaveChanges();

            return Ok(homeworkInDb);
        }
    }
}