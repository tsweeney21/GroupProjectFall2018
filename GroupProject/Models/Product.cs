using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    [Table("Products")]
    public class Product
    {

        

        [Key]
        public int prodID { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Product Name")]
        public string prodName { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Product Description")]
        public string prodDescription { get; set; }
        [Required]
        [Range(0, 99.99)]
        [Display(Name = "Product Price")]
        public decimal prodPrice { get; set; }
        [Required]
        [MaxLength(255)]
        public string prodPicture { get; set; }

    }
}