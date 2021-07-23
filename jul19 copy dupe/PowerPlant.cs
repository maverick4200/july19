public class PowerPlant : StoreItem {

    //amount of workers

    double amountInKWh;
     string unitOfmeasurement; //kWh
    //double cost; //cost per kWh

    //encapsulation
    /*public int NumOfWorkers { get => numOfWorkers; set => numOfWorkers = value; }
    public bool Open { get => open; set => open = value; }
    public double Energy { get => energy; set => energy = value; }
    public double Cost { get => cost; set => cost = value; }
    */

    
//encapsulation
    
    public string UnitOfmeasurement { get => unitOfmeasurement; set => unitOfmeasurement = value; }
    public double AmountInKWh { get => amountInKWh; set => amountInKWh = value; }


    //constructor2
    public PowerPlant(double amountInKWh, string unitOfmeasurement, decimal price, int itemNum){
        this.AmountInKWh = amountInKWh;
        this.UnitOfmeasurement = unitOfmeasurement;
        this.Price = price;
        this.ItemNum = itemNum;
    }
    

}

