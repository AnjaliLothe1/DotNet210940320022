using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModuleExam.Models
{
    public class Products
    {
       
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Please Enter Name...")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [StringLength(50, ErrorMessage = "The {0} value can`t be greater than {1} characters")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please Enter Rate...")]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter Description Here...")]
        [StringLength(200, ErrorMessage = "The {0} value can`t be greater than {1} characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Enter Category ....")]
        public string CategoryName { get; set; }
    }
}