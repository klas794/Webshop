
using System.Collections.Generic;
using WebShop.Abstractions.Interfaces;
using WebShop.Classes;

namespace WebShop.Abstractions
{
    interface INews
    {
        List<Product> GetProducts();
        string NewsDescription(); //om vi vill ha en beskrivande text på nyhetssidan.
        //string Gender { get; set; } //för att visa nyheter för dam eller herr.
        //string ProductType { get; set; }//för att kunna sortera på produkttyp
        bool DisplayImageSlideshow(); //Så att man tex kan dölja bildspelet överst i tex en mobilversion av sidan.

    }
}
