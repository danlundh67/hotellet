class RoomMethods
{

    
    public static void AddRoom(List<Room>rooms)
    {   
        //skriv ut rum som finns tillängliga alaileblerooms metod!
        System.Console.Write("Please state the room number that you want to add: ");
        int tempRoomNr = int.Parse(""+ Console.ReadLine());
        System.Console.Write("Please state the number of beds that you want to add: ");
        int tempNrBeds = int.Parse(""+ Console.ReadLine());
        System.Console.Write("Please state if you the room has handicap accesability (Yes/No): ");
        bool tempHcp = Console.ReadLine().ToLower().Equals("yes"); //if the input yes/yes the bool is set to true. Otherwise its False
        System.Console.Write("Please state if you the room is silent (Yes/No): ");
        bool tempSilent = Console.ReadLine().ToLower().Equals("yes");
        System.Console.Write("Please state if you the room is a family room (Yes/No): ");
        bool tempFamily = Console.ReadLine().ToLower().Equals("yes");
        System.Console.Write("Please state bed model (Kingsize, Queensize, Single, Double, Sofabed or Cribs): ");
        if (Enum.TryParse(typeof(Diffbeds), Console.ReadLine(), out object tempBedObj)) // Ask the user for the bed model (Kingsize, Queensize....) and attempt to convert it to an Enum value
        {
            if (tempBedObj is Diffbeds) // Check if the parsed value is of the Diffbeds enum type.
            {
            Diffbeds tempBed = (Diffbeds)tempBedObj;// Cast the object to Diffbeds and create a new Room object with the collected information.
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
    public static void FindRoom(List<Room>rooms)
    {
        Console.Write("State the room number of the room you want to view: ");
        int.TryParse(Console.ReadLine() +"", out int roomNr);
        int roomIndex = rooms.FindIndex(y => y.RoomNr == roomNr); // Find the index of the room in the list that matches the provided room number.
        if (roomIndex == -1)
        {
            Console.WriteLine("Could not find the room");
        }
        else 
        {
            // Get the room object at the found index.
            Room myroom = rooms[roomIndex];
            string hcpRoom = myroom.Hcp ? "Yes" : "No"; 
            string silentR = myroom.SilentRoom ? "Yes" : "No";
            string familyR = myroom.FamilyRoom ? "Yes" : "No";
            Console.WriteLine($" - Room number {myroom.RoomNr} ");
            Console.WriteLine($" - Number of beds {myroom.NrOfBeds} ");
            Console.WriteLine($" - Handicap accessible {hcpRoom} ");
            Console.WriteLine($" - Silent room {silentR} ");
            Console.WriteLine($" - Family room: {familyR}");
            Console.WriteLine($" - Bed model: {myroom.Diffbeds}");
            Console.WriteLine("-------------------------------------");

        }
    }
    
    public static void PrintRooms(List<Room>rooms)
    {
        for (int i = 0; i < rooms.Count; i++)
        {   // Use a ternary operator to display "Yes" or "No" instead of true/false for certain properties.
            // If rooms[i].Hcp is true, set hcpRoom to "Yes"; otherwise, set it to "No".
            string hcpRoom = rooms[i].Hcp ? "Yes" : "No";
            string silentR = rooms[i].SilentRoom ? "Yes" : "No";
            string familyR = rooms[i].FamilyRoom ? "Yes" : "No";
            Console.WriteLine($"{i+1} - Room number: {rooms[i].RoomNr} ");
            Console.WriteLine($"  - Nr of beds: {rooms[i].NrOfBeds} ");
            Console.WriteLine($"  - Hcp accessible: {hcpRoom} ");
            Console.WriteLine($"  - Silent room: {silentR} ");
            Console.WriteLine($"  - Family room: {familyR} ");
            Console.WriteLine($"  - Type of bed: {rooms[i].Diffbeds} ");
            Console.WriteLine("-------------------------------------");
        }
    }
}