class Program
{

    static void Main(string[] args)
    {
        
        Complex c1 = new Complex();
        Complex c2 = new Complex();
        c1.real = 10;
        c2.real = 20;
        c1.img = 5;
        c2.img = 5;
        Complex x =AddComplex (c1 , c2);
        Console.WriteLine("Total Add real :{0}", x.real);
        Complex y = SubComplex (c1 , c2);
        Console.WriteLine("Total Substract real :{0}", y.real);


    }

    static Complex AddComplex(Complex c1, Complex c2)
    {
        Complex totalAdd;
       
        totalAdd.real = c1.real + c2.real;
        totalAdd.img = c1.img + c2.img;
      
        //Console.WriteLine("Total Add real :{0}", totalAdd.real );
        //Console.WriteLine("Total Add img :{0}", totalAdd.img);
        return totalAdd;
    }
    static Complex SubComplex(Complex c1, Complex c2)
    {
        Complex totalSub;
        
        totalSub.real = c1.real - c2.real;
        totalSub.img = c1.img - c2.img;
       // Console.WriteLine("Total Substract real :{0}", totalSub.real);
        //Console.WriteLine("Total Substract img :{0}", totalSub.img);
        return totalSub;
    }
}

struct Complex
{
    public float real;
    public float img;

}

   








