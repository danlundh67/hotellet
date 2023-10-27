using System.Data;

public class ReviewMethods
{
    public static void AddReview(int custId, List<CustomerReview> listReviews)
    {
        int reviewIndex = listReviews.FindIndex(y => y.customerid == custId);
        string alias;
        if (reviewIndex == -1)
        {
            Console.WriteLine("State you alias for the review:");
            alias = Console.ReadLine()+"";
        }
        else 
        {
            alias = listReviews[reviewIndex].aliasCustomer;
        }
        System.Console.WriteLine("State the date for your visit:");
        DateOnly dateOut = DateOnly.Parse(""+ Console.ReadLine());
        System.Console.Write("Please state your rating for the visit (Lousy, Poor, Moderate, Fair or Excellent: ");
        if (Enum.TryParse(typeof(Ratings), Console.ReadLine(), out object tempRateObj))
        {
            if (tempRateObj is Ratings) // Check if the parsed value is of the Diffbeds enum type.
            {
                Ratings tempRating = (Ratings)tempRateObj;
                System.Console.WriteLine("State a short comment, reason for rating/high ligths: \nor anything that other customers might value.");
                string freetext = "" + Console.ReadLine();
                CustomerReview myreview = new CustomerReview(alias, dateOut, freetext, tempRating, custId);
                listReviews.Add(myreview);
            }
            else
            {
                System.Console.WriteLine("Invalid rating, review not added.");
            }
        }
        

    }

    static void RemoveReview()
    {

    }

    static void Sortreview(List<CustomerReview> originalList)
    {
        originalList = SortByRating(originalList);
    }

    public static List<CustomerReview> SortByRating(List<CustomerReview> originalList)
    {
        return originalList.OrderBy(x => x.rating).ToList();
    }

    public static void PrintReviews(List<CustomerReview> listReviews)
    {
        int sum = 0;
        List<CustomerReview> sortReviews = new List<CustomerReview>();
        sortReviews = SortByRating(listReviews);
        sortReviews.Reverse();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("             Hotel reviews");
         Console.WriteLine("---------------------------------------------------");
        foreach (CustomerReview a in sortReviews)
        {
            Console.WriteLine($" {a.aliasCustomer} {a.datereview} ");
            Console.WriteLine($" Ratting: {a.rating}");
            Console.WriteLine($" {a.freeText}");
            Console.WriteLine("---------------------------------------------------");
            sum += (int)a.rating;
        }
        float avg = (float)sum/listReviews.Count();
        Console.WriteLine($"Average rating {avg}");

    }

    
}