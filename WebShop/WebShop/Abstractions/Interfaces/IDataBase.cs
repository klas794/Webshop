using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Classes;

namespace WebShop.Abstractions.Interfaces
{
    interface IDataBase
    {
        List<Product> GetStore();

        void UpdateStore(List<Product> products);

        List<Product> GetDummyProducts(int count);
    }
}
