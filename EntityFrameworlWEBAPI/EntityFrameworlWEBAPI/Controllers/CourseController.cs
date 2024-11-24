using EntityFrameworlWEBAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworlWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {


        //[HttpGet]
        //public IEnumerable<Course> Get()
        //{
        //    using (var db_context = new EfLearningContext())
        //    {
        //        //return db_context.Courses.ToList();

        //        return db_context.Courses.Where(a => a.CourseId == 9).ToList();

        //    }
        //}

        [HttpGet("/course/{id}")]
        public IEnumerable<Course> GetCourseById(int id)
        {
            using (var db_context = new EfLearningContext())
            {
                return db_context.Courses.Where(a => a.CourseId == id).ToList();
            }
        }

        [HttpPost("/course/{id}")]
        public IEnumerable<Course> AddCourse(int id)
        {
            using(var db_context = new EfLearningContext())
            {
                Course course = new Course();
                course.CourseName = "ASP.NET Core";
                course.CourseId = id;
                course.CourseCategory = "ORM";

                db_context.Courses.Add(course);
                db_context.SaveChanges();

                return db_context.Courses.Where(a => a.CourseId == id).ToList();

            }
        }

        [HttpPut("/course/{id}")]
        public IEnumerable<Course> UpdateCourse(int id)
        {
            using( var db_context = new EfLearningContext())
            {
                Course course = db_context.Courses.Where(a => a.CourseName == "ASP.NET Core").FirstOrDefault();
                course.CourseName = "ASP.NET";

                db_context.SaveChanges();

                return db_context.Courses.Where(a => a.CourseName == "ADO.NET").ToList();
            }
        }
    }
}
