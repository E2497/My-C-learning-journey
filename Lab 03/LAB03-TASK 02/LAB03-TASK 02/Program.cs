using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{

    static void Main(string[] args)
    {
        Employee e = new Employee();
        e.code = Convert.ToString((GetValueFromUser("code:")));
        e.salary = (float)GetValueFromUser("Salary:"));
        e.bonus = GetValueFromUser("Bonus:");
        e.deduction = GetValueFromUser("Deduction:");
        Console.WriteLine("Code:" + e.code);
        Console.WriteLine("Salary:" + e.salary);
        Console.WriteLine("Bonus" + e.bonus);
        Console.WriteLine("Deduction:" +e.deduction);
        Console.WriteLine("Total:{0}",  e.bonus+e.salary-e.deduction);





        static int GetValueFromUser(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    class Employee
    {
        public string code ;
        public float salary;
        public int bonus;
        public int deduction;
        enum Color
        {
            red,
            green,
            blue
        }

    }
}
