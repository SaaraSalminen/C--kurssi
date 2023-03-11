class Clotes : Product //periytyvä luokka, vaatteet
{
    public string Brand { get; set; }

    public Clothes(string name, string type, double price, int quantity, string brand)
        : base(name, type, price, quantity)
    {
        Brand = brand;
    }

    public override void Display()
    {
        Console.WriteLine($"Product name: {Name}, type of product: {Type}, by {Brand} - ${Price} - Currenty {Quantity} pieces in stock");
    }
}