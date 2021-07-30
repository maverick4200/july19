using System.Collections.Generic;

public class StoreItem {
    private decimal price;
    private string name;
    private string description;
    private List<string> keywords;
    private int itemNum;

    public decimal Price { get => price; set => price = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int ItemNum { get => itemNum; set => itemNum = value; }
    public List<string> Keywords { get => keywords; set => keywords = value; }

    public StoreItem(
        decimal price, 
        string name, 
        string description, 
        int itemNum
    )
    {
        this.price = price;
        this.name = name; 
        this.description = description;
        this.itemNum = itemNum;
        this.Keywords = new List<string>();
    }

    public decimal Calc() {
        this.Price = this.Price * 0.70M; 
        return this.Price;
    }

}
