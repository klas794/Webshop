using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions.Interfaces
{
    interface IBaseUser
    {
        bool LogIn(string userName, string password);

        //bool LogOut();

        //bool CreateUser(Classes.User user);
        //bool UppdateUser(Classes.User user);
        //bool RemoveUser(Classes.User user);
    }
}
