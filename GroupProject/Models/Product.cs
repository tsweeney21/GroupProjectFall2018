using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Product
    {
        public int prodID { get; set; }
        public string prodName { get; set; }
        public string prodDescription { get; set; }
        public decimal prodPrice { get; set; }
        public string prodPicture { get; set; }

        public Product()
        {

        }

        public Product(int prodID, string prodName, string prodDescription, decimal prodPrice, string prodPicture)
        {
            this.prodID = prodID;
            this.prodName = prodName;
            this.prodDescription = prodDescription;
            this.prodPrice = prodPrice;
            this.prodPicture = prodPicture;
                
        }
    }
}