using System.Diagnostics;
using System.Xml.Linq;

// Toisin kuin C#:ssa, Pythonissa on mahdollista käyttää moniperintää, jonka avulla luokka voi periytyä useasta yliluokasta
class Electronics : Product //periytyvä luokka, elektroniikka
{                           
    public string Manufacturer { get; set; }

    public Electronics(string name, string type, double price, int quantity, string manufacturer) 
        : base(name, type, price, quantity)
    {
        Manufacturer = manufacturer;
    }

    // override-avainsanaa käytetään määrittelemään miten perittyjä metodeja käytetään. Tätä ei tarvita Pythonissa
    public override void Display()
    {
        Console.WriteLine($"Product name: {Name}, product type: {Type}, - Made by: {Manufacturer}," +
            $" - ${Price} - Total amount of {Quantity} pieces in stock ");
    }
}