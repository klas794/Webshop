using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions.Interfaces
{
    interface INews
    {
        //List<Products> NewProducts(); //För att returnera en lista med produkter
        string NewsDescription(); //om vi vill ha en beskrivande text på nyhetssidan.
        //string Gender { get; set; } //för att visa nyheter för dam eller herr.
        //string ProductType { get; set; }//för att kunna sortera på produkttyp
        bool DisplayImageSlideshow(); //Så att man tex kan dölja bildspelet överst i tex en mobilversion av sidan.

    }
}
