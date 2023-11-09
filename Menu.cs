using System;
using System.Collections.Generic;
using System.Text;

public class Menu
{
    public static List<Room> roomslist = new List<Room>();
    public static List<Customer> customers = new List<Customer>();
    public static List<Bookings> bookings = new List<Bookings>();
    public static List<CustomerReview> reviewlist = new List<CustomerReview>();

    public static void DisplayAsciiArt()
    {
        string prompt = @"
         _    _ __  __  _____ 
        | |  | |  \/  |/ ____|
        | |__| | \  / | (___  
        |  __  | |\/| |\___ \ 
        | |  | | |  | |____) |
        |_|  |_|_|  |_|_____/ 
                                
                                
    ";

        Console.Clear();
        Console.WriteLine(prompt);
    }

    public static void RunStartMenu(int CustId)
    {
        string[] menuOptions = { "Staff Menu", "Customer Menu", "Exit" };
        int selectedIndex = 0;
        

        while (true)
        {
           
            DisplayAsciiArt();

            Console.WriteLine("Main Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionStart(menuOptions[selectedIndex], CustId);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionStart(string selectedOption, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Staff Menu")
        {
            
            RunStaffMenu(CustId);
        }
        else if (selectedOption == "Customer Menu")
        {

            RunCustomerMenu(CustId);   
            
        }
        
    }
    public static void RunCustomerMenu(int CustId)
    {
        string[] menuOptions = { "Book a Room", "Available Rooms","Submit a Review", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionCustomer(menuOptions[selectedIndex], bookings, roomslist, CustId);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionCustomer(string selectedOption, List<Bookings> bookings, List<Room> rooms, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Book a Room")
        {
            //RunRoomMenu(roomslist);
        }
        else if (selectedOption == "Available Rooms")
        {
            BookingMethods.AvailableRooms(rooms, bookings);
        }
        else if (selectedOption == "Submit a Review")
        {
            ReviewMethods.AddReview(CustId, reviewlist);
        }
        
    }

    public static void RunStaffMenu(int CustId)
    {
        string[] menuOptions = { "Room utility", "Customer utility", "Booking utility","Review utility", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionStaff(menuOptions[selectedIndex], CustId);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionStaff(string selectedOption, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Room utility")
        {
            RunRoomMenu(roomslist);
        }
        else if (selectedOption == "Customer utility")
        {
            RunCustomerstaffMenu(customers);
        }
        else if (selectedOption == "Booking utility")
        {
            RunBookingMenu(bookings);
        }
        else if (selectedOption == "Review utility")
        {
            RunReviewMenu(reviewlist, CustId);
        }
        
        
    }

     public static void RunRoomMenu(List<Room>rooms)
    {
        string[] menuOptions = { "Add Room", "Remove Room","Find Room","Print Room", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionRoom(menuOptions[selectedIndex], rooms);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionRoom(string selectedOption, List<Room>rooms)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Add Room")
        {
            RoomMethods.AddRoom(rooms);
        }
        else if (selectedOption == "Remove Room")
        {
            RoomMethods.RemoveRoom(rooms);    
        }
        else if (selectedOption == "Find Room")
        {
            RoomMethods.FindRoom(rooms);    
        }
        else if (selectedOption == "Print Room")
        {
            RoomMethods.PrintRooms(rooms);    
        }
        
    }

    public static void RunCustomerstaffMenu(List<Customer>customers)
    {
        string[] menuOptions = { "Add Customer", "Remove Customer","Find Customer","Print Customer", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionCustomerStaff(menuOptions[selectedIndex], customers);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionCustomerStaff(string selectedOption, List<Customer>customers)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Add Customer")
        {
            CustomerMethods.AddCustomer(customers);
        }
        else if (selectedOption == "Remove Customer")
        {
            CustomerMethods.RemoveCustomer(customers);    
        }
        else if (selectedOption == "Find Customer")
        {
            CustomerMethods.FindCustomer(customers);;    
        }
        else if (selectedOption == "Print Customer")
        {
            CustomerMethods.PrintCustomer(customers);    
        }
        
    }

    public static void RunBookingMenu(List<Bookings>bookings)
    {
        string[] menuOptions = { "Add Booking", "Remove Booking","Find Booking","Print Booking", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionBooking(menuOptions[selectedIndex], bookings);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionBooking(string selectedOption, List<Bookings>bookings)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Add Booking")
        {
            BookingMethods.AddBooking(bookings, roomslist);
        }
        else if (selectedOption == "Remove Booking")
        {
            BookingMethods.RemoveBooking(bookings, customers);    
        }
        else if (selectedOption == "Find Booking")
        {
            BookingMethods.AvailableRooms(roomslist, bookings);    
        }
        else if (selectedOption == "Print Booking")
        {
            BookingMethods.PrintBooking(bookings, customers);    
        }
        
    }

    public static void RunReviewMenu(List<CustomerReview>reviewlist, int CustId)
    {
        string[] menuOptions = { "Remove Review","Print Reviews", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            DisplayAsciiArt(); 

            Console.WriteLine("Staff Menu:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string prefix = (i == selectedIndex) ? "> " : "  ";
                Console.WriteLine($"{prefix}{menuOptions[i]}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
            {
                selectedIndex--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
            {
                selectedIndex++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedIndex == menuOptions.Length - 1)
                {
                    break; 
                }

                
                HandleMenuOptionReview(menuOptions[selectedIndex], reviewlist, CustId);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionReview(string selectedOption, List<CustomerReview>reviewlist, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Remove Review")
        {
            ReviewMethods.RemoveReview(CustId, reviewlist);
        }
        else if (selectedOption == "Print Reviews")
        {
            ReviewMethods.PrintReviews(reviewlist);    
        }
        
    }

}