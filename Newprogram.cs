using System;
using System.Collections.Generic;
namespace jul19 
{
    class NewProgram
    {
        static void Main(string[] args)
        {
            decimal total = 0;
            Cart shopCart = new Cart();
            List<StoreItem> allItems = new List<StoreItem>();
            List<Basketball> basketList = new List<Basketball>();
            List<Computer> compList = new List<Computer>();
            List<Book> bookList = new List<Book>();
            List<PowerPlant> energyList = new List<PowerPlant>();
            //laptops             
            allItems.Add(new Computer("MacBook Air","rose gold",900, "Apple", "New with M1 chip", "2021", 1)); 
            allItems.Add(new Computer("Surface Pro",  "red", 700, "Windows", "laptop and tablet in one","2021", 2)); 
            allItems.Add(new Computer("Microsoft", "black",600, "Windows", "Touch screen ", "2020", 3)); 
            allItems.Add(new Computer("Razer Blade 15", "blue", 700, "Windows","Advanced laptop w/ Nvidia RTX 2070", "2021", 4)); 
            allItems.Add(new Computer("HP Envy"," pink", 529 , "Window", "11th Generation Intel", "2019", 5)); 
            allItems.Add(new Computer("Asus ROG Zephyrus","silver", 500, "Windows", "AMD 5700xt and Ryzen 5600x", "2021", 6));          
            allItems[5].Keywords = new List<string>() {"silver", "Windows", "M1", "black", "red", "rose gold", "blue", "pink", "Apple", "Intel", "AMD","Nvidia" }; //no limit
            //basketball game tickets
            allItems.Add(new Basketball("Chicago Bulls vs Phoenix Suns", 250, "July 30", 109, 30, 7));
            allItems.Add(new Basketball("Phoenix Suns vs Bucks", 150, "August 2", 80, 20, 8));
            allItems.Add(new Basketball("LA Lakers vs Boston Celtics", 250, "September 24", 48, 15, 9));
            allItems.Add(new Basketball("Brooklyn Nets vs Denver Nuggets",100,"October 11",50, 24, 10)); 
            allItems.Add(new Basketball("New York Knicks vs Philadelphia 76ers", 183, "July 3",140, 49, 11)); 
            allItems.Add(new Basketball("Indiana Pacers vs Milwaukee Bucks" , 194, "June 3" , 103, 53, 12));
            allItems.Add(new Basketball("Denver Nuggets vs Utah Jazz", 139, "April 6" ,194, 49, 13));
            allItems.Add(new Basketball("Oklahoma City Thunder vs LA Clippers", 192, "January 3" ,102, 43, 14));
            allItems.Add(new Basketball("San Antoinio Spurs vs Memphis Grizzles", 193, "January 5", 195, 34 ,15)); 
            
            //books
            allItems.Add(new Book("Hunger Games", 15, "Suzanne Collins", "hardcover",16)); 
            allItems.Add(new Book("The Book Thief", 11, "Markus Zusak", "paperback",17)); 
            allItems.Add(new Book("To Kill a Mockingbird", 14, "Harper Lee", "paperback",18)); 
            allItems.Add(new Book("The Great Gatsby", 9, "F Scott Fitzgerald", "hardcover",19)); 
            allItems.Add(new Book("Things Fall Apart", 14, "Chinua Achebe", "paperback",20)); 
            allItems.Add(new Book("The Color Purple", 12, "Alice Walker", "paperback",21)); 
            allItems.Add(new Book("Lord of the Flies ", 11, "William Colding", "paperback",22)); 
            allItems.Add(new Book("The Hitchhiker's Guide to the Galaxy", 20, "Douglas Adams", "hardcover",23)); 
            allItems.Add(new Book("Giovanni's Room", 30, "James Baldwin","paperback",24)); 
            allItems.Add(new Book("The Hate U Give" , 11, "Angie Thomas","hardcover",25)); 
        // keywords -> author name, paperback or hard, 
        

            //powerplant & energy          
            allItems.Add(new PowerPlant("100 KWh of energy", 200, 26, "test"));
            allItems.Add(new PowerPlant("150 KWh of energy",250, 27, "test"));
            allItems.Add(new PowerPlant("200 KWh of energy", 300, 28, "test"));
            allItems.Add(new PowerPlant("250 KWh of energy", 350, 29, "test"));
            allItems.Add(new PowerPlant("300 Kwh of energy", 400, 30, "test"));
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
            //string InputTicket; //Input for choosing a basketball ticket
            //string userInputT;  //for T
            //string InputEnergy; //Input for choosing energy amount
            //string userInputE;// for energy
            string userInputEnd; //Input for ending the primary while loop
            string InputSearch; // Input user input search
            string sSearch;
            string InputCart; //Input for cart
            //string Inputkey; // input for keywords
           // string Keywords;
            bool endwhile = false; 
            bool endSearch = false;
            bool endbook = false;
            bool endcomp = false;
            bool endTicket = false;
            bool endenergy = false;
            bool userYN = false; // yes, no?
            
           // bool endKey = false;
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
                   
                        StoreItem oFound = allItems.Find(item => item.Name.Equals(sSearch));
                        if (oFound != null)
                        {
                            Console.WriteLine("Found it: " + oFound);
                            Console.WriteLine("Would you like to add this item to your cart? Type y for yes or n for no.");
                            userYN = false;
                            while (userYN == false)
                            {
                                InputCart = Console.ReadLine();
                                if (InputCart == "y")
                                {
                                    shopCart.AddToCart(oFound);
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
                            // foreach (var i in shopCart)
                            // {
                            //     Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                            //     total = total + i.Price;
                            // }
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
                        foreach (var item in allItems)
                        {
                            if (item is Book) {
                                var tempBook = (Book)item;
                                //Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", tempBook.Name, tempBook.Price, tempBook.Author, tempBook.Cover, tempBook.ItemNum);
                                Console.WriteLine(tempBook.getData());
                            }
                        }
                        Console.WriteLine("What would you like to buy? Please write an item number.");
                        InputBook = Console.ReadLine();
                        var foundItem = allItems.Find(itemToSearch => itemToSearch is Book && itemToSearch.ItemNum.ToString() == InputBook );
                        shopCart.AddToCart(foundItem);
                        Console.WriteLine("This item has been added to cart: " + foundItem.Name); 
                        Console.WriteLine("Would you like to add another item to the cart? Type y for yes or n for no.");
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
                                    Console.WriteLine("Incorrect input. Would you like to add another item to the cart? Type y for yes or n for no.");
                                }
                            }
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
                            // foreach (var i in shopCart)
                            // {
                            //     Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                            //     total = total + i.Price;
                            // }
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
                else if (userInput2 == "c")
                {
                    while (endcomp == false)
                    {
                        foreach (var item in allItems)
                        {
                            if (item is Computer) 
                            {
                                var tempComp = (Computer)item;
                                Console.WriteLine(tempComp.getData());
                            }
                        }
                        Console.WriteLine("What would you like to buy? Please write an item number.");
                        InputComp = Console.ReadLine();
                        var foundItem = allItems.Find(itemToSearch => itemToSearch is Computer && itemToSearch.ItemNum.ToString() == InputComp );
                        if (foundItem.ItemNum.ToString() == InputComp)
                        {
                            shopCart.AddToCart(foundItem);
                            Console.WriteLine("This item has been added to cart: " + foundItem.Name); 
                            Console.WriteLine("Would you like to add another item to the cart? Type y for yes or n for no.");
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
                                    Console.WriteLine("Incorrect input. Would you like to add another item to the cart? Type y for yes or n for no.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid item number.");
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
                        // foreach (var i in shopCart)
                        // {
                        //     Console.WriteLine(String.Format("{0,-45} | {1,-10}", i.Name , "$" + i.Price ));
                        //     total = total + i.Price;
                        // }
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
            }
        }
    }                        
}

