using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ValidationsDemo.Models
{
    public class Register
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter User Id")]
        [Range(minimum:1,maximum:100,ErrorMessage ="Please Enter UserId between 1 to 100")]
        [RegularExpression(pattern: @"^[1-9]\d*$",ErrorMessage ="Please Enter Digit")]
        public int UserId { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter User Name")]
        [DataType(DataType.Text,ErrorMessage ="Name must be in Alphabets")]
        [StringLength(maximumLength:50, MinimumLength =10)]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        //[RegularExpression(pattern: "/^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/" ,ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
    }
}