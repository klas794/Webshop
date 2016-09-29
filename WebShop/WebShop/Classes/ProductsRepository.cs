using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebShop.Abstractions.Interfaces;
using System.IO;
using System.Linq.Expressions;
using System.Xml;


namespace WebShop.Classes
{
    public class ProductsRepository : IProductsRepository
    {

        public List<Product> GetProducts()
        {
            try
            {
                var doc = XDocument.Load(HttpContext.Current.Server.MapPath(@"~\products.xml"));

                var products = doc.Elements("Products").Elements("Product");

                var list = new List<Product>();

                foreach (var item in products)
                {
                    string artnr = item
                        .Elements("Artnr").First().Value;

                    string title = item
                        .Elements("Title").First().Value;

                    string price = item
                        .Elements("Price").First().Value;

                    list.Add(new Product()
                    {
                        Artnr = int.Parse(artnr),
                        Title = title,
                        Price = double.Parse(price)
                    });

                }


                return list;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
            
        }

        public List<Product> SelectProducts(List<int> artNrs)
        {
            return GetProducts().FindAll( x => artNrs.Equals(x.Artnr) );
        }

        public void SaveProducts(List<Product> products)
        {
            var document = new XDocument();

            document.Add(new XElement("Products"));

            foreach (var item in products)
            {
                document.Element("Products")
                    .Add(new XElement("Product",
                            new XElement("Artnr", item.Artnr),
                            new XElement("Title", item.Title),
                            new XElement("Price", item.Price)));
            }

            document.Save(HttpContext.Current.Server.MapPath(@"~\products.xml"));
        }

        public void RemoveProduct(int artnr)
        {
            var products = GetProducts();

            foreach (var item in products)
            {
                if(item.Artnr == artnr)
                {
                    products.Remove(item);
                    break;
                }
            }

            SaveProducts(products);
        }
    }



}
