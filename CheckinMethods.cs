public class Checkin
{
    public void CheckInOut(List<Bookings>bookings, List<Customer>customers)
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
}