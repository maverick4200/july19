public class StoreItem {
    private decimal price;
    private string name;
    private string description;

    private int itemNum;

    public decimal Price { get => price; set => price = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int ItemNum { get => itemNum; set => itemNum = value; }

    //constructor

    public decimal Calc() {
        this.Price = this.Price * 0.70M; 
        return this.Price;
    }

}
