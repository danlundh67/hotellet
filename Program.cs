namespace hotellet;

class Program
{
    public static List<Room> roomslist = new List<Room>();
    public static List<Customer> customers = new List<Customer>();
    
    static void Main(string[] args)
    {
        TestMethods.TestMethod(customers, roomslist);
        
        
        RoomMethods.AddRoom(roomslist);
        RoomMethods.PrintRooms(roomslist);



    }
}
