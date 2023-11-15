using System.Security.Cryptography.X509Certificates;

public class Checkin
{

    // Checks In or Out a Customer for a specific booking
    static public void CheckInOut(List<Bookings>bookings, List<Customer>customers)
    {
        List<Bookings> custbook =new List<Bookings>();
        int custid = CustomerMethods.FindMyId(customers);
        string answ="";
        if (custid != -1)
        {
            custbook = bookings.Where(x => x.Customerid == custid).ToList();
            
            if (custbook.Count>0)
            {
                foreach (Bookings a in custbook)
                {
                    if (a.CheckedInOut==false)
                    {
                        Console.WriteLine($"Booking {a.DateIn} to {a.DateOut}, Checkin ([Y]es/[N]o) ");
                        answ=Console.ReadLine()+"";
                        if (answ.ToLower()=="y")
                        {
                            a.CheckedInOut = true;
                            Console.WriteLine($"Customer has checked in");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Booking {a.DateIn} to {a.DateOut}, Checkout ([Y]es/[N]o) ");
                        answ=Console.ReadLine()+"";
                        if (answ.ToLower()=="y")
                        {
                            a.CheckedInOut = false;
                        }

                    }

                }
            }

        }
        else
        {
            Console.WriteLine("Could not find the customer");
        }
    }

    // Print all checked in Customers
    static public void AllCheckedIn(List<Bookings>bookings, List<Customer> customers)
    {
        List<Bookings> custbook =new List<Bookings>();
        custbook = bookings.Where(x => x.CheckedInOut == true).ToList();
        foreach (Bookings a in custbook)
        {
            CustomerMethods.FindCustomer(customers,a.Customerid);
            Console.WriteLine($"Customer checked in {a.DateIn} to {a.DateOut}, number of rooms {a.Bookedrooms.Count()}");
        }
    }
}