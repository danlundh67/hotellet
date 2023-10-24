class Room
{
    

     public int RoomNr {get; set;}
     public int NrOfBeds {get; set;}
     public bool Hcp {get; set;}
     public bool SilentRoom {get; set;}
     public bool FamilyRoom {get; set;}
     public Diffbeds Diffbeds {get; set;}

     public Room (int roomNr, int nrOfBeds, bool hcp, bool silentRoom, bool familyRoom, Diffbeds diffbeds)
     {
        this.RoomNr = roomNr;
        this.NrOfBeds = nrOfBeds;
        this.Hcp = hcp;
        this.SilentRoom = silentRoom;
        this.FamilyRoom = familyRoom;
        this.Diffbeds = diffbeds;
     }
}
enum Diffbeds
    {
        Kingsize,
        Queensize,
        Single,
        Double,
        Sofabed,
        Cribs,
    }