using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;

namespace WebShop.Classes
{
    public class Admin : IAdmin
    {
       


        public void AddProduct()
        {
         
        }

        public void UpdateProduct()
        {
          
        }

        public void RemoveProduct()
        {
         
        }





        public void CheckBalanceOfAccount()
        {
            
        }

        public void Profit(double profit)
        {
            
        }

        public void PurchasePrice(double price)
        {

        }

        public bool LogIn(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }
    }
}