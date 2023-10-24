namespace hotellet;

class Program
{
    public static List<Room> roomslist = new List<Room>();
    
    static void Main(string[] args)
    {
        Room room = new Room(101, 2, false, true, true, Diffbeds.Kingsize);
        roomslist.Add(room);
        room = new Room(102, 1, true, true, false, Diffbeds.Single);
        roomslist.Add(room);
        
        RoomMethods.PrintRooms(roomslist);
        RoomMethods.RemoveRoom(roomslist);
        RoomMethods.PrintRooms(roomslist);

        
    }
}
