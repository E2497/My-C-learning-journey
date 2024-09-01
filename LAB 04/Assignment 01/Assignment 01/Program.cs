class Program
{

    static void Main(string[] args)
    {

        int stringLength = GetValueFromUser("Enter string size: ");
        char[] UserInput = GetStringFromUser(stringLength);
        ShowLimitedChar(stringLength, UserInput);

    }


    static int GetValueFromUser(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static char[] GetStringFromUser(int stringLength)
    {

        Console.WriteLine("Please Enter Chars and enter to Finish: ");
        char[] userInput = new char[stringLength];
        int i = 0;

        ConsoleKeyInfo KeyCheck ;
        while ((KeyCheck = Console.ReadKey()).Key != ConsoleKey.Enter && i<stringLength)
            {
            
                
                userInput[i] = KeyCheck.KeyChar; 
                 i++;
            

            }

        
       
        return  userInput;
    }

    static void ShowLimitedChar(int stringLength, char[] UserInput)
    {
        Console.WriteLine();
        int i = 0;
        while (UserInput.Length<=stringLength && i < stringLength)
        {
            Console.Write(UserInput[i] );
            i++;
        }


    }



}


