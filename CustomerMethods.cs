using System.Data;

public class CustomerMethods
{

    // Add a new Customer
    // Read the Customer data and add the customer to the list of customers
    static public void AddCustomer(List<Customer> customers)
    {
        
        int custId;
        if (customers.Count() < 1)
        {
            custId=1;
        }
        else
        {
            custId=customers[customers.Count() -1].customerid +1;
        }
        
        Console.Write("State Forename: ");
        string fname = Console.ReadLine() + "";
        Console.Write("State Lastname: ");
        string lname = Console.ReadLine() + "";
        Console.Write("State social security Id: ");
        String sID = Console.ReadLine() + "";
        Console.Write("State the customer adress: ");
        string adress = Console.ReadLine() + "";
        Console.Write("State the customer E-mail: ");
        string epost = Console.ReadLine() + "";
        Console.Write("State the customer phone number: ");
        string phone = Console.ReadLine() + "";
        
        Customer newcustomer = new Customer(custId,fname, lname, sID, adress,epost, phone);
        customers.Add(newcustomer);

    }

    // Removes an existing Customer from the list
    static public void RemoveCustomer(List<Customer> customers)
    {
        // Remove a customer from the list of Customers
        Console.Write("State the Customer id for the customer to be removed: ");
        int.TryParse(Console.ReadLine() +"", out int custId);
        customers.RemoveAt(customers.FindIndex(y => y.customerid == custId));
    }

    //  Finds a Customer (using lamda search) and prints out Customer info
    static public void FindCustomer(List<Customer> customers)
    {
        Console.Write("State the Customer id for the customer you want to view: ");
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

    // Stepwise seach for finding a specific customer

    public static int FindMyId(List<Customer> customers)
    {
        List<Customer> myCust = new List<Customer>();
        Console.Write("State the lastname: ");
        string lname = Console.ReadLine() + "";
        myCust = customers.Where(x => x.lastname == lname).ToList();
        PrintCustomer(myCust);
        if (myCust.Count()== 1)
        {
            return myCust[0].customerid;
        }
        else 
        {
            Console.Write("State email: ");
            string email = Console.ReadLine() + "";
            myCust = myCust.Where(x => x.email == email).ToList();
            PrintCustomer(myCust);
            if (myCust.Count() == 1)
            {
                return myCust[0].customerid;
            }
            else{
                Console.Write("State email: ");
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

    // Search Customer for a specific customer id
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

    // prints out All Customers and their information
    static public void PrintCustomer(List<Customer> customers)
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("               Customers");
        Console.WriteLine("------------------------------------------------");
        foreach( Customer a in customers)
        {
            Console.Write($" Customer Id {a.customerid} \n");
            Console.Write($" Customer name {a.forename} {a.lastname} \n");
            Console.Write($" Customer adress {a.adress} \n");
            Console.Write($" Customer phone {a.phone} \n");
            Console.WriteLine($" Customer email: {a.email}");
            Console.WriteLine("------------------------------------------------");
        }
    }

    // Method for a Customer to add themself to Customers
    static public Customer CustomerMakeCustomer(List<Customer> customers)
    {
        
        int custId;
        if (customers.Count() < 1)
        {
            custId=1;
        }
        else
        {
            custId=customers[customers.Count() -1].customerid +1;
        }
        
        Console.Write("Please enter your Forename: ");
        string fname = Console.ReadLine() + "";
        Console.Write("Please enter your Lastname: ");
        string lname = Console.ReadLine() + "";
        Console.Write("Please enter your social security Id: ");
        String sID = Console.ReadLine() + "";
        Console.Write("Please enter your home adress: ");
        string adress = Console.ReadLine() + "";
        Console.Write("Please enter your customer E-mail: ");
        string epost = Console.ReadLine() + "";
        Console.Write("Please enter your phone number: ");
        string phone = Console.ReadLine() + "";
        
        Customer newcustomer = new Customer(custId,fname, lname, sID, adress,epost, phone);
        customers.Add(newcustomer);
        return newcustomer;

    }

}

