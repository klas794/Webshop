using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Classes;

namespace WebShop.Abstractions.Interfaces
{
    interface IOrdersRepository
    {
        List<Order> GetOrders();

        void AddOrder(double value);

        double GetOrdersValue();
    }
}
