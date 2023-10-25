public class BookingMethods
{
static void AvailableRooms(List<Room>rooms,List<Bookings>bookings)
{

}
public static void AddBooking(List<Bookings>bookings, List<Room>rooms)
{
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
    bookings.Add("259090", dateIn, dateOut, custId, tempChecked, creditC, customerrooms);


    
}
static void RemoveBooking(List<Bookings>bookings)
{

}
static void FindBooking(List<Bookings>bookings)
{

}
static void SortBooking(List<Bookings>bookings)
{

}
static void PrintBooking(List<Bookings>bookings)
{
    foreach (Bookings b in bookings)
    {
        string checkedInOut = b.CheckedInOut ? "Yes" : "No";
        Console.WriteLine($"Booking ID: {b.BookingId}| First name: {b.forename}| Last name: {b.lastname}");
        Console.WriteLine($"Home adress: {b.adress}| Phone number: {b.phone}| Email: {b.email}");
        Console.WriteLine($"Date to check in: {b.DateIn}");
        Console.WriteLine($"Date to check out : {b.DateOut}");
        Console.WriteLine($"Customer Checked in ?: {checkedInOut}");
        
        foreach(Room c in b.Bookedrooms)
        {
            Console.WriteLine($"{c.NrOfBeds}");
        }
        Console.WriteLine($"Booked rooms: {b.Bookedrooms.Count()}");

    }
}
}