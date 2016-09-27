using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.Abstractions;
using WebShop.Enums;

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

            products.Add(new Product() { Title = "Ralph Lauren", Price = 699,
                ArrivalDate = new DateTime(2014, 06, 21),
                Gender = Gender.GetGenderName((int)GenderEnum.Herr)});
            products.Add(new Product() { Title = "Peak Performance", Price = 1299,
                ArrivalDate = new DateTime(2014, 12, 09),
                Gender = Gender.GetGenderName((int)GenderEnum.Dam)});
            products.Add(new Product() { Title = "Tommy Hilfiger", Price = 2399,
                ArrivalDate = new DateTime(2016, 01, 06),
                Gender = Gender.GetGenderName((int)GenderEnum.Dam) });

            return products.OrderByDescending(x => x.ArrivalDate).ToList();
        }



    }
}