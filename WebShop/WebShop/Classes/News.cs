using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.Abstractions;
using WebShop.Abstractions.Interfaces;
using WebShop.Enums;

namespace WebShop.Classes
{
    public class News : INews
    {

        public List<Product> GetProducts()
        {
            var repos = new ProductsRepository();
            return repos.Products;
        }

        bool INews.DisplayImageSlideshow()
        {
            return true;
        }

        string INews.NewsDescription()
        {
            return "Här är de senast inkomna varorna.";
        }


    }
}