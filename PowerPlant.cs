public class PowerPlant : StoreItem {


    //constructor
    public PowerPlant(string amountInKWh, decimal price, int itemNum){
        this.Name = amountInKWh;
        this.Price = price;
        this.ItemNum = itemNum;
    }

    public string getData(){
        return Name + Price + ItemNum;
    }   

}