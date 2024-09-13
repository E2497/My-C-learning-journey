class Program
{

    static void Main(string[] args)
    {
        Employee e = new Employee("e", 24, 500);
        
        Console.WriteLine(e.ToString());
    }
}

public class Human
{
    public string name;
    public int age;


    public Human (string name, int age ) {
        this.name = name; 
        this.age = age;
    }



 }

public class Employee : Human
{   int salary;
    public Employee(string name , int age, int salary) : base (name,age)
    {
        this.salary = salary;   
    }
    public override string ToString()

    {
        string x = this.name;
       
        return  $"Name:{this.name}, Salary:{this.salary}" ;
    }
}

    


