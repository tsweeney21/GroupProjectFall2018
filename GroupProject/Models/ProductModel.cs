using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {

        }

        public List<Product> findAll()
        {
            //TODO call db for products


            return this.products;
        }


    }
}