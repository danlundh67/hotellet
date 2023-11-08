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
        
        //Menu menu = new Menu();
        //Run run = new Run();

        //run.Start();
        Menu.RunStartMenu();



    }
    

    
}

    









