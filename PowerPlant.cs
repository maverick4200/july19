public class PowerPlant : StoreItem {

    //amount of workers


    //double cost; //cost per kWh

    //encapsulation
    /*public int NumOfWorkers { get => numOfWorkers; set => numOfWorkers = value; }
    public bool Open { get => open; set => open = value; }
    public double Energy { get => energy; set => energy = value; }
    public double Cost { get => cost; set => cost = value; }
    */

    
//encapsulation


    //constructor2
    public PowerPlant(string amountInKWh, decimal price, int itemNum){
        this.Name = amountInKWh;
        this.Price = price;
        this.ItemNum = itemNum;
    }

    public string getData(){
        return Name + Price + ItemNum;
    }   

}

