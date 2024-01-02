namespace BlazorServerApp.Data;

public class Service
{
    
    public static List<Bookings> bookings {get; set;} = new List<Bookings>();
    public static List<Room> rooms {get; set;} = new List<Room>();
    public static List<Customer> customers {get; set;} = new List<Customer>();
    public static List<CustomerReview> reviewlist {get; set;} = new List<CustomerReview>();

    //Customer mycust = new Customer(1,"Anders","Andersson", "19700304-1345","Storgatan 42, 43431 Kungsbacka","anders@hotmail.com","034-121121");
}

