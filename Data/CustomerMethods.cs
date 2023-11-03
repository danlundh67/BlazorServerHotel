namespace BlazorServerApp.Data;
class CustomerMethods
{
    static public void AddCustomer(List<Customer> customers)
    {
        // Read the Customer data and add the customer to the list of customers
        int custId;
        if (customers.Count() < 1)
        {
            custId=1;
        }
        else
        {
            custId=customers[customers.Count() -1].customerid +1;
        }
        
        Console.WriteLine("State Forename");
        string fname = Console.ReadLine() + "";
        Console.WriteLine("State Lastname");
        string lname = Console.ReadLine() + "";
        Console.WriteLine("State social security Id");
        String sID = Console.ReadLine() + "";
        Console.WriteLine("State the customer adress");
        string adress = Console.ReadLine() + "";
        Console.WriteLine("State the customer E-mail");
        string epost = Console.ReadLine() + "";
        Console.WriteLine("State the customer phone number");
        string phone = Console.ReadLine() + "";
        
        Customer newcustomer = new Customer(custId,fname, lname, sID, adress,epost, phone);
        customers.Add(newcustomer);

    }

    static public void RemoveCustomer(List<Customer> customers)
    {
        // Remove a customer from the list of Customers
        Console.WriteLine("State the Customer id for the customer to be removed");
        int.TryParse(Console.ReadLine() +"", out int custId);
        customers.RemoveAt(customers.FindIndex(y => y.customerid == custId));
    }

    static public void FindCustomer(List<Customer> customers)
    {
        Console.WriteLine("State the Customer id for the customer you want to view");
        int.TryParse(Console.ReadLine() +"", out int custId);
        int customerIndex = customers.FindIndex(y => y.customerid == custId);
        if (customerIndex == -1)
        {
            Console.WriteLine("Could not find the customer");
        }
        else 
        {
            Customer mycust = customers[customerIndex];
            Console.Write($" Customer Id {mycust.customerid} \n");
            Console.Write($" Customer name {mycust.forename} {mycust.lastname} \n");
            Console.Write($" Customer adress {mycust.adress} \n");
            Console.Write($" Customer phone {mycust.phone} \n");
            Console.WriteLine($" Customer email: {mycust.email}");
        }
    }

    public static int FindMyId(List<Customer> customers)
    {
        List<Customer> myCust = new List<Customer>();
        Console.WriteLine("State the lastname:");
        string lname = Console.ReadLine() + "";
        myCust = customers.Where(x => x.lastname == lname).ToList();
        PrintCustomer(myCust);
        if (myCust.Count()== 1)
        {
            return myCust[0].customerid;
        }
        else 
        {
            Console.WriteLine("State email:");
            string email = Console.ReadLine() + "";
            myCust = myCust.Where(x => x.email == email).ToList();
            PrintCustomer(myCust);
            if (myCust.Count() == 1)
            {
                return myCust[0].customerid;
            }
            else{
                Console.WriteLine("State email:");
                string epost = Console.ReadLine() + "";
                myCust = myCust.Where(x => x.email == epost).ToList();
                PrintCustomer(myCust);
                if (myCust.Count() == 1)
                {
                    return myCust[0].customerid;
                }
                else 
                {
                    return -1;
                }
            }

        }

    }
    static public void FindCustomer(List<Customer> customers, int custId)
    {
        
        int customerIndex = customers.FindIndex(y => y.customerid == custId);
        if (customerIndex == -1)
        {
            Console.WriteLine("Could not find the customer");
        }
        else 
        {
            Customer mycust = customers[customerIndex];
            Console.Write($" - Customer Id: {mycust.customerid} \n");
            Console.Write($" - Customer name: {mycust.forename} {mycust.lastname} \n");
            Console.Write($" - Customer adress: {mycust.adress} \n");
            Console.Write($" - Customer phone: {mycust.phone} \n");
            Console.WriteLine($" - Customer email: {mycust.email}");
        }
    }  

    static public string PrintCustomer(List<Customer> customers)
    {
        String outhtml ="<h1> Customers<h1>";
        outhtml += "------------------------------------------------<br>";
        outhtml += "               Customers<br>";
        outhtml += "------------------------------------------------<br>";
        foreach( Customer a in customers)
        {
            outhtml += $" Customer Id {a.customerid} <br>";
            outhtml += $" Customer name {a.forename} {a.lastname} <br>";
            outhtml += $" Customer adress {a.adress} <br>";
            outhtml += $" Customer phone {a.phone} <br>";
            outhtml += $" Customer email: {a.email} <br>";
            outhtml += "------------------------------------------------<br>";
        }
        return outhtml;
    }
}