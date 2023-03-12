using System;
class Product //pääluokka
{
    public string Name { get; set; } //tuotteen nimi
    public string Type { get; set; }  //mihin kategoriaan tuote kuuluu
    public double Price { get; set; } //tuotteen hinta
    public int Quantity { get; set; } //määrä varastossa

    public Product(string name, String type, double price, int quantity)
    {
        Name = name;
        Type = type;
        Price = price;
        Quantity = quantity;
    }

    public virtual void Display()
    {
        string v = $"Product name: {Name}, type of product: {Type}, price:  ${Price}, currently {Quantity} in stock";
        Console.WriteLine(v);
    }
}
