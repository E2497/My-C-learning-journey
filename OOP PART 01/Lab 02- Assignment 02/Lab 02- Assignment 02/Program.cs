class Program
{

    static void Main(string[] args)
    {
        List<int> x = new List<int> { 1,2,3};
        List<int> y = new List<int> { 5, 6, 7 };
        Complex c1 = new Complex(3,3,x);
     Complex c2 = new Complex(4,4,y);

     Complex c3 = c1 + c2;
     Console.WriteLine(c3.real);
      
        for (int i = 0; i < (c3.x).Count; i++)
        {
            Console.WriteLine((c3.x)[i]);
        }
        Console.ReadLine();


    }
}

public class Complex
{
    public int img;
    public int real;
    public List<int> x = new List<int>();
    public Complex()
    {
      

    }
    public Complex(int img, int real, List<int> x  )
    {
        this.img = img;
        this.real = real;
        this.x = x;
    }

    public static Complex operator+(Complex c1 , Complex c2) 


    {  
        
        Complex c3 = new Complex();
        c3.img = c1.img + c2.img;
        c3.real = c1.real + c2.real;
        int i=0;
        int j = 0;
        while (i < ( c1.x).Count)
        {
            (c3.x).Add((c1.x)[i]);
            i++;
        }

        while (j < (c2.x).Count)
        {
            (c3.x).Add((c2.x)[j]);
            j++;
        }
        return c3;
    }

}