public class CustomerReview {

    string aliasCustomer;
    DateOnly datereview;

    string freeText;

    int rating;

    public CustomerReview(string alias, DateOnly date, string text, int rate)
    {
        aliasCustomer=alias;
        datereview=date;
        freeText=text;
        rating = rate;
    }

}

