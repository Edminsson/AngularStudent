using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class TreeController : Controller
    {
        SchoolContext context = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadData()
        {
            List<TreeVm> traddata = new List<TreeVm>();
            traddata = context.Students.Select(x => new TreeVm { Id=x.ID, Title=x.LastName + ", " + x.FirstMidName}).ToList();
            

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(traddata, Formatting.None, settings);
            return Content(json, "application/json");
            //return Json(traddata, JsonRequestBehavior.AllowGet);
        }
        public ActionResult LoadStudent(int? id)
        {
            id = id ?? 1;
            StudentVm student = context.Students.Where(x => x.ID == id).Select(stud => new StudentVm { Id=stud.ID, LastName=stud.LastName, FirstName=stud.FirstMidName}).FirstOrDefault();
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(student, Formatting.None, settings);
            return Content(json, "application/json");
        }
        public ActionResult LoadEnrollments(int? id)
        {
            id = id ?? 1;
            List<EnrollmentVm> enrollments = context.Enrollments.Where(x => x.StudentID == id).Select(e => new EnrollmentVm { Id=e.CourseID, CourseName = e.Course.Title, Credits = e.Course.Credits }).ToList();
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(enrollments, Formatting.None, settings);
            return Content(json, "application/json");
        }
    }
    public class TreeVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class StudentVm
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    public class EnrollmentVm
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
    }
}