using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Item
    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }
}