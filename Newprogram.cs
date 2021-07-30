using System;
using System.Collections.Generic;
namespace jul19 
{
    class NewProgram
    {
        static void Main(string[] args)
        {
            Cart shopCart = new Cart();
            List<StoreItem> allItems = new List<StoreItem>();

            #region Create Store Items
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

            //energy          
            allItems.Add(new PowerPlant("100 KWh of energy", 200, 26, "test"));
            allItems.Add(new PowerPlant("150 KWh of energy",250, 27, "test"));
            allItems.Add(new PowerPlant("200 KWh of energy", 300, 28, "test"));
            allItems.Add(new PowerPlant("250 KWh of energy", 350, 29, "test"));
            allItems.Add(new PowerPlant("300 Kwh of energy", 400, 30, "test"));
            
            #endregion

            //password
            Console.WriteLine("Create password");
            string password = Console.ReadLine();
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

            // Menu
            Console.WriteLine("Welcome! This is what we offer");
            Console.WriteLine("Books");
            Console.WriteLine("Computers");
            Console.WriteLine("Basketball tickets");
            Console.WriteLine("Energy");
            string userCategoryInput; 
            bool userIsStillShopping = true;
            bool userIsStillSearching;
            string userSearchInput;
           
            while (userIsStillShopping)
            {
                Console.WriteLine("Which item category do you want? Type b for books, c for computers, e for energy, or t for basketball tickets. You can also press s to search a specific product.");
                userCategoryInput = Console.ReadLine();
                if (userCategoryInput == "s")
                {
                    userIsStillSearching = true;
                    while (userIsStillSearching)
                    {
                        Console.WriteLine("What would you like to search?");
                        userSearchInput = Console.ReadLine();
                   
                        StoreItem itemFoundInSearch = allItems.Find(comp => comp.Keywords.Contains(userSearchInput));

                        if (itemFoundInSearch != null)
                        {
                            Console.WriteLine("Found it: " + itemFoundInSearch);
                            Console.WriteLine("Would you like to add this item to your cart? Type y for yes or n for no.");

                            string InputCart = Console.ReadLine();
                            if (InputCart == "y")
                            {
                                shopCart.AddToCart(itemFoundInSearch);
                                Console.WriteLine("Item has been added to your cart.");
                            }
                            else if (InputCart == "n")
                            {
                                Console.WriteLine("This item has not been added to your cart.");
                            }
                            else 
                            {
                                Console.WriteLine("Incorrect input.  The item was not added to your cart.");
                            }
                        }
                        else
                        { 
                            Console.WriteLine("The item was not found.  Nothing was added to your cart.");
                        }

                        Console.WriteLine("Would you like to keep searching? Type y for yes or n for no");
                        bool didUserEnterValidInputForCartItem = false;
                        while (didUserEnterValidInputForCartItem == false)
                        {
                            string InputSearch = Console.ReadLine();
                            if (InputSearch == "n")
                            {
                                userIsStillSearching = false;
                                didUserEnterValidInputForCartItem = true;
                            }
                            else if (InputSearch == "y")
                            {
                                userIsStillSearching = true;
                                didUserEnterValidInputForCartItem = true;
                            }
                            else 
                            {
                                Console.WriteLine("Incorrect input. Would you like to keep searching? Type y for yes or n for no.");
                                didUserEnterValidInputForCartItem = false;
                            }
                        }
                    }
                }
                else if (userCategoryInput == "b" || userCategoryInput == "c" || userCategoryInput == "e" || userCategoryInput == "t")
                {
                    bool userIsStillAddingItemsFromMenu = true;
                    while (userIsStillAddingItemsFromMenu)
                    {
                        foreach (var item in allItems)
                        {
                            if (userCategoryInput == "b" && item is Book) {
                                var tempBook = (Book)item;
                                //Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", tempBook.Name, tempBook.Price, tempBook.Author, tempBook.Cover, tempBook.ItemNum);
                                Console.WriteLine(tempBook.getData());
                            }
                            else if (userCategoryInput == "c" && item is Computer) {
                                var tempComputer = (Computer)item;
                                //Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", tempBook.Name, tempBook.Price, tempBook.Author, tempBook.Cover, tempBook.ItemNum);
                                Console.WriteLine(tempComputer.getData());
                            }
                            else if (userCategoryInput == "e" && item is PowerPlant) {
                                var tempPower = (PowerPlant)item;
                                //Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", tempBook.Name, tempBook.Price, tempBook.Author, tempBook.Cover, tempBook.ItemNum);
                                Console.WriteLine(tempPower.getData());
                            }
                            else if (userCategoryInput == "t" && item is Basketball) {
                                var tempBasketball = (Basketball)item;
                                //Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", tempBook.Name, tempBook.Price, tempBook.Author, tempBook.Cover, tempBook.ItemNum);
                                Console.WriteLine(tempBasketball.getData());
                            }
                        }
                        Console.WriteLine("What would you like to buy? Please write an item number.");
                        string itemNumberTheUserChose = Console.ReadLine();
                        var foundItem = allItems.Find(itemToSearch => itemToSearch.ItemNum.ToString() == itemNumberTheUserChose);
                        if (foundItem != null) {
                            shopCart.AddToCart(foundItem);
                            
                            Console.WriteLine("This item has been added to cart: " + foundItem.Name); 
                            Console.WriteLine("Would you like to add another item to the cart? Type y for yes or n for no.");
                            
                            bool didUserEnterValidInputForFoundItem = false;
                            while (didUserEnterValidInputForFoundItem == false)
                            {
                                string doesUserWantToAddAnotherItem = Console.ReadLine();
                                if (doesUserWantToAddAnotherItem == "n")
                                {
                                    didUserEnterValidInputForFoundItem = true;
                                    userIsStillAddingItemsFromMenu = false;
                                }
                                else if (doesUserWantToAddAnotherItem == "y")
                                {
                                    didUserEnterValidInputForFoundItem = true;
                                    userIsStillAddingItemsFromMenu = true;
                                }
                                else 
                                {
                                    Console.WriteLine("Incorrect input. Would you like to add another item to the cart? Type y for yes or n for no.");
                                    didUserEnterValidInputForFoundItem = false;
                                }
                            }
                        }
                        else {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a book.");
                        }
                    }
                }
                else {
                    Console.WriteLine("You did not make a valid selection.");
                }
                Console.WriteLine("Are you done shopping for today? Type y for yes or n for no.");
                bool didUserEnterValidInput = false;
                while (didUserEnterValidInput == false) {
                    string doneShoppingInput = Console.ReadLine();
                    if (doneShoppingInput == "y")
                    {
                        shopCart.PrintItems();
                        didUserEnterValidInput = true;
                        userIsStillShopping = false;
                    }
                    else if (doneShoppingInput == "n")
                    {
                        didUserEnterValidInput = true;
                        userIsStillShopping = true;
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect input. Are you done shopping for today? Type y for yes or n for no");
                        didUserEnterValidInput = true;
                    }
                }
            }
        }
    }                        
}

