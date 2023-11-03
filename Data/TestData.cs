namespace BlazorServerApp.Data;
class TestData
{
    public static string AddTest()
    {
        string output="";
        Customer mycust = new Customer(1,"Anders","Andersson", "19700304-1345","Storgatan 42, 43431 Kungsbacka","anders@hotmail.com","034-121121");
        Service.customers.Add(mycust);
        mycust = new Customer(2,"Eva","Ericsson", "19890517-1345","BagarevÃ¤gen 2 42, 54120 Moholm","eva.ericsson@gmail.com","0501-317823");
        Service.customers.Add(mycust);
        return output;
    }

}