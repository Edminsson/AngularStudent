using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class InitieraDatabasController : Controller
    {
        SchoolContext context = new SchoolContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StartaInitieringen()
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Anders",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Anna",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Alex",LastName="Anderssin",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Bertil",LastName="Bengtsson",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Bengt",LastName="Berg",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Benny",LastName="Balotelli",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Carl",LastName="Carson",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Cesar",LastName="Cure",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Carlos",LastName="Contoso",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Christian",LastName="Carlsson",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Chico",LastName="Contento",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Chancho",LastName="Callado",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Daniel",LastName="Duke",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="David",LastName="Dublin",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Dora",LastName="Domingo",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Dinah",LastName="Darling",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Delilah",LastName="Denver",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Debra",LastName="Davidsson",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Eric",LastName="Elmander",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Emanuel",LastName="Estrellado",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Federico",LastName="Fulano",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Fanny",LastName="Fabulous",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Fabiana",LastName="Fernandez",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Fat",LastName="Finn",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Gustavo",LastName="Godera",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Glenn",LastName="Gustavsson",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Jack",LastName="June",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Kira",LastName="Kent",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Lars",LastName="Lind",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Lenny",LastName="Lund",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Lonnie",LastName="Last",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Leslie",LastName="Loonie",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Mandy",LastName="Morales",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Marc",LastName="Mestizo",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Mira",LastName="Manuela",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Nuno",LastName="Nunes",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Nina",LastName="Nolan",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Orlando",LastName="Oregano",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Pato",LastName="Palona",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Roland",LastName="Rico",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Sonny",LastName="Salmander",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Tony",LastName="Tiago",EnrollmentDate=DateTime.Parse("2012-09-01")},
            };

            //students.ForEach(s => context.Students.Add(s));
            //context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3, DepartmentID=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3, DepartmentID=4},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3, DepartmentID=4},
            new Course{CourseID=1045,Title="Calculus",Credits=4, DepartmentID=3},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4, DepartmentID=3},
            new Course{CourseID=2021,Title="Composition",Credits=3, DepartmentID=2},
            new Course{CourseID=2042,Title="Literature",Credits=4, DepartmentID=2}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
            return View();
        }
    }
}