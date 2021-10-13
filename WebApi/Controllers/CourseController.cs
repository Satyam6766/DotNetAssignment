using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CourseController : ApiController
    {
        WebApi12SepEntities entities = new WebApi12SepEntities();

        public IEnumerable<CourseViewModel> Get()
        {
            var response = (from c in entities.Courses
                            select new CourseViewModel
                            {
                                Id = c.Id,
                                Coursename = c.Coursename
                            }).ToList();
            return response;
        }


        public CourseViewModel Get(int id)
        {
            var response = (from c in entities.Courses
                            where c.Id == id
                            select new CourseViewModel
                            {
                                Id = c.Id,
                                Coursename = c.Coursename
                            }).FirstOrDefault();
            return response;
        }


        public HttpResponseMessage Post(Course course)
        {
            entities.Courses.Add(course);
            entities.SaveChanges();
            var msg = Request.CreateResponse(HttpStatusCode.Created, course);
            msg.Headers.Location = new Uri(Request.RequestUri, course.Id.ToString());
            return msg;
        }


        public HttpResponseMessage Put(int id, Course course)
        {
            try
            {
                var response = entities.Courses.FirstOrDefault(x => x.Id == id);
                if (response == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course for this id " + id + " not found.");
                }
                else
                {
                    response.Coursename = course.Coursename;
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Course ID"+id+"updated Successfully");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        public HttpResponseMessage Delete(int id)
        {
            var response = entities.Courses.FirstOrDefault(x => x.Id == id);
            if (response == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course for this id " + id + " does not found");
            }
            else
            {
                try
                {
                    entities.Courses.Remove(response);
                    entities.SaveChanges();
                    var msg = Request.CreateResponse(HttpStatusCode.OK, id);
                    msg.Headers.Location = new Uri(Request.RequestUri, "Deleted ");
                    return msg;
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }

            }
        }
    }
}