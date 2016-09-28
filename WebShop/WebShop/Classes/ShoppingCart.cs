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
            if(_products.Count == 0)
            {
                return 0;
            }
            
            //billigaste produkten         

            Product lowestPrice = _products.OrderByDescending(x => x.Price).ToList().Last();
            //lowestPrice.Price = 0;

            return lowestPrice.Price;
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


