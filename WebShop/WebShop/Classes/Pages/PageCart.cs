using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Classes
{
    public class PageCart: BasePage
    {
        private ShoppingCart cart { get; set; }

        public PageCart(ShoppingCart shoppingCart)
        {
            cart = shoppingCart;
        }

        public bool PlaceOrder(double profit)
        {
            var ordersRepo = new OrdersRepository();

            try
            {
                ordersRepo.AddOrder(profit);
            }
            catch (Exception)
            {
                return false;
            }

            cart.Confirmation();
            return true;
        }

        public void LogOrder()
        {
            var log = new Logger();
            log.WriteLogMessage("User placed an order for " + cart.TotalAmount() + 
                " kr, resulting in " + cart.Profit() + " kr profit.");
            log.WriteLogMessage("User was sent a confirmation email.");
        }
    }
}