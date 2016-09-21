
namespace WebShop.Abstractions
{
    interface INews
    {
        //List<Product> Products { get; set; } //För att returnera en lista med produkter
        string NewsDescription { get; set; } //om vi vill ha en beskrivande text på nyhetssidan.
        string Gender { get; set; }
        string ProductType { get; set; }
        bool DisplayImageSlideshow { get; set; } //Så att man tex kan dölja bildspelet överst i tex en mobilversion av sidan.

    }
}
