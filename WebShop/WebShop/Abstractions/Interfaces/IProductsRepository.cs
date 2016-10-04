using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Classes;

namespace WebShop.Abstractions.Interfaces
{
    public interface IProductsRepository
    {
        Product GetProduct(int artnr);
        List<Product> GetProducts();
        List<Product> SelectProducts(List<int> artNrs);
        void SaveProducts();
        void SaveProducts(List<Product> products);
        void RemoveProduct(int artnr);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
        List<Product> Search(string searchString);
    }
}