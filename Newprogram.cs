using System;
using System.Collections.Generic;
namespace jul19 
{
    class NewProgram
    {
        static void Main(string[] args)
        {
            decimal total = 0;
            List<Cart> shopCart = new List<Cart>();
            List<Basketball> basketList = new List<Basketball>();
            List<Computer> compList = new List<Computer>();
            List<Book> bookList = new List<Book>();
            List<PowerPlant> energyList = new List<PowerPlant>();
            //laptops             
            compList.Add(new Computer("MacBook Air","rose gold",900, "Apple", "New with M1 chip", "2021", 1)); 
            compList.Add(new Computer("Surface Pro",  "red", 700, "Windows", "laptop and tablet in one","2021", 2)); 
            compList.Add(new Computer("Microsoft", "black",600, "Windows", "Touch screen ", "2020", 3)); 
            compList.Add(new Computer("Razer Blade 15", "blue", 700, "Windows","Advanced laptop w/ RTX 2070", "2021", 4)); 
            compList.Add(new Computer("HP Envy"," pink", 529 , "Window", "11th Generation Intel", "2019", 5)); 
            compList.Add(new Computer("Asus ROG Zephyrus","silver", 500, "Windows", "5700xt + Ryzen 5600x", "2021", 6));          
            compList[5].Keywords = new List<string>() {"silver", "Windows", "AMD", "black", "red", "rose gold", "blue", "pink", "Apple" }; //no limit
            //basketball game tickets
            basketList.Add(new Basketball("Chicago Bulls vs Phoenix Suns", 250, "July 30", 109, 30, 7));
            basketList.Add(new Basketball("Phoenix Suns vs Bucks", 150, "August 2", 80, 20, 8));
            basketList.Add(new Basketball("LA Lakers vs Boston Celtics", 250, "September 24", 48, 15, 9));
            basketList.Add(new Basketball("Brooklyn Nets vs Denver Nuggets",100,"October 11",50, 24, 10)); 
            basketList.Add(new Basketball("New York Knicks vs Philadelphia 76ers", 183, "July 3",140, 49, 11)); 
            basketList.Add(new Basketball("Indiana Pacers vs Milwaukee Bucks" , 194, "June 3" , 103, 53, 12));
            basketList.Add(new Basketball("Denver Nuggets vs Utah Jazz", 139, "April 6" ,194, 49, 13));
            basketList.Add(new Basketball("Oklahoma City Thunder vs LA Clippers", 192, "January 3" ,102, 43, 14));
            basketList.Add(new Basketball("San Antoinio Spurs vs Memphis Grizzles", 193, "January 5", 195, 34 ,15)); 
            //books
            bookList.Add(new Book("Hunger Games", 15, "Suzanne Collins", "hardcover",16)); 
            bookList.Add(new Book("The Book Thief", 11, "Markus Zusak", "paperback",17)); 
            bookList.Add(new Book("To Kill a Mockingbird", 14, "Harper Lee", "paperback",18)); 
            bookList.Add(new Book("The Great Gatsby", 9, "F Scott Fitzgerald", "hardcover",19)); 
            bookList.Add(new Book("Things Fall Apart", 14, "Chinua Achebe", "paperback",20)); 
            bookList.Add(new Book("The Color Purple", 12, "Alice Walker", "paperback",21)); 
            bookList.Add(new Book("Lord of the Flies ", 11, "William Colding", "paperback",22)); 
            bookList.Add(new Book("The Hitchhiker's Guide to the Galaxy", 20, "Douglas Adams", "hardcover",23)); 
            bookList.Add(new Book("Giovanni's Room", 30, "James Baldwin","paperback",24)); 
            bookList.Add(new Book("The Hate U Give" , 11, "Angie Thomas","hardcover",25)); 
        // keywords -> author name, paperback or hard, 
        

            //powerplant & energy          
            energyList.Add(new PowerPlant("100 KWh of energy", 200, 26));
            energyList.Add(new PowerPlant("150 KWh of energy",250, 27));
            energyList.Add(new PowerPlant("200 KWh of energy", 300, 28));
            energyList.Add(new PowerPlant("250 KWh of energy", 350, 29));
            energyList.Add(new PowerPlant("300 Kwh of energy", 400, 30));
            // Type your username and press enter
            Console.WriteLine("Create password");

            //Create a string variable and get us1er input from the keyboard and store it in the variable
            string password = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Enter password");
            string userInput = Console.ReadLine();
            if (userInput == password)
            {
                Console.WriteLine("Correct password");
            }
            else 
            {
                Console.WriteLine("Incorrect password");
            }
            Console.WriteLine("Welcome! This is what we offer");
            Console.WriteLine("Books");
            Console.WriteLine("Computers");
            Console.WriteLine("Basketball tickets");
            Console.WriteLine("Energy");
            //Console.WriteLine("Search);
            string userInput2; // user input for letters based on category

            string InputBook; //Input for choosing a book
            string userInputB; // for B
            string InputComp; //Input for choosing a computer
            string userInputC; // for C
            string InputTicket; //Input for choosing a basketball ticket
            string userInputT;  //for T
            string InputEnergy; //Input for choosing energy amount
            string userInputE;// for energy
            string userInputEnd; //Input for ending the primary while loop
            string InputSearch; // Input user input search
            string sSearch;
            string InputCart; //Input for cart
            bool endwhile = false; 
            bool endSearch = false;
            bool endbook = false;
            bool endcomp = false;
            bool endTicket = false;
            bool endenergy = false;
            bool userYN = false; // yes, no?
           
            while (endwhile == false)
            {
                Console.WriteLine("Which item category do you want? Type b for books, c for computers, e for energy, or t for basketball tickets. You can also press s to search a specific product.");
                userInput2 = Console.ReadLine();
                if (userInput2 == "s")
                {
                    while (endSearch == false)
                    {
                        Console.WriteLine("What would you like to search?");
                        sSearch = Console.ReadLine();
                   
                        Computer oFound = compList.Find(comp => comp.Color.Equals(sSearch)); //for computer name   
                        /*if (compList.contains(new comp("silver", "Windows", "AMD", "black", "red", "rose gold", "blue", "pink", "Apple))  
                            
                        
                        
                        */



                        if (oFound != null)
                        {
                            Console.WriteLine("Found it: " + oFound.getData());
                            Console.WriteLine("Would you like to add this item to your cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                InputCart = Console.ReadLine();
                                if (InputCart == "y")
                                {
                                    shopCart.Add(new Cart(oFound.Name, oFound.Price));
                                    Console.WriteLine("Item has been added to cart.");
                                    userYN = true;
                                }
                                else if (InputCart == "n")
                                {
                                    userYN = true;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add this item to your cart? Type y for yes or n for no.");
                                }

                            }
                        }
                        else
                        { 
                            Console.WriteLine("Not found");
                        }

                        Console.WriteLine("Would you like to keep searching? Type y for yes or n for no");
                        userYN = false;
                        while (userYN == false)
                        {
                            InputSearch = Console.ReadLine();
                            if (InputSearch == "n")
                            {
                                endSearch = true;
                                userYN = true;
                            }
                            else if (InputSearch == "y")
                            {
                                endSearch = false;
                                userYN = true;
                            }
                            else 
                            {
                                Console.WriteLine("Incorrect input. Would you like to keep searching? Type y for yes or n for no.");
                            }
                        }
                    }
                    Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                    userYN = false;
                    while (userYN == false)
                    {
                        userInputEnd = Console.ReadLine();
                        if (userInputEnd == "y")
                        {
                            Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
                            Console.WriteLine("--------------------------------------------------------");
                            foreach (var i in shopCart)
                            {
                                Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                                total = total + i.Price;
                            }
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("Total: $" + total);
                            userYN = true;
                            endwhile = true;
                        }
                        else if (userInputEnd == "n")
                        {
                            userYN = true;
                            endwhile = false;
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        }
                    }
                }
                //books
                else if (userInput2 == "b")
                {
                    while (endbook == false)
                    {
                        foreach (var book in bookList)
                        {
                            Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", book.Name, book.Price, book.Author, book.Cover, book.ItemNum);
                        }
                        Console.WriteLine("What book would you like to buy? Please write an item number.");
                        InputBook = Console.ReadLine();
                        if (InputBook == "16")
                        {
                            shopCart.Add(new Cart(bookList[0].Name,bookList[0].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[0].Name); 
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "17")
                        {
                            shopCart.Add(new Cart(bookList[1].Name,bookList[1].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[1].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "18")
                        {
                            shopCart.Add(new Cart(bookList[2].Name,bookList[2].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[2].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "19")
                        {
                            shopCart.Add(new Cart(bookList[3].Name,bookList[3].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[3].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "20")
                        {
                            shopCart.Add(new Cart(bookList[4].Name,bookList[4].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[4].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "21")
                        {
                            shopCart.Add(new Cart(bookList[5].Name,bookList[5].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[5].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "22")
                        {
                            shopCart.Add(new Cart(bookList[6].Name,bookList[6].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[6].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "23")
                        {
                            shopCart.Add(new Cart(bookList[7].Name,bookList[7].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[7].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "24")
                        {
                            shopCart.Add(new Cart(bookList[8].Name,bookList[8].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[8].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputBook == "25")
                        {
                            shopCart.Add(new Cart(bookList[9].Name,bookList[9].Price));
                            Console.WriteLine("This item has been added to cart: " + bookList[9].Name);
                            Console.WriteLine("Would you like to add another book to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputB = Console.ReadLine();
                                if (userInputB == "n")
                                {
                                    userYN = true;
                                    endbook = true;
                                }
                                else if (userInputB == "y")
                                {
                                    userYN = true;
                                    endbook = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another book to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a book.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                    userYN = false;
                    while (userYN == false)
                    {
                        userInputEnd = Console.ReadLine();
                        if (userInputEnd == "y")
                        {
                            Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
                            Console.WriteLine("--------------------------------------------------------");
                            foreach (var i in shopCart)
                            {
                                Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                                total = total + i.Price;
                            }
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("Total: $" + total);
                            userYN = true;
                            endwhile = true;
                        }
                        else if (userInputEnd == "n")
                        {
                            userYN = true;
                            endwhile = false;
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        }
                    }
                }
                //computers
                else if (userInput2 == "c")
                {
                    while (endcomp == false)
                    {
                        foreach (var comp in compList)
                        {
                            Console.WriteLine("Model: {0}, Price: {1}, Computer Brand: {2}, Description: {3}, ReleaseDate: {4}, Item Number: {5}", comp.Name, comp.Price, comp.ComputerBrand, comp.Description, comp.ReleaseDate, comp.ItemNum);
                        }
                        Console.WriteLine("Which computer would you like to buy? Please type an item number.");
                        InputComp = Console.ReadLine();
                        if (InputComp == "1")
                        {
                            shopCart.Add(new Cart(compList[0].Name,compList[0].Price));
                            Console.WriteLine( "This item has been added to cart: "+ compList[0].Name);
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputComp =="2")
                        {
                            shopCart.Add(new Cart(compList[1].Name,compList[1].Price));
                            Console.WriteLine("This item has been added to cart: " + compList[1].Name);  
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputComp =="3")
                        {
                            shopCart.Add(new Cart(compList[2].Name,compList[2].Price));
                            Console.WriteLine("This item has been added to cart: " + compList[2].Name);    
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputComp =="4")
                        {
                            shopCart.Add(new Cart(compList[3].Name,compList[3].Price));
                            Console.WriteLine("This item has been added to cart: " + compList[3].Name);    
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputComp =="5")
                        {
                            shopCart.Add(new Cart(compList[4].Name,compList[4].Price));
                            Console.WriteLine("This item has been added to cart: " + compList[4].Name); 
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputComp =="6")
                        {
                            shopCart.Add(new Cart(compList[5].Name,compList[5].Price));
                            Console.WriteLine("This item has been added to cart: " + compList[5].Name); 
                            Console.WriteLine("Would you like to add another computer to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputC = Console.ReadLine();
                                if (userInputC == "n")
                                {
                                    userYN = true;
                                    endcomp = true;
                                }
                                else if (userInputC == "y")
                                {
                                    userYN = true;
                                    endcomp = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another computer to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a computer.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                    userYN = false;
                    while (userYN == false)
                    {
                        userInputEnd = Console.ReadLine();
                        if (userInputEnd == "y")
                        {
                            Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
                            Console.WriteLine("--------------------------------------------------------");
                            foreach (var i in shopCart)
                            {
                                Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                                total = total + i.Price;
                            }
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("Total: $" + total);
                            userYN = true;
                            endwhile = true;
                        }
                        else if (userInputEnd == "n")
                        {
                            userYN = true;
                            endwhile = false;
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        }
                    }
                }
                //basketball tickets
                else if (userInput2 == "t")
                { 
                    while (endTicket == false)
                    {
                        foreach (var basket in basketList)
                        {
                            Console.WriteLine("Match: {0}, Price: {1}, Date: {2}, Section: {3}, Seat: {4}, Item Number: {5}", basket.Name, basket.Price, basket.Date, basket.Section, basket.Seat, basket.ItemNum);
                        }       
                        Console.WriteLine("What basketball ticket would you like? Please write an item number.");
                        InputTicket = Console.ReadLine();
                        if (InputTicket == "7")
                        {
                            shopCart.Add(new Cart(basketList[0].Name,basketList[0].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[0].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "8")
                        {
                            shopCart.Add(new Cart(basketList[1].Name,basketList[1].Price));
                            Console.WriteLine ("This item has been added to cart: " + basketList[1].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket= false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }                    
                        else if (InputTicket == "9")
                        {
                            shopCart.Add(new Cart(basketList[2].Name,basketList[2].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[2].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "10")
                        {
                            shopCart.Add(new Cart(basketList[3].Name,basketList[3].Price));
                            Console.WriteLine("This item has been added to cart: " + basketList[3].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT== "n")
                                {
                                    userYN = true;
                                    endTicket= true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "11")
                        {
                            shopCart.Add(new Cart(basketList[4].Name,basketList[4].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[4].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "12")
                        {
                            shopCart.Add(new Cart(basketList[5].Name,basketList[5].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[5].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "13")
                        {
                            shopCart.Add(new Cart(basketList[6].Name,basketList[6].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[6].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket= true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket= false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "14")
                        {
                            shopCart.Add(new Cart(basketList[7].Name,basketList[7].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[7].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputTicket == "15") 
                        {
                            shopCart.Add(new Cart(basketList[8].Name,basketList[8].Price));
                            Console.WriteLine("This item has been added to cart: "+basketList[8].Name + " match.");
                            Console.WriteLine("Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputT = Console.ReadLine();
                                if (userInputT == "n")
                                {
                                    userYN = true;
                                    endTicket = true;
                                }
                                else if (userInputT == "y")
                                {
                                    userYN = true;
                                    endTicket= false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another basketball ticket to the cart? Type y for yes or n for no.");
                                }
                            }
                        } 
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a basketball ticket.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                    userYN = false;
                    while (userYN == false)
                    {
                        userInputEnd = Console.ReadLine();
                        if (userInputEnd == "y")
                        {
                            Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
                            Console.WriteLine("--------------------------------------------------------");
                            foreach (var i in shopCart)
                            {
                                Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                                total = total + i.Price;
                            }
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("Total: $" + total);
                            userYN = true;
                            endwhile = true;
                        }
                        else if (userInputEnd == "n")
                        {
                            userYN = true;
                            endwhile = false;
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        }
                    }
                }
                //energy
                else if (userInput2 == "e")
                {
                    while (endenergy == false)
                    {
                        foreach (var energy in energyList)
                        {
                            Console.WriteLine("Energy: {0} Price: {1} Item Number: {2}", energy.Name, energy.Price, energy.ItemNum);
                        }  
                        Console.WriteLine("How much energy would you like? Please Write the item number.");
                        InputEnergy = Console.ReadLine();                        
                        if (InputEnergy == "26")
                        {
                            shopCart.Add(new Cart(energyList[0].Name,energyList[0].Price));
                            Console.WriteLine("This item has been added to cart: " + energyList[0].Name);
                            Console.WriteLine("Would you like to add more energy to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputE = Console.ReadLine();                            
                                if (userInputE == "n")
                                {
                                    userYN = true;
                                    endenergy = true;
                                }
                                else if (userInputE == "y")
                                {
                                    userYN = true;
                                    endenergy = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add more energy to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputEnergy == "27")
                        {
                            shopCart.Add(new Cart(energyList[1].Name,energyList[1].Price));
                            Console.WriteLine("This item has been added to cart: " + energyList[1].Name);
                            Console.WriteLine("Would you like to add more energy to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputE = Console.ReadLine();                            
                                if (userInputE == "n")
                                {
                                    userYN = true;
                                    endenergy = true;
                                }
                                else if (userInputE == "y")
                                {
                                    userYN = true;
                                    endenergy = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add more energy to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputEnergy == "28")
                        {
                            shopCart.Add(new Cart(energyList[2].Name,energyList[2].Price));
                            Console.WriteLine("This item has been added to cart: " + energyList[2].Name);
                            Console.WriteLine("Would you like to add more energy to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputE = Console.ReadLine();                            
                                if (userInputE == "n")
                                {
                                    userYN = true;
                                    endenergy = true;
                                }
                                else if (userInputE == "y")
                                {
                                    userYN = true;
                                    endenergy = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add more energy to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputEnergy == "29")
                        {
                            shopCart.Add(new Cart(energyList[3].Name,energyList[3].Price));
                            Console.WriteLine("This item has been added to cart: " + energyList[3].Name);
                            Console.WriteLine("Would you like to add more energy to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputE = Console.ReadLine();                            
                                if (userInputE == "n")
                                {
                                    userYN = true;
                                    endenergy = true;
                                }
                                else if (userInputE == "y")
                                {
                                    userYN = true;
                                    endenergy = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add more energy to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else if (InputEnergy == "30")
                        {
                            shopCart.Add(new Cart(energyList[4].Name,energyList[4].Price));
                            Console.WriteLine("This item has been added to cart: " + energyList[4].Name);
                            Console.WriteLine("Would you like to add more energy to the cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                userInputE = Console.ReadLine();                            
                                if (userInputE == "n")
                                {
                                    userYN = true;
                                    endenergy = true;
                                }
                                else if (userInputE == "y")
                                {
                                    userYN = true;
                                    endenergy = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add more energy to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from energy.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                    userYN = false;
                    while (userYN == false)
                    {
                        userInputEnd = Console.ReadLine();
                        if (userInputEnd == "y")
                        {
                            Console.WriteLine("Thank you for shopping with us. Here are your items and total:");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,-45} | {1,-10}", "Item" , "Price" ));
                            Console.WriteLine("--------------------------------------------------------");
                            foreach (var i in shopCart)
                            {
                                Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                                total = total + i.Price;
                            }
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("Total: $" + total);
                            userYN = true;
                            endwhile = true;
                        }
                        else if (userInputEnd == "n")
                        {
                            userYN = true;
                            endwhile = false;
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Incorrect input.");
                }
            }
        }                        
    }
}
