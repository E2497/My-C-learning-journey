class Program
{

    static void Main(string[] args)
    {
        Console.SetCursorPosition(20, 10);
        string[] arr = new string[20];
        int index=20;
       //rr[0]="5";
        for (int i = 0; i < arr.Length; i++)
        {
            Console.BackgroundColor = ConsoleColor.Red;
;           if (arr[i] == null) {
            Console.Write(" ");

            }
           
        }
        Console.SetCursorPosition(20, 10);
        bool x = true;
        while (x) {

            Console.ResetColor();
            Console.SetCursorPosition(index, 10);

            ConsoleKeyInfo KeyCheck = Console.ReadKey(true);
            switch (KeyCheck.Key) {

                case ConsoleKey.LeftArrow:
                    index--;
                    
                    break;
                case ConsoleKey.RightArrow:
                    index++;
                  
                    break;
                case (ConsoleKey)ConsoleKey.Escape:
                    x= false;
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write( arr[index - 20] = KeyCheck.KeyChar.ToString());
                  
                    index++;
                  
                    break;
            }
            if (index < 20)
            {
                index = 20;

            }
            if (index > 39)
            {
                index = 39;

            }



        }
        


    }


    static int GetValueFromUser(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    

   



}


