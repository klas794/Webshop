using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;
using System.Text;

namespace WebShop.Classes
{
    public class ShoppingCart : IShoppingCart
    {

        //hämtar shoppinglistan
        private List<Product> _products = new List<Product>();

        public void AddItem(Product p)
        {
            _products.Add(p);
        }

        public void ClearCart()
        {
            _products.Clear();
        }

        public void Confirmation()
        {
            var emailSender = new EmailSender();
            var message = new StringBuilder();

            message.AppendLine("Your order has been processed. Your order details:");

            foreach (var item in GetItems())
            {
                message.AppendLine(item.Title + ": " + item.Price + " kr");
            }

            message.AppendLine("Totals: " + TotalAmount() + " kr");

            emailSender.DeliverEmail("Order", message.ToString());

        }

        public int CountItems()
        {
            return _products.Count;
        }


        public double TotalAmount()
        {
            double totalAmount = _products.Sum(x => x.Price) - Discount();
            return totalAmount;

        }

        public double Profit()
        {
            return _products.Sum(x => x.Price - x.BuyPrice) - Discount();
        }


        public double Discount()
        {
            if (_products.Count == 0)
            {
                return 0;
            }
            //billigaste produkten         

            if (CountItems() > 2)
            {
                Product lowestPrice = _products.OrderByDescending(x => x.Price).ToList().Last();
                return lowestPrice.Price;
            }

            else
            {
                return 0;
            }

        }


        //tar bort en produkt i taget
        public void RemoveItem(Product p)
        {

            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Artnr == p.Artnr)
                {
                    _products.RemoveAt(i);
                    break;
                }

            }
            
        }

        public List<Product> GetItems()
        {
            PopulateProductsData();

            return _products;

        }

        private void PopulateProductsData()
        {
            var repo = new ProductsRepository();
            var allProducts = repo.GetProducts();

            for (int i = 0; i < _products.Count; i++)
            {
                var product = allProducts.Find(x => _products[i].Artnr == x.Artnr);

                _products[i] = product;
            }

        }
    }
}


