using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;

namespace WebShop.Classes
{
    public class ShoppingCart : IShoppingCart
    {
        private List<int> _products = new List<int>();

        public void AddItem(int artNr)
        {
            _products.Add(artNr);
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

        public void Offer()
        {
            throw new NotImplementedException();
        }

        public void Payment()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem()
        {
            throw new NotImplementedException();
        }
    }
}