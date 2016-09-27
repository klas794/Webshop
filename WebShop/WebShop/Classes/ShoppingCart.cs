using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;

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
            throw new NotImplementedException();
        }

        public int CountItems()
        {
            return _products.Count;
        }


        public double totalAmount()
        {

            double totalAmount = _products.Sum(x => x.Price) - Discount();
            return totalAmount;

        }


        public double Discount()
        {
            // returnerar priset för den billigaste produkten 
            //ifall antal produkter >2, annars returnerar noll        

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
    }
}


