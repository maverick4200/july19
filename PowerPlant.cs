public class PowerPlant : StoreItem {

    //constructor

    public PowerPlant(
        string amountInKWh, 
        decimal price, 
        int itemNum, 
        string description
    )
    : base (
        price,
        amountInKWh,
        description,
        itemNum
    )
    {
        this.Name = amountInKWh;
        this.Price = price;
        this.ItemNum = itemNum;
    }


    public override string GetData(){
        return "Product: " + Name + ", Price: " + Price + ", Item Number: " + ItemNum;
    }   


}   

