 public class Basketball: StoreItem {
    private string date;
    private int section;
    private int seat;
//this is the list for the basketball
    public string Date { get => date; set => date = value; }
    public int Section { get => section; set => section = value; }
    public int Seat { get => seat; set => seat = value; }


    public Basketball(string teams, decimal price, string date, int section, int seat, int num){
        this.Name = teams;
        this.Price = price;
        this.Date = date;
        this.Section = section;
        this.Seat = seat;
        this.ItemNum = num;
    }

}
