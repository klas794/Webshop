using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions
{
    interface IBaseProduct
    {
        void ReadItem();
        void SaveItem();
        void UpdateItem();
        void DeleteItem();
        void New();

    }
}
