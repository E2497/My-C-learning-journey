class Program
{  
    static void Main(string[] args)
    {
    String[] Options = { "Hi", "Welcome", "Exit" };

    MovingThrouhgMenu(Options);

    }

    static void ShowValueToUser(int option, String [] Options)

    {
        Console.Clear();
        int posX = 5;
        int posY = 5;
        
        Console.CursorVisible = false;

        for (int i = 0; i < Options.Length; i++)
        {
            Console.SetCursorPosition(posX, posY);
            if (option == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(Options[i]);
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine(Options[i]);
            }
            posY++;
            Console.ResetColor();
        }
    }
    static void MovingThrouhgMenu(string [] Options)
    {
        bool selected = false;
        int option = 0;
               
        while (selected == false)
        {
            ShowValueToUser(option, Options);
            var key = Console.ReadKey();
            
            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option++;
                    if (option > 2)
                    {
                        option = 0;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    
                    option--;
                    
                    if (option < 0)
                    {
                        option = 2;

                    }
                    
                    break;

                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine(Options[option]);
                    selected = true;

                    break;
            }


        }

       

    }
  
}






