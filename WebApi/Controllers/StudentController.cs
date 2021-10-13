using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using DataAccessLayer;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        WebApi12SepEntities entities = new WebApi12SepEntities();

        public IEnumerable<StudentViewModel> Get()
        {
            var studentRecord = (from stu in entities.Students
                                 join c in entities.Courses
                                 on stu.CourseId equals c.Id
                                 select new StudentViewModel
                                 {
                                     Id = stu.Id,
                                     StuName = stu.StuName,
                                     email = stu.email,
                                     dob = stu.dob,
                                     Gender = stu.Gender,
                                     CourseId = c.Id,
                                     CourseName = c.Coursename
                                 }).ToList();
            return studentRecord;
        }


        public StudentViewModel GetParticularStudent(int id)
        {
            var studentRecord = (from stu in entities.Students
                                 join c in entities.Courses
                                 on stu.CourseId equals c.Id
                                 where stu.Id == id
                                 select new StudentViewModel
                                 {
                                     Id = stu.Id,
                                     StuName = stu.StuName,
                                     email = stu.email,
                                     dob = stu.dob,
                                     Gender = stu.Gender,
                                     CourseId = c.Id,
                                     CourseName = c.Coursename
                                 }).FirstOrDefault();
            return studentRecord;
        }


        public HttpResponseMessage Post(Student student)
        {
            entities.Students.Add(student);
            entities.SaveChanges();
            var msg = Request.CreateResponse(HttpStatusCode.Created, student);
            msg.Headers.Location = new Uri(Request.RequestUri, student.Id.ToString());
            return msg;
        }


        public HttpResponseMessage Put(int id, Student student)
        {
            try
            {
                var response = entities.Students.FirstOrDefault(x => x.Id == id);
                if (response == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student for this" + id + "does not finds");
                }
                else
                {
                    response.StuName = student.StuName;
                    response.Gender = student.Gender;
                    response.dob = student.dob;
                    response.email = student.email;
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK,"Updated Successfully");

                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }


        public HttpResponseMessage Delete(int id)
        {
            var response = entities.Students.FirstOrDefault(x => x.Id == id);
            if (response == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student for this id" + id + "does not found.");
            }
            else
            {
                entities.Students.Remove(response);
                entities.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Record deleted Successfully");
            }
        }
    }
}
