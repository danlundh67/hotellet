/*public class Run
{
    public static List<Customer> customers = new List<Customer>();
    public static List<Room> roomslist = new List<Room>();
    public static List<Bookings> bookings = new List<Bookings>();
    public void Start()
    {
        Console.Title = "HMS!";
        MainRun();
    }

    public void MainRun()
    {
        String prompt = @"
         _    _ __  __  _____ _ 
        | |  | |  \/  |/ ____| |
        | |__| | \  / | (___ | |
        |  __  | |\/| |\___ \| |
        | |  | | |  | |____) |_|
        |_|  |_|_|  |_|_____/(_)
                                
        Welcome to The Hotel Management System" ;
        string[] MainMenuoptions = { "Staff", "Customer", "Exit" };
        bool[] MainMenuAction = { false, false, false };
        Menu mainMenu = new Menu(prompt, MainMenuoptions, MainMenuAction );
    
        int selectedIndex;
        do
        {
            
            selectedIndex = mainMenu.Run(true);

            switch (selectedIndex)
            {
                case 0:
                    Staff(customers, roomslist, bookings);
                    break;
                case 1:
                    Customer();
                    break;
                case 2:
                    ExitHms();
                    break;
            }
        } while (selectedIndex != 2); 
        
    }
    private void ExitHms()
    {
        System.Console.WriteLine("    Press any key to exit");
        Console.ReadKey(true);
        Environment.Exit(0);
    }
    private void Staff(List<Customer>customers, List<Room>roomslist, List<Bookings>bookings)
    {
        Console.Clear();
        bool[] staffMenuIsAction = { true, true, true, true}; 
        Menu menu = new Menu("Customer Menu", new string[] { "Staff", "Customer", "Exit" }, staffMenuIsAction);
        int customerMenuResult;
    
        do
        {
        customerMenuResult = menu.StaffMenu(customers, roomslist, bookings );
        } while (customerMenuResult != 6); 
    }
    private void Customer()
    {
        
    }
}*/