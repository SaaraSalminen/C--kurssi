using System.Diagnostics;
using System.Xml.Linq;

class Food : Product //periytyvä luokka, ruuat
{
    public double ExpirationDate { get; set; }

    public Food(string name, string type, double price, int quantity, double expirationdate)
        : base(name, type, price, quantity)
    {
        ExpirationDate = expirationdate;
    }

    public override void Display()
    {
        Console.WriteLine($"Product name: {Name}, Type of product: {Type} - ${Price} - expires in {ExpirationDate} - Total amount of {Quantity} pieces in stock");
    }
}