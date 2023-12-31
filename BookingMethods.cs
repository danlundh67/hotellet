public class BookingMethods
{

    // Asks the user for input start and end dates.
    // Iterates through a list of rooms and checks if each room is available between the specified dates 
    // by calling the FindBooking method.
    // Prints whether each room is available or booked.
    public static void AvailableRooms(List<Room>rooms,List<Bookings>bookings)
    {
        
        Console.Write("State the in date: ");
        DateOnly CustIn = DateOnly.Parse(""+ Console.ReadLine());
        Console.Write("State the out date: ");
        DateOnly CustOut = DateOnly.Parse(""+ Console.ReadLine());
        foreach (Room a in rooms)
        {
            Console.Write($"|Room number: {a.RoomNr} | Number of beds: {a.NrOfBeds}| ");
            if(FindAvailableRoom(bookings, a.RoomNr, CustIn, CustOut)) // Check if the room is available during the specified dates
            {
                Console.WriteLine(" Available!");
            }
            else
            {
                Console.WriteLine(" Booked!");
            }
        }
        

    }

    // Takes a list of rooms, a list of bookings, and start and end dates as parameters.
    // Returns a list of rooms that are available between the specified dates.
    public static List<Room> ListAvailableRooms(List<Room>rooms,List<Bookings>bookings, DateOnly CustIn, DateOnly CustOut)
    {
        List<Room> availableRooms = new List<Room>();
        
        foreach (Room a in rooms)
        {
            if(FindAvailableRoom(bookings, a.RoomNr, CustIn, CustOut)) // Check if the room is available during the specified dates
            {
                Room availroom = RoomMethods.GetRooms(rooms,a.RoomNr);
                availableRooms.Add(availroom);
            }
            else
            {
                
            }
        }
        return availableRooms;

    }
    // Adds a booking by the staff.
    // Generates a booking ID, takes customer details, dates, and credit card information.
    // Lists available rooms during the specified dates.
    // Asks the staff to select rooms for the booking and adds those rooms to the booking.
    public static void AddBooking(List<Bookings>bookings, List<Room>rooms)
    {
        int bookId;
            if (bookings.Count() < 1)
            {
                bookId=100;
            }
            else
            {
                bookId=bookings[bookings.Count() -1].BookingId +1;
            }
        List<Room> customerrooms = new List<Room>();
        List<Room> availrooms = new List<Room>();
        string aroom="";
        System.Console.Write("Add customer: ");
        int custId = int.Parse(""+ Console.ReadLine());
        System.Console.Write("Add first date: ");
        DateOnly dateIn = DateOnly.Parse(""+ Console.ReadLine());
        System.Console.Write("Add last date: ");
        DateOnly dateOut = DateOnly.Parse(""+ Console.ReadLine());
        System.Console.Write("checked in (Yes/No) ?: ");
        bool tempChecked = Console.ReadLine().ToLower().Equals("yes");
        System.Console.Write("Creditcard number: ");
        string creditC = Console.ReadLine();

        Console.WriteLine("------- Available Rooms -------");
        availrooms = ListAvailableRooms(rooms, bookings, dateIn, dateOut);
        if (availrooms.Count()<1)
        {
            Console.WriteLine("No rooms are available between these dates");
        }
        else
        {
            foreach (Room a in availrooms)
            {
                Console.WriteLine($"|Room number: {a.RoomNr} | Number of beds: {a.NrOfBeds} | Type of bed: {a.Diffbeds} | Family Room: {a.FamilyRoom} | Hcp accessible: {a.Hcp} | Silent room: {a.SilentRoom}| ");
            }
        }
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("State the room numbers to include in the booking (q = quit): ");
        aroom=Console.ReadLine()+"";
        // Adds rooms to a booking.
        while (aroom !="q")
        {
            while (availrooms.FindIndex(y => y.RoomNr == int.Parse(aroom)) == -1)
            {
                Console.WriteLine("Wrong room number state again ");
                aroom=Console.ReadLine()+"";
            }
            Room addedroom = RoomMethods.GetRooms(rooms,int.Parse(aroom));
            customerrooms.Add(addedroom);
            Console.WriteLine("Add another room to this booking?, state a room number or q to quit ");
            aroom=Console.ReadLine()+"";
        }
        
    
        if (customerrooms.Count()>0)
        {
            Bookings bookings1 = new Bookings(bookId, dateIn, dateOut, custId, tempChecked, creditC, customerrooms);
            bookings.Add(bookings1);
        }

        
    }
    //Lists active bookings and asks the staff to choose a booking to remove.
    public static void RemoveBooking(List<Bookings>bookings, List<Customer>customers)
    {
        Console.WriteLine("Active bookings");
        for (int i = 0; i < bookings.Count; i++)
        {
            Customer customer = customers.FirstOrDefault(cust => cust.customerid == bookings[i].Customerid)!; // Find the customer associated with the booking using customerid

            if (customer != null)
            {
                Console.WriteLine($"{i + 1}. Booking ID: {bookings[i].BookingId} | Customer: {customer.forename} {customer.lastname}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. Booking ID: {bookings[i].BookingId} | Customer not found");
            }

            Console.WriteLine("------------------------------------");
        }
        Console.Write("Choose the booking that you want to remove: "); 
        int removeABooking = int.Parse("" + Console.ReadLine()) - 1; // Read the user's input as a string and convert it to an int.
        if (removeABooking >= 0 && removeABooking < bookings.Count)
        {
            bookings.RemoveAt(removeABooking); // Remove the selected booking from the list.
            Console.WriteLine($"The selected booking has been removed");
        }
    }
    
    // Checks if a room is available between input dates and check in dates.
    // Returns true if the room is available; otherwise, returns false.
    
    public static bool FindAvailableRoom(List<Bookings>bookings, int RoomNr, DateOnly CustIn, DateOnly CustOut)
    {
    
        bool available = true;
        foreach (Bookings a in bookings) // iterate list of bookings
        {
            
            foreach (Room r in a.Bookedrooms) // iterates list of booked rooms in bookings list.
            {   
                // Checks if a room is in a booking between input dates from AvailableRooms method.
                if (r.RoomNr == RoomNr) 
                {
                    if (CustIn < a.DateOut && CustOut > a.DateIn)
                    {  
                        if (CustOut < a.DateIn && CustIn < a.DateIn)
                        {

                        }
                        else 
                        {   available = false;
                            
                        }
                    }
                }
            }
        }
        return available;
            
    }
    // Sorts the list of bookings in ascending order with the first check in date at the top.
    public static List<Bookings> SortBooking(List<Bookings>bookings)
    {
        return bookings.OrderBy(x => x.DateIn).ToList();
    }
    
    //Prints details of all bookings in a sorted order.
    public static void PrintBooking(List<Bookings>bookings, List<Customer>customers)
    {
        List<Bookings> sortBookings = new List<Bookings>();
        sortBookings = SortBooking(bookings);
        foreach (Bookings b in sortBookings)
        {
            string checkedInOut = b.CheckedInOut ? "Yes" : "No";
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  Booking ID: {b.BookingId}  |");
            Console.WriteLine("------------------------");
            CustomerMethods.FindCustomer(customers, b.Customerid);
            Console.WriteLine($" -> Date to check in: {b.DateIn}");
            Console.WriteLine($" <- Date to check out: {b.DateOut}");
            Console.WriteLine($" - Customer Checked in ?: {checkedInOut}");
            
            foreach(Room c in b.Bookedrooms)
            {
                Console.WriteLine($" - Number of beds: {c.NrOfBeds}");
            }
            Console.WriteLine($" - Booked rooms: {b.Bookedrooms.Count()}");
            Console.WriteLine("------------------------");

        }
    }
    // Takes input from a customer for check-in date, check-out date, and credit card number.
    // Lists available rooms during the specified dates.
    // Asks the customer to select rooms for the booking and adds those rooms to the booking.
    // Creates a booking object and adds it to the list of bookings.
    
    public static void BookARoom(List<Bookings>bookings, List<Room>rooms, List<Customer>customers)
    {

        Console.CursorVisible = true;
        Customer customer = CustomerMethods.CustomerMakeCustomer(customers);
        System.Console.WriteLine("----------------------------------------");
        bool tempChecked = false;
        string aroom = "";
        int bookId;
            if (bookings.Count() < 1)
            {
                bookId=100;
            }
            else
            {
                bookId=bookings[bookings.Count() -1].BookingId +1;
            }
        List<Room> customerrooms = new List<Room>();
        List<Room> availrooms = new List<Room>();
        System.Console.Write("Please enter your check-in date: ");
        DateOnly dateIn = DateOnly.Parse(""+ Console.ReadLine());
        System.Console.Write("Please enter your check-out date: ");
        DateOnly dateOut = DateOnly.Parse(""+ Console.ReadLine());
        System.Console.Write("Please enter your Creditcard number: ");
        string creditC = Console.ReadLine() + "";
        System.Console.WriteLine("----------------------------------------");

        Console.WriteLine("------- Available Rooms -------");
        availrooms = ListAvailableRooms(rooms, bookings, dateIn, dateOut);
        if (availrooms.Count()<1)
        {
            Console.WriteLine("No rooms are available between these dates");
        }
        else
        {
            foreach (Room a in availrooms)
            {
                Console.WriteLine($"|Room number: {a.RoomNr} | Number of beds: {a.NrOfBeds} | Type of bed: {a.Diffbeds} | Family Room: {a.FamilyRoom} | Hcp accessible: {a.Hcp} | Silent room: {a.SilentRoom}| ");
            }
        }
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("State the room numbers to include in the booking (q = quit): ");
        aroom=Console.ReadLine()+"";
        // Adds rooms to a booking.
        while (aroom !="q")
        {
            while (availrooms.FindIndex(y => y.RoomNr == int.Parse(aroom)) == -1)
            {
                Console.WriteLine("Wrong room number try again ");
                aroom=Console.ReadLine()+"";
            }
            Room addedroom = RoomMethods.GetRooms(rooms,int.Parse(aroom));
            customerrooms.Add(addedroom);
            Console.WriteLine("Add another room to this booking?, state a room number or (q) to quit ");
            aroom=Console.ReadLine()+"";
        }
        
        if (customerrooms.Count()>0)
        {
        int custId = customer.customerid;

        Bookings bookings1 = new Bookings(bookId, dateIn, dateOut, custId, tempChecked, creditC, customerrooms);
        bookings.Add(bookings1);
        }


        
    }
}

