class Program
{
    static void Main(string[] args)

    {
        int empNum = GetValueFromUser("enter Number of Employees : ");
        Employee[] e = new Employee[empNum];
        String[] Options = { "Add", "Display", "Exit" };

        MovingThrouhgMenu(Options, e , empNum);


    }

    static void ShowValueToUser(int option, String[] Options)

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
    static void MovingThrouhgMenu(string[] Options, Employee [] e , int empNum)
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
                    //Console.WriteLine(Options[option]);
                    if (option == 0)
                    {
                        SetEmployeeValues(e,empNum);
                    }
                    if (option == 1)
                    {

                        for (int i = 0; i < e.Length; i++)
                        {

                            if (e[i] != null)
                            {
                                
                                e[i].PrintInfo();
                                
                                Console.ReadLine(); 

                            }
                        }
                        }
                    

                    break;
            }


        }



    }

    static void SetEmployeeValues(Employee [] e , int empNum)
    {
        Console.Clear();
        int selctedEmp = 0;
        int lastValue = 0;
        //Helper h = new Helper();

        while (true)
        {
            Console.Clear();
            lastValue = selctedEmp - 1;
            selctedEmp = GetValueFromUser("enter value from 1 to " + empNum + " or 0 to exit : ");
            Console.WriteLine(selctedEmp);
            if (selctedEmp == 0 & lastValue >= 0)
            {

                break;
            }
               
            
            else if (selctedEmp == 0 && lastValue < 0)
            {

                Console.WriteLine("Please enter at least one value");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                e[selctedEmp - 1] = new Employee();
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Code :        Over Time :");
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("Salary :      Deductions :");
                //Console.SetCursorPosition(5, 11);
                //Console.WriteLine("Favorite Color 1 - 6 :");

                Console.SetCursorPosition(12, 5);
                //e[selctedEmp - 1].SetEmployee(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                
                e[selctedEmp - 1].code = Console.ReadLine();
                Console.SetCursorPosition(31, 5);
                e[selctedEmp - 1].salary = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(14, 8);
                e[selctedEmp - 1].bonus = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(31, 8);
                e[selctedEmp - 1].deduction = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(29, 11);
                //e[selctedEmp - 1].favColor = int.Parse(Console.ReadLine());
                //Console.Clear();

            }



        }
       

    }
    static int GetValueFromUser(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

  
    

    public class Employee
    {
        public string code;
        public int salary;
        public int bonus;
        public int deduction;
        public int favColor;
        
        public void PrintInfo()
        {
            
                    Console.Clear();
                    // h.SetConsoleColor((Color)e[i].favColor);
                    Console.WriteLine("Code: " + code);
                    Console.WriteLine("Salary: " + salary);
                    Console.WriteLine("Bonus: " + bonus);
                    Console.WriteLine("Deduction: " + deduction);
                    Console.WriteLine("Total:{0} ", bonus + salary - deduction);

                 
             
        }
    }
}





