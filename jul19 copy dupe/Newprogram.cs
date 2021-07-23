using System;
using System.Collections.Generic;
namespace jul19 
{
    class NewProgram
    {
        static void Main(string[] args)
        {
            List<Basketball> basketList = new List<Basketball>();
            List<Computer> compList = new List<Computer>();
            List<Book> bookList = new List<Book>();
            List<PowerPlant> energyList = new List<PowerPlant>();
            //laptops             
            compList.Add(new Computer("MacBook Air",900, "Apple", "New with M1 chip", "2021", 1)); //index 0
            compList.Add(new Computer("Surface Pro", 1400, "Windows", "laptop and tablet in one","2021", 2)); //index 1
            compList.Add(new Computer("Microsoft", 600, "Windows", "Touch screen ", "2020", 3)); //index 2
            compList.Add(new Computer("Razer Blade 15", 2700, "Windows","Advanced laptop w/ RTX 2070", "2021", 4)); // index 3
            compList.Add(new Computer("HP Envy", 1029 , "Window", "11th Generation Intel", "2019", 5)); // index 4
            compList.Add(new Computer("Asus ROG Zephyrus", 1500, "Windows", "5700xt + Ryzen 5600x", "2021", 6));;  // index 5           
            //basketball game tickets
            basketList.Add(new Basketball("Chicago Bulls vs Phoenix Suns", 250, "July 30", 109, 30, 7));
            basketList.Add(new Basketball("phoenix suns vs Bucks", 150, "August 2", 80, 20, 8));
            basketList.Add(new Basketball("Lakers vs Boston Celtics", 250, "September 24", 48, 15, 9));
            basketList.Add(new Basketball("Brooklyn Nets vs Denver Nuggets",100,"October 11",50, 24, 10)); 
            basketList.Add(new Basketball("New York Knicks vs Philadelphia 76ers", 183, "July 3",140, 49, 11)); 
            basketList.Add(new Basketball("Indiana Pacers vs Milwaukee Bucks" , 194, "June 3" , 103, 53, 12));
            basketList.Add(new Basketball("Denver Nuggets vs Utah Jazz", 139, "April 6" ,194, 49, 13));
            basketList.Add(new Basketball("Oklahoma City Thunder va LA Clippers", 192, "January 3" ,102, 43, 14));
            basketList.Add(new Basketball("San Antoinio Spurs vs Memphis Grizzles", 193, "January 5", 195, 34 ,15)); 
            //books
            bookList.Add(new Book("Hunger Games", 15, "Suzanne Collins", "hardcover",16)); //index 0
            bookList.Add(new Book("The Book Thief", 11, "Markus Zusak", "paperback",17)); //index 1
            bookList.Add(new Book("To Kill a Mockingbird", 14, "Harper Lee", "paperback",18)); //2
            bookList.Add(new Book("The Great Gatsby", 9, "F Scott Fitzgerald", "hardcover",19)); //3
            bookList.Add(new Book("Things Fall Apart", 14, "Chinua Achebe", "paperback",20)); //4
            bookList.Add(new Book("The Color Purple", 12, "Alice Walker", "paperback",21)); //5
            bookList.Add(new Book("Lord of the Flies ", 11, "William Colding", "paperback",22)); //6
            bookList.Add(new Book("The Hitchhiker's Guide to the Galaxy", 20, "Douglas Adams", "hardcover",23)); //7
            bookList.Add(new Book("Giovanni's Room", 30, "James Baldwin","paperback",24)); //8
            bookList.Add(new Book("The Hate U Give" , 11, "Angie Thomas","hardcover",25)); //9
            //powerplant & energy          
            energyList.Add(new PowerPlant(100, "KWh", 200, 26));
            energyList.Add(new PowerPlant(150,"KWh",250, 27));
            energyList.Add(new PowerPlant(200,"KWh", 300, 28));
            energyList.Add(new PowerPlant(250,"KWh", 350, 29));
            energyList.Add(new PowerPlant(300, "Kwh", 400, 30));
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
            string userInput2;

            string userInput3; //for choosing a book
            string userInputB;
            string userInput4; //for choosing a computer
            string userInputC;
            string userInput5; //for choosing a basketball ticket
            string userInputL;
            string userInput6; //for choosing energy amount
            string userInputE;
            string userInputEnd; //for ending the primary while loop
            bool endwhile = false; 
            bool endbook = false;
            bool endcomp = false;
            bool endbasket = false;
            bool endenergy = false;
            while (endwhile == false)
            {
                Console.WriteLine("Which item category do you want?");
                userInput2 = Console.ReadLine();
                //books
                if (userInput2 == "Books")
                {
                    while (endbook == false)
                    {
                        foreach (var book in bookList)
                        {
                            Console.WriteLine("Title: {0}, Price: {1}, Author: {2}, Cover: {3}, Item Number: {4}", book.Name, book.Price, book.Author, book.Cover, book.ItemNum);
                        }
                        Console.WriteLine("What book would you like to buy? Please write an item number.");
                        userInput3 = Console.ReadLine();
                        if (userInput3 == "16")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[0].Name); 
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "17")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[1].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "18")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[2].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "19")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[3].Name);
                            Console.WriteLine("Do you want to buy another Book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "20")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[4].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "21")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[5].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "22")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[6].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "23")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[7].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "24")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[8].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else if (userInput3 == "25")
                        {
                            Console.WriteLine("You have bought this item: " + bookList[9].Name);
                            Console.WriteLine("Do you want to buy another book? Yes or No");
                            userInputB = Console.ReadLine();
                            if (userInputB == "No")
                            {
                                endbook = true;
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a book.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today?");
                    userInputEnd = Console.ReadLine();
                    if (userInputEnd == "Yes")
                    {
                        endwhile = true;
                        Console.WriteLine("Thank you for shopping with us.");
                    }
                }
                //computers
                else if (userInput2 == "Computers")
                {
                    while (endcomp == false)
                    {
                        foreach (var comp in compList)
                        {
                            Console.WriteLine("Model: {0}, Price: {1}, Computer Brand: {2}, Description: {3}, ReleaseDate: {4}, Item Number: {5}", comp.Name, comp.Price, comp.ComputerBrand, comp.Description, comp.ReleaseDate, comp.ItemNum);
                        }
                        Console.WriteLine("Which computer would you like to buy? Please type an item number.");
                        userInput4 = Console.ReadLine();
                        if (userInput4 == "1")
                        {
                            Console.WriteLine("You have bought this item " + compList[0].Name);
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                        else if (userInput4 =="2")
                        {
                            Console.WriteLine("You have bought this item " + compList[1].Name);  
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                        else if (userInput4 =="3")
                        {
                            Console.WriteLine("You have bought this item " + compList[2].Name);    
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                        else if (userInput4 =="4")
                        {
                            Console.WriteLine("You have bought this item " + compList[3].Name);    
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                         else if (userInput4 =="5")
                        {
                            Console.WriteLine("You have bought this item " + compList[4].Name); 
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                        else if (userInput4 =="6")
                        {
                            Console.WriteLine("You have bought this item " + compList[5].Name); 
                            Console.WriteLine("Do you want to buy another computer? Yes or No");
                            userInputC = Console.ReadLine();
                            if (userInputC == "No")
                            {
                                endcomp = true;
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a computer.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today?");
                    userInputEnd = Console.ReadLine();
                    if (userInputEnd == "Yes")
                    {
                        endwhile = true;
                        Console.WriteLine("Thank you for shopping with us.");
                    }
                }
                //basketball tickets
                else if (userInput2 == "Basketball tickets")
                { 
                    while (endbasket == false)
                    {
                        foreach (var basket in basketList)
                        {
                            Console.WriteLine("Match: {0}, Price: {1}, Date: {2}, Section: {3}, Seat: {4}, Item Number: {5}", basket.Name, basket.Price, basket.Date, basket.Section, basket.Seat, basket.ItemNum);
                        }       
                        Console.WriteLine("What basketball ticket would you like? Please write an item number.");
                        userInput5 = Console.ReadLine();
                        if (userInput5 == "7")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[0].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 == "8")
                        {
                            Console.WriteLine ("You have bought this item: " + basketList[1].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }                    
                        else if (userInput5 =="9")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[2].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 =="10")
                        {
                            Console.WriteLine("You have bought this item: " + basketList[3].Name + " match.");
                            Console.WriteLine("Do y;ou want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();                            
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 =="11")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[4].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();                            
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 =="12")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[5].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 == "13")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[6].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();
                            if (userInputL == "No")
                            {
                                endbasket = true;
                            }
                        }
                        else if (userInput5 =="14")
                        {
                            Console.WriteLine("You have bought this item: "+basketList[7].Name + " match.");
                            Console.WriteLine("Do yu want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();                            
                            if (userInputL == "No")
                            {
;                                endbasket = true;
                            }
                        }
                        else if (userInput5 =="15") 
                        {
                            Console.WriteLine("You have bought this item: "+basketList[8].Name + " match.");
                            Console.WriteLine("Do you want to buy another basketball ticket?");
                            userInputL = Console.ReadLine();                            
                            if (userInputL == "No")
                            {
                                endbasket = true;
;                                Console.WriteLine("Thank you for shopping with us.");
                            }
                        } 
                        else 
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from a basketball ticket.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today?");
                    userInputEnd = Console.ReadLine();                   
                    if (userInputEnd == "Yes")
                    {
                        endwhile = true;
                        Console.WriteLine("Thank you for shopping with us.");
                    }
                }
                //energy
                else if (userInput2 == "Energy")
                {
                    while (endenergy == false)
                    {
                        foreach (var energy in energyList)
                        {
                            Console.WriteLine("Energy: {0} {1} Price: {2} Item Number: {3}", energy.AmountInKWh, energy.UnitOfmeasurement, energy.Price, energy.ItemNum);
                        }  
                        Console.WriteLine("How much energy would you like? Please Write the item number.");
                        userInput6 = Console.ReadLine();                        
                        
                        
                            if (userInput6 == "26")
                        {
                            Console.WriteLine("You have bought this item: " + energyList[0].AmountInKWh+ " " +energyList[0].UnitOfmeasurement);
                            Console.WriteLine("Do you want to buy more energy?");
                            userInputE = Console.ReadLine();                            
                            if (userInputE == "No")
                            {
                                endenergy = true;
                            }
                        }
                        else if (userInput6 == "27")
                        {
                            Console.WriteLine("You have bought this item: " + energyList[1].AmountInKWh+ " " +energyList[1].UnitOfmeasurement);
                            Console.WriteLine("Do you want to buy more energy?");
                            userInputE = Console.ReadLine();                           
                             if (userInputE == "No")
                            {
                                endenergy = true;
                            }
                        }
                        else if (userInput6 == "28")
                        {
                            Console.WriteLine("You have bought this item: " + energyList[2].AmountInKWh+ " " +energyList[2].UnitOfmeasurement);
                            Console.WriteLine("Do you want to buy more energy?");
                            userInputE = Console.ReadLine();                            
                            if (userInputE == "No")
                            {
                                endenergy = true;
                            }
                        }
                        else if (userInput6 == "29")
                        {
                            Console.WriteLine("You have bought this item: " + energyList[3].AmountInKWh+ " " +energyList[3].UnitOfmeasurement);
                            Console.WriteLine("Do you want to buy more energy?");
                            userInputE = Console.ReadLine();                            
                            if (userInputE == "No")
                            {
                                endenergy = true;
                            }
                        }
                        else if (userInput6 == "30")
                        {
                            Console.WriteLine("You have bought this item: " + energyList[4].AmountInKWh + " " +energyList[4].UnitOfmeasurement);
                            Console.WriteLine("Do you want to buy more energy?");
                            userInputE = Console.ReadLine();
                            if (userInputE == "No")
                            {
                                endenergy = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Please write a valid item number from energy.");
                        }
                    }
                    Console.WriteLine("Are you done shopping for today?");
                    userInputEnd = Console.ReadLine();
                    if (userInputEnd == "Yes")
                    {
                        endwhile = true;
                        Console.WriteLine("Thank you for shopping with us.");
                    }
                    else
                    {
                        endwhile = false;
                    }
                }
                else 
                {
                    Console.WriteLine("Incorrect input. Please type 'Books', 'Computers', 'Energy', or 'Basketball tickets'");
                }
            }
        }                        
    }
}