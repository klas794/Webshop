using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions
{
    interface IShoppingCart
    {
        void AddItem(int artNr);
        void RemoveItem();
        void ClearCart();
        void Payment();
        void Offer();
        void Confirmation();





    }
}
