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
        public List<Product> Products { get; set; }

        public ProductsRepository()
        {
            Products = GetProducts();
        }

        public Product GetProduct(int artnr)
        {
            return Products.First(x => x.Artnr == artnr);
        }

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

                    string imageUrl = item.Elements("ImageUrl") != null ? 
                        item.Elements("ImageUrl").First().Value: "";

                    list.Add(new Product()
                    {
                        Artnr = int.Parse(artnr),
                        Title = title,
                        Price = double.Parse(price),
                        ImageUrl = imageUrl
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
            return Products.FindAll( x => artNrs.Equals(x.Artnr) );
        }

        public void SaveProducts()
        {
            SaveProducts(Products);
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
                            new XElement("Price", item.Price),
                            new XElement("ImageUrl", item.ImageUrl)
                            ));
            }

            document.Save(HttpContext.Current.Server.MapPath(@"~\products.xml"));
        }

        public void RemoveProduct(int artnr)
        {
            var products = Products;

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

        public void UpdateProduct(Product product)
        {
            var item = Products.Find(x => x.Artnr == product.Artnr);
            
            if(item != null)
            {
                item.Artnr = product.Artnr;
                item.Title = product.Title;
                item.Price = product.Price;

                if(product.ImageUrl != null)
                {
                    item.ImageUrl = product.ImageUrl;
                }
            }

            SaveProducts();
        }
    }



}
