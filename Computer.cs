public class Computer : StoreItem {
    //That's inheritance right there ^^^
    string computerBrand;
    string releaseDate;
    string color;

//encapsulation 
    public string ReleaseDate { get => releaseDate; set => releaseDate = value; }  
    public string ComputerBrand { get => computerBrand; set => computerBrand = value; }
    public string Color { get => color; set => color = value; }


    //constructor
    public Computer(string model, string color, decimal price, string computerBrand, string description, string releaseDate, int num){
        this.Name = model;
        this.Price = price;
        ComputerBrand = computerBrand;
        this.Description = description;
        ReleaseDate = releaseDate;
        this.ItemNum = num;
        this.Color = color;
    } 

    public string getData()
    {
        return "Product: " + Name  + ", Color: " + color + ", Price: " + Price + ", Computer Brand: "+ ComputerBrand + ", Description: " + Description +  ", Release Date: " + ReleaseDate +  ", Item Number: " + ItemNum;

    }
//method
//selling
//increasing or decreasing price



}