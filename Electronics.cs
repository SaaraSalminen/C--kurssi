class Electronics : Product //periytyvä luokka, elektroniikka
{
    public string Manufacturer { get; set; }

    public Electronics(string name, double price, int quantity, string manufacturer)
        : base(name, type, price, quantity)
    {
        Manufacturer = manufacturer;
    }

    public override void Display()
    {
        Console.WriteLine($"Product name: {Name}, product type: {Type}, - Made by: {Manufacturer}, - ${Price} - Currentyly {Quantity} pieces in stock ");
    }
}