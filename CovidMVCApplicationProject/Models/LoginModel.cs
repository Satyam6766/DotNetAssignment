using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CovidMVCApplicationProject.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required.")] 
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not valid")]
       
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required."),DataType("password")]
        public string password { get; set; }
       
       
    }
}