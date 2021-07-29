public class Book : StoreItem {
    /*
    book title, cover, author, price
    */
        string cover; 
        string author;
    //encapsulation
      public string Cover { get => cover; set => cover = value; }
        public string Author { get => author; set => author = value; }


    //constructor
    public Book (string title, decimal price, string author, string cover, int num) {
        this.Name = title; 
        this.Price = price;
        this.Author = author;      
        this.Cover = cover;
        this.ItemNum = num;
    }
 
 public string storeDisplay(){
            return this.Name = " by " +  author + " in" + cover; 
    }
    public string getData() 
    {
        return this.Name + author + cover + Price + ItemNum;

    }
}

