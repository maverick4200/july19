using System.Collections.Generic;

public class Cart {

    List<StoreItem> storeItemsToPurchase;
    
    public Cart()
    {
        storeItemsToPurchase = new List<StoreItem>();
    }

    public void AddToCart(StoreItem itemToAdd) {
        storeItemsToPurchase.Add(itemToAdd);
    }
}