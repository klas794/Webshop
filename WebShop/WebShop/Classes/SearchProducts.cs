using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Classes
{
    public class SearchProducts
    {
        public ActionResult Index(string searchString)
        {
            News test = new News();
            var products = from m in test.NewProducts()
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Title.Contains(searchString));
            }

            return View(products);

        }

        private ActionResult View(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}