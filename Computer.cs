public class Computer : StoreItem {
 
    string computerBrand;
    string releaseDate;

//encapsulation 
    public string ReleaseDate { get => releaseDate; set => releaseDate = value; }  
    public string ComputerBrand { get => computerBrand; set => computerBrand = value; }


    //constructor
    public Computer(string model, decimal price, string computerBrand, string description, string releaseDate, int num){
    this.Name = model;
    this.Price = price;
    ComputerBrand = computerBrand;
    this.Description = description;
    ReleaseDate = releaseDate;
    this.ItemNum = num;
    } 
//method
//selling
//increasing or decreasing price

//method is still needed.


}





 
 
 
 
 


      

     
    





