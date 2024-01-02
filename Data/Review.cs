public class CustomerReview {

    public string aliasCustomer {set; get;}
    public DateOnly datereview {set; get;}

    public string freeText {set; get;}

    public Ratings rating {set; get;}

    public int customerid {set; get;}

    public CustomerReview(string alias, DateOnly date, string text, Ratings rate, int cid)
    {
        aliasCustomer=alias;
        datereview=date;
        freeText=text;
        rating = rate;
        customerid = cid;
    }
}

public enum Ratings
{
    Lousy = 1,
    Poor = 2,
    Moderate = 3,
    Fair = 4,
    Excellent = 5
}
