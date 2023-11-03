namespace BlazorServerApp.Data;
public class Customer
{
    public int customerid {set; get;}
    public string forename {set; get;}
    public string lastname {set; get;}
    private string socialId {set; get;}
    public string adress {set; get;}
    public string email {set; get;}    
    public string phone {set; get;} 
    public Customer()
    {
        customerid = 0; 
        forename = "";
        lastname = "";
        socialId = "";
        adress = "";
        email = "";
        phone = "";
    }

    public Customer(int cId, string fname, string lname, string sId, string adr, string epost, string phonenr)
    {
        customerid = cId;
        forename = fname;
        lastname = lname;
        socialId = sId;
        adress = adr;
        email = epost;
        phone = phonenr;
    }
    public void blabla()
    {}
}

