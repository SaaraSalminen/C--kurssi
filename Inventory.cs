class Inventory //määritellään luokille attribuutteja
{
    static void Main(string[] args)
    {
        Product[] products = new Product[3]; //pythonissa ei käytetä Array:ta vaan sen sijaan listoja, joille ei tarvitse määritellä kokoa niinkuin tässä

        products[0] = new Electronics("Nocia 3310", "phone", 499.99, 5, "Nocia");
        products[1] = new Food("Xiqitita", "banana", 1.99, 67, 20.12);
        products[2] = new Clothes("Levo's 701", "jeans", 90.99, 40, "Levo's");

        Cart cart = new Cart();

        Console.WriteLine("Current inventory:\n"); //Pythonissa ei käytetä Console.WriteLine tai -Read.Line vaan input ja print
        Console.WriteLine("---------------");
        for (int i = 0; i < products.Length; i++)
        {
            Console.Write("[" + i + "] ");
            products[i].Display();
        }
        Console.WriteLine("---------------");
        Console.WriteLine();

        bool continueShopping = true;
        while (continueShopping == true)
        {
            Console.WriteLine("Type 1 to add to cart\nType 2 to remove from cart\nType 3 to display cart\nType 4 to stop shopping");
            int selection = Convert.ToInt32(Console.ReadLine());
            int numberSelection;
            switch (selection)
            {
                case 1:
                    Console.Write("Type product number: ");
                    numberSelection = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        cart.AddToCart(products[numberSelection]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("A product with that number doesn't exist");
                    }
                    cart.DisplayCart();
                    break;
                case 2:
                    Console.Write("Type number of a cart item: ");
                    numberSelection = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        cart.RemoveFromCart(numberSelection);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("A product with that number doesn't exist");
                    }
                    cart.DisplayCart();
                    break;
                case 3:
                    cart.DisplayCart();
                    break;
                case 4:
                    continueShopping = false;
                    break;
            }
        }
    }
}