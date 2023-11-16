public class Room
{
    

     public int RoomNr {set; get;}
     public int NrOfBeds {set; get;}
     public bool Hcp {set; get;}
     public bool SilentRoom {set; get;}
     public bool FamilyRoom {set; get;}
     public Diffbeds Diffbeds {set; get;}

     public Room (int roomNr, int nrOfBeds, bool hcp, bool silentRoom, bool familyRoom, Diffbeds diffbeds)
     {
        RoomNr = roomNr;
        NrOfBeds = nrOfBeds;
        Hcp = hcp;
        SilentRoom = silentRoom;
        FamilyRoom = familyRoom;
        Diffbeds = diffbeds;
     }
}
public enum Diffbeds
    {
        Kingsize,
        Queensize,
        Single,
        Double,
        Sofabed,
        Cribs,
    }