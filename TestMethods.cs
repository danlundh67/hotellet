public class TestMethods
{

    public static void TestMethod(List<Customer> customers, List<Room>roomslist)
    {

        Room room = new Room(101, 2, false, true, true, Diffbeds.Kingsize);
        roomslist.Add(room);
        room = new Room(102, 1, true, true, false, Diffbeds.Single);
        roomslist.Add(room);

        Customer mycust = new Customer(1,"Anders","Andersson", "19700304-1345","Storgatan 42, 43431 Kungsbacka","anders@hotmail.com","034-121121");
        customers.Add(mycust);
        mycust = new Customer(2,"Eva","Ericsson", "19890517-1345","Bagarevägen 2 42, 54120 Moholm","eva.ericsson@gmail.com","0501-317823");
        customers.Add(mycust);
    }
}