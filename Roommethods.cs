class RoomMethods
{

    
    static void AddRoom(List<Room>rooms)
    {

    }
    public static void RemoveRoom(List<Room>rooms)
    {
        Console.WriteLine("Active rooms");
        for (int i = 0; i < rooms.Count; i++)
        {
            Console.WriteLine($"{i+1}. Room number: {rooms[i].RoomNr}"); //Print list with index number.
            System.Console.WriteLine("------------------------------------");
        }
        Console.Write("Choose the room that you want to remove: "); 
        int removeARoom = int.Parse("" + Console.ReadLine()) - 1; // Read the user's input as a string and convert it to an int.
        if (removeARoom >= 0 && removeARoom < rooms.Count)
        {
            int removedRoom = rooms[removeARoom].RoomNr;  // store the room number of the removed room.
            rooms.RemoveAt(removeARoom); // Remove the selected room from the list.
            Console.WriteLine($" {removedRoom} has been removed");
        }

    }
    static void FindRoom(List<Room>rooms)
    {

    }
    static void AvailableRooms(List<Room>rooms/*, List<Bookings>bookings*/)
    {

    }
    public static void PrintRooms(List<Room>rooms)
    {
        for (int i = 0; i < rooms.Count; i++)
        {   //Ternery operator that puts true/false to Yes/No instead
            string hcpRoom = rooms[i].Hcp ? "Yes" : "No";
            string silentR = rooms[i].SilentRoom ? "Yes" : "No";
            string familyR = rooms[i].FamilyRoom ? "Yes" : "No";
            Console.WriteLine($"{i+1} - Room number: {rooms[i].RoomNr} ");
            System.Console.WriteLine($"  - Nr of beds: {rooms[i].NrOfBeds} ");
            System.Console.WriteLine($"  - Hcp accessible: {hcpRoom} ");
            System.Console.WriteLine($"  - Silent room: {silentR} ");
            System.Console.WriteLine($"  - Family room: {familyR} ");
            System.Console.WriteLine($"  - Type of bed: {rooms[i].Diffbeds} ");
            System.Console.WriteLine("-------------------------------------");
        }
    }
}