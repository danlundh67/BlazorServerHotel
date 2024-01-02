namespace BlazorServerApp.Data;
public class Bookings
{
    
    public int BookingId {set; get;}
    public DateOnly DateIn {set; get;}
    public DateOnly DateOut {set; get;}
    public bool CheckedInOut {set; get;}
    private string CreditCardNr {set; get;}
    public List<Room> Bookedrooms {set; get;}
    public int Customerid {set; get;}
    
    public Bookings (int bookingId, DateOnly dateIn, DateOnly dateOut, int customerid, bool checkedInOut, string creditCardNr, List<Room>bookedrooms) 
    {
        BookingId = bookingId;
        DateIn = dateIn;
        DateOut = dateOut;
        CheckedInOut = checkedInOut;
        CreditCardNr = creditCardNr;
        Bookedrooms = bookedrooms;
        this.Customerid = customerid;
        

    }
}