using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }

        
        [Required(ErrorMessage ="Please leave your comment or question")]
        [MaxLength(5000)]
        [Display(Name ="Comment or question")]
        
        public string Note { get; set; }

        [Display(Name ="Email address")]
        [Required(ErrorMessage ="Please enter your email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Not a valid email")]
        public string Email { get; set; }
    }
}