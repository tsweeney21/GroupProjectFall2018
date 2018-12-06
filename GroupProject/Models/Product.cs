using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    [Table("Product")]
    public class Product
    {

        

        [Key]
        public int ProdID { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Product Name")]
        public string ProdName { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Product Description")]
        public string ProdDescription { get; set; }
        [Required]
        [Range(0, 99.99)]
        [Display(Name = "Product Price")]
        public decimal ProdPrice { get; set; }
        [Required]
        [MaxLength(255)]
        public string ProdPicture { get; set; }
        

    }
}