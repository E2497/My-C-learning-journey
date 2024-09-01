using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{

    static void Main(string[] args)
    {
        int empNum = GetValueFromUser("enter array size: ");
        Employee[] e = new Employee[empNum];
        Console.Clear();
        int selctedEmp=0;
        int lastValue = 0;
        Helper h = new Helper();

        while (true)
        {   Console.Clear();
            lastValue = selctedEmp-1;
            selctedEmp = GetValueFromUser("enter value from 1 to " + empNum +" or 0 to exit : ");
            Console.WriteLine(selctedEmp);
            if (selctedEmp == 0 & lastValue >=0)
            {
                for (int i = 0; i < e.Length; i++)
                {   if (e[i] != null)
                    {
                        Console.Clear();
                        h.SetConsoleColor((Color)e[i].favColor);
                        Console.WriteLine("Code:" + e[i].code);
                        Console.WriteLine("Salary:" + e[i].salary);
                        Console.WriteLine("Bonus" + e[i].bonus);
                        Console.WriteLine("Deduction:" + e[i].deduction);
                        Console.WriteLine("Total:{0}", e[i].bonus + e[i].salary - e[i].deduction);

                        Console.ReadLine();
                    }
                    


                    
                }
                break;
            }
            else if (selctedEmp == 0 && lastValue < 0)
            {

                Console.WriteLine("Please enter at least one value");
                Console.ReadLine();
            }
            else
            {   Console.Clear();
                e[selctedEmp - 1] = new Employee();
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Code :        Over Time :");
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("Salary :      Deductions :");  
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Favorite Color 1 - 6 :");
                
               
               
                Console.SetCursorPosition(12, 5);
                e[selctedEmp - 1].code = Console.ReadLine();
                Console.SetCursorPosition(31, 5);
                e[selctedEmp - 1].salary = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(14, 8);
                e[selctedEmp - 1].bonus = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(31, 8);
                e[selctedEmp - 1].deduction = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(29, 11);
                e[selctedEmp - 1].favColor = int.Parse(Console.ReadLine());
                Console.Clear();
              
            }
            

            
        }


        






        static int GetValueFromUser(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    class Employee
    {
        public string code;
        public int salary;
        public int bonus;
        public int deduction;
        public int favColor;
        

    }
}
