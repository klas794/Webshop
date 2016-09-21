using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;

namespace WebShop.Classes
{
    public class News : INews
    {

        bool INews.DisplayImageSlideshow()
        {
            return true;
        }

        string INews.NewsDescription()
        {
            return "Här är de senast inkomna varorna.";
        }

        //om product har gender så kan man skapa listor utifrån dam eller herr.
        //om product även har datum för när det lagts till i shopen kan man sortera ut de 
        //nyaste produkterna och visa dom under nyheter.
        public List<Product> NewProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product() { Name = "Ralph Lauren", Price = 699, Type = "Skjorta" });
            products.Add(new Product() { Name = "Peak Performance", Price = 1299, Type = "Byxor" });
            products.Add(new Product() { Name = "Tommy Hilfiger", Price = 2399, Type = "Jacka" });

            return products;
        }
        
        
    }
}