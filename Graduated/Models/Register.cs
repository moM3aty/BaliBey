using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Graduated.Models
{
    public class Register
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="First Name :")]
        [Required(ErrorMessage ="First Name is Required !!!")]
        [StringLength(15, ErrorMessage = "First Name must be below 15 Character")]
        [DataType(DataType.Text)]
        public string Fname { get; set; }

        [Display(Name = "Last Name :")]
        [Required(ErrorMessage = "Last Name iS REQUIRED !!!")]
        [StringLength(15, ErrorMessage = "Last Name must be below 15 Character")]
        [DataType(DataType.Text)]
        public string Lname { get; set; }

        [Display(Name = "Email :")]
        [Required(ErrorMessage = "Email IS REQUIRED !!!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email IS not Valid !!!")]
        [System.Web.Mvc.Remote("EmailExist", "Index", ErrorMessage = "Email Is Already Exist !!!")]
        public string Email { get; set; }

        [Display(Name = "Password :")]
        [Required(ErrorMessage = "Password Is REQUIRED !!!")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be more 8")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "password must be letters and Number")]
        public string pwd { get; set; }

        [Display(Name = "Confirm Password :")]
        [Required(ErrorMessage = "Confirm Password Is REQUIRED !!!")]
        [DataType(DataType.Password)]
        [Compare("pwd", ErrorMessage = "Password Don't Matches !!!")]
        public string Cpwd { get; set; }

        [Display(Name = "Date Of Birth :")]
        [Required(ErrorMessage = "DATE OF BIRTH IS REQUIRED !!!")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }

        [Display(Name ="Gender :")]
        [Required(ErrorMessage = "Gender is REQUIRED !!!")]
        public string Gender { get; set; }

    }
}