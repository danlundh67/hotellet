public class BookingMethods
{
public static void AvailableRooms(List<Room>rooms,List<Bookings>bookings)
{
    
    Console.WriteLine("State the in date");
    DateOnly CustIn = DateOnly.Parse(""+ Console.ReadLine());
    Console.WriteLine("State the out date");
    DateOnly CustOut = DateOnly.Parse(""+ Console.ReadLine());
    foreach (Room a in rooms)
    {
        Console.Write($"|Room number: {a.RoomNr} | Number of beds: {a.NrOfBeds}|");
        if(FindBooking(bookings, a.RoomNr, CustIn, CustOut))
        {
            Console.WriteLine(" Available!");
        }
        else
        {
            Console.WriteLine(" Booked!");
        }
    }
    

}
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
    System.Console.WriteLine("Add customer");
    int custId = int.Parse(""+ Console.ReadLine());
    System.Console.WriteLine("Add first date");
    DateOnly dateIn = DateOnly.Parse(""+ Console.ReadLine());
    System.Console.WriteLine("Add last date");
    DateOnly dateOut = DateOnly.Parse(""+ Console.ReadLine());
    System.Console.Write("checked in (Yes/No) ?");
    bool tempChecked = Console.ReadLine().ToLower().Equals("yes");
    System.Console.WriteLine("Creditcard number");
    string creditC = Console.ReadLine();

    Room room = new Room(101, 2, false, true, true, Diffbeds.Kingsize);
    customerrooms.Add(room);
    Bookings bookings1 = new Bookings(bookId, dateIn, dateOut, custId, tempChecked, creditC, customerrooms);
    bookings.Add(bookings1);


    
}
static void RemoveBooking(List<Bookings>bookings)
{

}
public static bool FindBooking(List<Bookings>bookings, int RoomNr, DateOnly CustIn, DateOnly CustOut)
{
   
    bool available = true;
    foreach (Bookings a in bookings)
    {
        
        foreach (Room r in a.Bookedrooms)
        {
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
static void SortBooking(List<Bookings>bookings)
{

}
public static void PrintBooking(List<Bookings>bookings, List<Customer>customers)
{
    foreach (Bookings b in bookings)
    {
        string checkedInOut = b.CheckedInOut ? "Yes" : "No";
        Console.WriteLine($"Booking ID: {b.BookingId}| ");
        CustomerMethods.FindCustomer(customers, b.customerid);
        Console.WriteLine($"Date to check in: {b.DateIn}");
        Console.WriteLine($"Date to check out : {b.DateOut}");
        Console.WriteLine($"Customer Checked in ?: {checkedInOut}");
        
        foreach(Room c in b.Bookedrooms)
        {
            Console.WriteLine($"Number of beds: {c.NrOfBeds}");
        }
        Console.WriteLine($"Booked rooms: {b.Bookedrooms.Count()}");

    }
}
}

