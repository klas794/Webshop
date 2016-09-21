using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;
using System.IO;
using System.Diagnostics;
using WebShop.Classes;

namespace WebShop.Classes
{
    public class DataBase : FileHandler, IDataBase
    {
        public DataBase()
        {
            discFileName = "webshop-db.txt";
        }

        public List<Product> GetDummyProducts(int count = 10)
        {
            List<Product> products = new List<Product>();

            for (int i = 1; i <= count; i++)
            {
                products.Add(new Product() { Artnr = count, Title = "Vara " + i });
            }

            return products;
        }

        public List<Product> GetStore()
        {
            List<Product> products = new List<Product>();
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader sw = new StreamReader(discPath + discFileName))
                {
                    var line = sw.ReadLine();

                    var props = line.Split(',');

                    products.Add(new Product() { Artnr = int.Parse(props[0]), Title = props[0] });
                }
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
                throw;
                
            }

            return null;
        }

        public void UpdateStore(List<Product> products)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(discPath + discFileName, true))
                {
                    foreach (var item in products)
                    {
                        var props = new List<string>();
                        props.Add(item.Artnr.ToString());
                        props.Add(item.Title);

                        var line = string.Join(",", props);

                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
           }
        }
    }
}