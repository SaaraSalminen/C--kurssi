using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cart
{
    public List<Product> items;

    public Cart()
    {
        items = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        items.Add(product);
    }

    public void RemoveFromCart(int index)
    {
        items.Remove(items[index]);
    }

    public void DisplayCart()
    {
        Console.WriteLine("-----Cart-----");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine("[" + i + "] " + items[i].Name);
        }
        Console.WriteLine("--------------");
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product item in items)
        {
            total += item.Price;
        }
        return total;
    }
}