using System.Reflection;

namespace hotellet;

class Program
{
    public static List<Room> roomslist = new List<Room>();
    public static List<Customer> customers = new List<Customer>();
    public static List<Bookings> bookings = new List<Bookings>();
    
    public static List<CustomerReview> reviewlist = new List<CustomerReview>();

    static void Main(string[] args)
    {
        //TestMethods.TestMethod(customers, roomslist, bookings, reviewlist);
        /*
        BookingMethods.AddBooking(bookings, roomslist);
        BookingMethods.PrintBooking(bookings, customers);
        BookingMethods.AvailableRooms(roomslist, bookings);
        ReviewMethods.PrintReviews(reviewlist);
        ReviewMethods.AddReview(2, reviewlist);
        ReviewMethods.PrintReviews(reviewlist);
        ReviewMethods.RemoveReview(CustomerMethods.FindMyId(customers), reviewlist);
        ReviewMethods.PrintReviews(reviewlist);*/
        
        
        //Run run = new Run();

        //run.Start();
        RunStartMenu();



    }
    public static void RunStartMenu()
    {
        string[] menuOptions = { "Staff Menu", "Customer menu", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            Console.Clear(); // Clear the console only when necessary

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

                
                HandleMenuOptionStart(menuOptions[selectedIndex]);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionStart(string selectedOption)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Staff Menu")
        {
            
            RunStaffMenu();
        }
        else if (selectedOption == "Customer Menu")
        {
            
            RoomMethods.RemoveRoom(roomslist);
        }
        
        


    }

    public static void RunStaffMenu()
    {
        string[] menuOptions = { "Room utility", "Customer utility","Booking utility","Review utility", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            Console.Clear(); 

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

                
                HandleMenuOptionStaff(menuOptions[selectedIndex]);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public static void HandleMenuOptionStaff(string selectedOption)
    {
        Console.Clear();
        Console.WriteLine($"You selected: {selectedOption}");
        
        if (selectedOption == "Room utility")
        {
            RunRoomMenu(roomslist);
        }
        else if (selectedOption == "Customer Menu")
        {
            
            
        }
        
        


    }

     public static void RunRoomMenu(List<Room>rooms)
    {
        string[] menuOptions = { "Add Room", "Remove Room","Find Room","Print Room", "Exit" };
        int selectedIndex = 0;

        while (true)
        {
            Console.Clear(); 

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

    
}

    









