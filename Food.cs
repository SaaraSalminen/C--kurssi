class Food : Product //periytyvä luokka, ruuat
{
    public string ExpirationDate { get; set; }

    public Food(string name,string type, double price, int quantity, double expirationdate)
        : base(name, type, price, quantity)
    {
        ExpirationDate = expirationdate;
    }

    public override void Display()
    {
        Console.WriteLine($"Product name: {Name}, Type of product: {Type} - ${Price} - expires in {ExpirationDate} - Total amount of {Quantity} in stock");
    }
}