using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop
{
    public class Product
    {
        //Egenskaper som vår klass/product har

        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        //public Product(int id, int Price,)
        //{
        //    this.Id = id;
        //} 

        public string GetId()
        {
            return "id= " + Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }  
}