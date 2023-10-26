public class TestMethods
{

    public static void TestMethod(List<Customer> customers, List<Room>roomslist,List<Bookings>bookings, List<CustomerReview>reviewlist)
    {

        Room room = new Room(101, 2, false, true, true, Diffbeds.Kingsize);
        roomslist.Add(room);
        room = new Room(102, 1, true, true, false, Diffbeds.Single);
        roomslist.Add(room);

        Customer mycust = new Customer(1,"Anders","Andersson", "19700304-1345","Storgatan 42, 43431 Kungsbacka","anders@hotmail.com","034-121121");
        customers.Add(mycust);
        mycust = new Customer(2,"Eva","Ericsson", "19890517-1345","Bagarevägen 2 42, 54120 Moholm","eva.ericsson@gmail.com","0501-317823");
        customers.Add(mycust);
        Room room1 = new Room(101, 2, false, true, true, Diffbeds.Kingsize);
        List<Room> customerRooms = new List<Room>();
        customerRooms.Add(room1);
        DateOnly date1 = new DateOnly (2001,01,01);
        DateOnly date2 = new DateOnly (2001,01,05);
        Bookings booktest1 = new Bookings(100, date1, date2, 1, false, "20333541",customerRooms );
        bookings.Add(booktest1);
        DateOnly date3 = new DateOnly (2001,01,08);
        DateOnly date4 = new DateOnly (2001,01,12);
        booktest1 = new Bookings(101, date3, date4, 1, false, "74554541",customerRooms );
        bookings.Add(booktest1);
        CustomerReview myreview = new CustomerReview("Missnöjd", date3, "Uruselt hotel, personalen sjöng hela tiden.", Ratings.Lousy, 1);
        reviewlist.Add(myreview);

        
    }
}