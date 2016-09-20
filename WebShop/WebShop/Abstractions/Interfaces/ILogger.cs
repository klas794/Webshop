using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions.Interfaces
{
    interface ILogger
    {

        void WriteLogMessage(string message);

        string[] ReadLogContent();

        void Clear();
    }
}
