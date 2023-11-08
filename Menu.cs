using System;
using System.Collections.Generic;
using System.Text;

/*public class Menu 
{
    private int SelectedIndex;
    private string[]? Options;
    private string? Prompt;
    private bool[] Action;

    public Menu (string prompt, string[] options, bool[] action  )
    {
        Prompt = prompt;
        Options = options;
        Action = action;
        SelectedIndex = 0;
    }
    private void DisplayOptions()
    {
        System.Console.WriteLine(Prompt);
        for (int i = 0; i < Options?.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;
            if (i == SelectedIndex)
            {
                prefix = " -> ";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                prefix = "   ";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            System.Console.WriteLine($"{prefix} {currentOption} ");
        } Console.ResetColor();
    }
    public int Run(bool clearScreen)
    {
        ConsoleKey keyPressed;
        do
        {
            if (!Action[SelectedIndex])
            {
                Console.Clear(); 
            }
            
            DisplayOptions();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length -1;
                }

            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0; 
                }
            }

        }while (keyPressed != ConsoleKey.Enter);
        return SelectedIndex;
    }
    /*public int StaffMenu(List<Customer>customers, List<Room>rooms, List<Bookings>bookings)
    {
        bool exitStaffMenu = false;
        do
        {   
            
            Menu StaffMenu = new Menu("Staff Menu", new string[] { "Room Menu", "Exit" }, new bool[] { false, false });
            int selectedIndex = StaffMenu.Run(true);

            switch (selectedIndex)
            {
                case 0:
                    StaffMenu.RoomMenu(customers, rooms, bookings);
                    break;
                case 1:
                    Run run = new Run();
                    run.MainRun();
                    exitStaffMenu = true;
                    break;
               

            }
        } while (!exitStaffMenu);
        return SelectedIndex;
        
    }
    public int RoomMenu(List<Customer>customers, List<Room>rooms, List<Bookings>bookings)
    {
        bool exitStaffMenu = false;
        do
        {   
            bool[] RoomMenuIsAction = { false, false, true, true, false };
            Menu RoomMenu = new Menu("Room Menu", new string[] { "Add Room", "Remove Room", "Find Room", "Print Room", "Exit"}, RoomMenuIsAction);
            int selectedIndex = RoomMenu.Run(true);

            switch (selectedIndex)
            {
                case 0:
                    RoomMethods.AddRoom(rooms);
                    break;
                case 1:
                    RoomMethods.RemoveRoom(rooms);
                    break;
                case 2:
                    RoomMethods.FindRoom(rooms);
                    break;
                case 3:
                    RoomMethods.PrintRooms(rooms);
                    break;
                case 4:
                    RoomMenu.StaffMenu(customers, rooms, bookings);
                    exitStaffMenu = true;
                    break;
                   
            }
        } while (!exitStaffMenu);
        return SelectedIndex;
        
    }
}*/
