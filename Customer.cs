public class Customer
{
    public string customerid {set; get;}
    public string forename {set; get;}
    public string lastname {set; get;}
    private int socialId {set; get;}
    public string adress {set; get;}
    public string email {set; get;}    
    public string phone;


    public Customer(string cId, string fname, string lname, int sId, string adr, string epost, string phonenr)
    {
        customerid = cId;
        forename = fname;
        lastname = lname;
        socialId = sId;
        adress = adr;
        email = epost;
        phone = phonenr;
    }
}