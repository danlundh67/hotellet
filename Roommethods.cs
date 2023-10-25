class RoomMethods
{

    
    public static void AddRoom(List<Room>rooms)
    {   
        //skriv ut rum som finns!
        System.Console.WriteLine("Please state the room number that you want to add");
        int tempRoomNr = int.Parse(""+ Console.ReadLine());
        System.Console.WriteLine("Please state the number of beds that you want to add");
        int tempNrBeds = int.Parse(""+ Console.ReadLine());
        System.Console.WriteLine("Please state if you the room has handicap accesability (Yes/No)");
        bool tempHcp = Console.ReadLine().ToLower().Equals("yes");
        System.Console.WriteLine("Please state if you the room is silent (Yes/No)");
        bool tempSilent = Console.ReadLine().ToLower().Equals("yes");
        System.Console.WriteLine("Please state if you the room is a family room (Yes/No)");
        bool tempFamily = Console.ReadLine().ToLower().Equals("yes");
        System.Console.WriteLine("Please state bed model (Kingsize, Queensize, Single, Double, Sofabed or Cribs)");
        if (Enum.TryParse(typeof(Diffbeds), Console.ReadLine(), out object tempBedObj))
        {
            if (tempBedObj is Diffbeds)
            {
            Diffbeds tempBed = (Diffbeds)tempBedObj;
            Room addRoom = new Room(tempRoomNr, tempNrBeds, tempHcp, tempSilent, tempFamily, tempBed);
            rooms.Add(addRoom);
            }
            else
            {
            System.Console.WriteLine("Invalid bed model. The room was not added.");
            }
        }
        else
        {
        System.Console.WriteLine("Invalid bed model. The room was not added.");
        }

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