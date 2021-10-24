using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CovidMVCApplicationProject.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "lastname is required")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
        [Required(ErrorMessage = "ConformPassword is required")]
        [Compare("password", ErrorMessage = "Password and conform password should matched")]
        public string conformPassword { get; set; }
    }
}