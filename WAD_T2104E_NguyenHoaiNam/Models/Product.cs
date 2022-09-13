using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenHoaiNam.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "ID")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Name length must greater than 2 and less than 32")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Price must be numeric data")]
        [Range(1, 100, ErrorMessage = "Price must be a positive number")]
        public double Price { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}