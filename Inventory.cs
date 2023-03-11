class Inventory //määritellään luokille attribuutteja
{
    static void Main(string[] args)
    {
        Product[] products = new Product[2];
        
        products[0] = new Electronics("Nocia 3310", "phone", "Nocia", 499.99, 5);
        products[1] = new Food("Xiqitita", "banana", 1.99, 20.12, 67);
        products[1] = new Clotes("Levo's 701", "jeans", "Levo's", 90.99, 40);

        Console.WriteLine("Current inventory:\n");

        foreach (Product product in products)
        {
            product.Display();
        }
    }
}