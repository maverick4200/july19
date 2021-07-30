using System;
using System.Collections.Generic;

public class Cart {

    List<StoreItem> storeItemsToPurchase;
    private decimal total;
    
    public Cart()
    {
        storeItemsToPurchase = new List<StoreItem>();
    }

    public void AddToCart(StoreItem itemToAdd) {
        storeItemsToPurchase.Add(itemToAdd);
    }

    public void PrintItems() {
        Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
        Console.WriteLine("--------------------------------------------------------");
        foreach (var i in storeItemsToPurchase)
        {
            Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
            total = total + i.Price;
        }
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Total: $" + total);
    }
}