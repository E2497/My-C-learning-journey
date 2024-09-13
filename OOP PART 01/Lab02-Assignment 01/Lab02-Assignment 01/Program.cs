class Program
{
    static void Main(string[] args)

    {
       
        Employee[] e = new Employee[5];
        Employee e1 = new Employee("E1");
        Employee e2 = new Employee("E2");
        Employee e3 = new Employee("E3");
        e1.PrintInfo();
        e2.PrintInfo();
        e3.PrintInfo();
        e[0] = new Employee("E4");
        e.PrintInfoForArray(0);








    }




    static int GetValueFromUser(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }




    
}
public class Employee
{
    public string name;
    public int id;
    public static int automaticId = 0;

    public Employee(string name)
    {
        this.name = name;
        automaticId++;
        this.id = automaticId;

    }

    public void PrintInfo()
    {

        
        // h.SetConsoleColor((Color)e[i].favColor);
        Console.WriteLine($"id:{id}");
        Console.WriteLine($"name:{name}");
        Console.ReadLine();
        Console.Clear();

    }
}
static class ExtensionClass
{
    public static void PrintInfoForArray(this Employee [] e,int index)
    {
        Console.WriteLine($"id:{e[index].id}");
        Console.WriteLine($"name:{e[index].name}");
        Console.ReadLine();
       
    }

}





