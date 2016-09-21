using System.Collections.Generic;
using WebShop.Abstractions;

namespace WebShop.Classes
{
    public class News :INews
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

            products.Add(new Product() { Title = "Ralph Lauren", Artnr = 699 });
            products.Add(new Product() { Title = "Peak Performance", Artnr = 1299});
            products.Add(new Product() { Title = "Tommy Hilfiger", Artnr = 2399 });

            return products;
        }



    }
}