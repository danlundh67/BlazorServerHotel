namespace BlazorServerApp.Data;
public class Room
{
     public int RoomNr {set; get;}
     public int NrOfBeds {set; get;}
     public bool Hcp {set; get;}
     public bool SilentRoom {set; get;}
     public bool FamilyRoom {set; get;}
     public Diffbeds Diffbeds {set; get;}
    public Room ()
     {
        RoomNr=100;
        NrOfBeds=1;
        Hcp=false;
        SilentRoom=false;
        FamilyRoom=false;
        Diffbeds=Diffbeds.Single;
     } 
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
public enum Diffbeds
    {
        Kingsize,
        Queensize,
        Single,
        Double,
        Sofabed,
        Cribs,
    }