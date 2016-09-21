using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions.Interfaces
{
    interface IAdmin
    {
        bool LogIn(string userName, string password);
        bool LogOut();

        void AddProduct();
        void UpdateProduct();
        void RemoveProduct();

        void CheckBalanceOfAccount();
        void Profit(double profit);
        void PurchasePrice(double price);
    }
}
