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
using WebShop.Abstractions;


namespace WebShop.Classes
{
    public class OrdersRepository: IOrdersRepository
    {
        private string _ordersFileName;

        public OrdersRepository()
        {
            _ordersFileName = HttpContext.Current.Server.MapPath(@"~\orders.xml");
        }

        public List<Order> GetOrders()
        {
            try
            {
                var doc = XDocument.Load(_ordersFileName);

                var products = doc.Elements("Orders").Elements("Order");

                var list = new List<Order>();
                
                foreach (var item in products)
                {
                    string timeStamp = item
                        .Elements("TimeStamp").First().Value;

                    string value = item
                        .Elements("Value").First().Value;

                    list.Add(new Order()
                    {
                        TimeStamp = DateTime.Parse(timeStamp),
                        Value = double.Parse(value)
                    });

                }


                return list;
            }
            catch (Exception)
            {
                return new List<Order>();
            }

        }

        public void AddOrder(double value)
        {
            var orders = GetOrders();


            Order newOrder = new Order()
            {
                TimeStamp = DateTime.Now,
                Value = value
            };

            orders.Add(newOrder);


            var document = new XDocument();

            document.Add(new XElement("Orders"));

            foreach (var item in orders)
            {
                document.Element("Orders")
                    .Add(new XElement("Order",
                            new XElement("TimeStamp", item.TimeStamp),
                            new XElement("Value", item.Value)));
            }
            
            document.Save(_ordersFileName);
        }

        public double GetOrdersValue()
        {
            return GetOrders().Sum(x => x.Value);
        }
    }

}
