using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Enums;

namespace WebShop.Classes
{
    public class Product
    {
        public int Artnr { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Gender { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
    }
}