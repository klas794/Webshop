using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Classes;

namespace WebShop.Abstractions.Interfaces
{
    interface IShoppingCart
    {

        void AddItem(Product p);
        void RemoveItem(Product p);
        void ClearCart();
        double TotalAmount();
        double Discount();
        void Confirmation();
        int CountItems();
        List<Product> GetItems();

    }
}
