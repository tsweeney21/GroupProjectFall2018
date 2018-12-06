using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GroupProject.Models
{

        [Table("NewProducts")]
        public class NewProduct
        {



            [Key]
            public int newID { get; set; }

            public string newProdName { get; set; }

            public string newProdDescription { get; set; }
  
            public decimal newProdPrice { get; set; }

            public string newProdPicture { get; set; }
        }
    }
