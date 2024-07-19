using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{

    static void Main(string[] args)
    {   int empNum = GetValueFromUser("enter array size: ");
        Employee [] e = new Employee[empNum];

        while (true)
        {
            Console.Clear();
            int selctedEmp = GetValueFromUser("enter value from 1 to: "+ empNum);
            e[selctedEmp].code = Convert.ToString((GetValueFromUser("code:")));
            e[selctedEmp].salary = (float)GetValueFromUser("Salary:");
            e[selctedEmp].bonus = GetValueFromUser("Bonus:");
            e[selctedEmp].deduction = GetValueFromUser("Deduction:");
            Console.WriteLine("Code:" + e[selctedEmp].code);
            Console.WriteLine("Salary:" + e[selctedEmp].salary);
            Console.WriteLine("Bonus" + e[selctedEmp].bonus);
            Console.WriteLine("Deduction:" + e[selctedEmp].deduction);
            Console.WriteLine("Total:{0}", e[selctedEmp].bonus + e[selctedEmp].salary - e[selctedEmp].deduction);

            if (selctedEmp == 0) 
            { 

                break; 
            }
        }
        

        for (int i = 0; i < empNum; i++)
        {
            e[i].code = Convert.ToString((GetValueFromUser("code:")));
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
