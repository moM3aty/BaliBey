using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Graduated.Models
{
    public class menu_item
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required !!!")]
        [Display(Name = "Name :")]
        [StringLength(50, ErrorMessage = "Frist Name must be below 15 Character")]
        [DataType(DataType.Text)]
        public string name { get; set; }

        [Display(Name = "Price :")]
        [Required(ErrorMessage = "Price is Required")]
        public float price { get; set; }
        
        [Display(Name = "Description :")]
        public string Description { get; set; }

        [NotMapped]
        public HttpPostedFileBase Myfile { get; set; }

        public string Path { get; set; }

        [ForeignKey("Category")]
        public int CatID { get; set; }

        [Display(Name ="Category :")]
        public virtual Category Category { get; set; }

    }
}