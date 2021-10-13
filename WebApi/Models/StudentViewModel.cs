using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string StuName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string email { get; set; }

        public string CourseName { get; set; }
    }
}