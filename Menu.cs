using System;
using System.Collections.Generic;
using System.Text;

public class Menu
{
    public static List<Room> roomslist = new List<Room>();
    public static List<Customer> customers = new List<Customer>();
    public static List<Bookings> bookings = new List<Bookings>();
    public static List<CustomerReview> reviewlist = new List<CustomerReview>();

    public static void StartProgram()
    {
        int CustId = 0;
        TestMethods.TestMethod(customers, roomslist, bookings, reviewlist);

        string[] mainMenuOptions = { "Staff Menu", "Customer Menu", "Exit" };
        RunMenu("Main Menu", mainMenuOptions, HandleMenuOptionStart, CustId);

        Console.WriteLine("Thank you for using the Hotel Management Software. Goodbye!");
    }

    public static void DisplayAsciiArt()
    {
        string prompt = @"
             _    _ __  __  _____ 
            | |  | |  \/  |/ ____|
            | |__| | \  / | (___  
            |  __  | |\/| |\___ \ 
            | |  | | |  | |____) |
            |_|  |_|_|  |_|_____/ 
 ----------------------------------------------------------------------------
| Hello and welcome to the Hotel Management Software!                        |
| Use the ↑/↓ buttons to navigate the menu. Press enter to choose option.    |
 ----------------------------------------------------------------------------                         
    ";

        Console.Clear();
        Console.WriteLine(prompt);
    }
    //menuName = name of the menu. menuOptions = array of strings representing the menu options. handleMenuOption = Delegate that will handle the selected menu option. CustId = customer id.
    public static void RunMenu(string menuName, string[] menuOptions, Action<string, int> handleMenuOption, int CustId)
{
    int selectedIndex = 0;
    Console.CursorVisible = false;

    while (true)
    {
        DisplayAsciiArt();

        Console.WriteLine($"{menuName}:");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            string prefix = (i == selectedIndex) ? "> " : "  ";
            Console.WriteLine($"{prefix}{menuOptions[i]}"); // Display menu options with '>' prefix for the selected option
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey(); // Read user input

        if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0) // Update the selected index based on user input
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
                break; // If the user selects "Exit," break out of the loop
            }

            // Invoke the handleMenuOption delegate with the selected option and CustId
            handleMenuOption(menuOptions[selectedIndex], CustId);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine(); 
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
        string[] menuOptions = { "Book a Room", "Available Rooms", "Submit a Review", "Print Reviews", "Exit" };

        RunMenu("Customer Menu", menuOptions, HandleMenuOptionCustomer, CustId);
    }

    public static void HandleMenuOptionCustomer(string selectedOption, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Book a Room")
        {
            BookingMethods.BookARoom(bookings,roomslist,customers);
        }
        else if (selectedOption == "Available Rooms")
        {
            BookingMethods.AvailableRooms(roomslist, bookings);
        }
        else if (selectedOption == "Submit a Review")
        {
            ReviewMethods.AddReview(CustId, reviewlist);
        }
        else if (selectedOption == "Print Reviews")
        {
            ReviewMethods.PrintReviews(reviewlist);
        }
        
    }

    public static void RunStaffMenu(int CustId)
    {
        string[] menuOptions = { "Room utility", "Customer utility", "Booking utility", "Review utility", "All Checked in","Exit" };
        RunMenu("Staff Menu", menuOptions, HandleMenuOptionStaff, CustId);
    }

    public static void HandleMenuOptionStaff(string selectedOption, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Room utility")
        {
            RunRoomMenu(CustId);
        }
        else if (selectedOption == "Customer utility")
        {
            RunCustomerstaffMenu(CustId);
        }
        else if (selectedOption == "Booking utility")
        {
            RunBookingMenu(CustId);
        }
        else if (selectedOption == "Review utility")
        {
            RunReviewMenu(CustId);
        }
        else if (selectedOption == "All Checked in")
        {
            Checkin.AllCheckedIn(bookings,customers);
        }
        
        
    }

     public static void RunRoomMenu(int CustId)
    {
        string[] menuOptions = { "Add Room", "Remove Room", "Find Room", "Print Room", "Exit" };
        RunMenu("Room Menu", menuOptions, HandleMenuOptionRoom, CustId);
    }

    public static void HandleMenuOptionRoom(string selectedOption, int CustId)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        if (selectedOption == "Add Room")
        {
            RoomMethods.AddRoom(roomslist);
        }
        else if (selectedOption == "Remove Room")
        {
            RoomMethods.RemoveRoom(roomslist);    
        }
        else if (selectedOption == "Find Room")
        {
            RoomMethods.FindRoom(roomslist);    
        }
        else if (selectedOption == "Print Room")
        {
            RoomMethods.PrintRooms(roomslist);    
        }
        
    }

    public static void RunCustomerstaffMenu(int CustId)
    {
        string[] menuOptions = { "Add Customer", "Remove Customer", "Find Customer", "Print Customer", "Exit" };
        RunMenu("Customer Staff Menu", menuOptions, HandleMenuOptionCustomerStaff, CustId);
    }

    public static void HandleMenuOptionCustomerStaff(string selectedOption, int CustId)
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
            CustomerMethods.FindCustomer(customers);    
        }
        else if (selectedOption == "Print Customer")
        {
            CustomerMethods.PrintCustomer(customers);    
        }
    }

    public static void RunBookingMenu(int CustId)
    {
       string[] menuOptions = { "Add Booking", "Remove Booking", "Find Bookings", "Print Booking", "Customer Checkin/Out", "Exit" };
        RunMenu("Booking Menu", menuOptions, HandleMenuOptionBooking, CustId);
    }

    public static void HandleMenuOptionBooking(string selectedOption, int CustId)
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
        else if (selectedOption == "Find Bookings")
        {
            BookingMethods.AvailableRooms(roomslist, bookings);    
        }
        else if (selectedOption == "Print Booking")
        {
            BookingMethods.PrintBooking(bookings, customers);    
        }
        else if (selectedOption == "Customer Checkin/Out")
        {
            Checkin.CheckInOut(bookings, customers);    
        }
        
    }

    public static void RunReviewMenu(int CustId)
    {
        string[] menuOptions = { "Remove Review", "Print Reviews", "Exit" };
        RunMenu("Review Menu", menuOptions, HandleMenuOptionReview, CustId);
    }

    public static void HandleMenuOptionReview(string selectedOption, int CustId)
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