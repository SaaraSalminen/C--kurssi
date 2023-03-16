using System;
class Product //pääluokka
{
    public string Name { get; set; } //pythonissa ei käytetä näitä public-alkuisia määritteitä ja tätä osiota ei tarvittais ollenkaan
    public string Type { get; set; }  
    public double Price { get; set; } 
    public int Quantity { get; set; }
    public int numberInCart { get; set; }

    public Product(string name, String type, double price, int quantity) //Pythonissa metodi määriteltäisiin def_init
    {
        Name = name;
        Type = type;
        Price = price;
        Quantity = quantity;
    }

    // virtual-avainsanaa käytetään määrittelemään miten perittyjä metodeja käytetään. Tätä ei tarvita Pythonissa
    public virtual void Display()
    {
        string v = $"Product name: {Name}, type of product: {Type}, price:  ${Price}, currently {Quantity} in stock";
        Console.WriteLine(v);
    }
}
