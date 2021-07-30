public class Book : StoreItem {
    string cover; 
    string author;
    
    public string Cover { get => cover; set => cover = value; }
    public string Author { get => author; set => author = value; }


    //constructor
    public Book(
        string title, 
        decimal price, 
        string author, 
        string cover, 
        int num
    ) : base (
        price,
        title,
        author + " " + cover,
        num
    ) {
        this.Author = author;      
        this.Cover = cover;
    }
 
    public string storeDisplay(){
            return this.Name = " by " +  author + " in" + cover; 
    }
    public string getData() 
    {
        return this.Name + author + cover + Price + ItemNum;
    }
}


    
