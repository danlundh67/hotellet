namespace hotellet;

class Program
{
    public static List<Room> roomslist = new List<Room>();
    public static List<Customer> customers = new List<Customer>();
    public static List<Bookings> bookings = new List<Bookings>();
    
    static void Main(string[] args)
    {
        TestMethods.TestMethod(customers, roomslist, bookings);
        //BookingMethods.AddBooking(bookings, roomslist);
        //BookingMethods.PrintBooking(bookings, customers);
        BookingMethods.AvailableRooms(roomslist, bookings);

        



    }
}
