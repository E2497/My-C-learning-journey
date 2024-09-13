using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_03_Assignment_02;



class Program
{

    static void Main(string[] args)
    {
        //Geospatial c = new Geospatial(5, 6);
        Geospatial S = new Rectangle(5,6);
       // int z = S.CalcArea();
        //Console.WriteLine(z); 
        


        Geospatial [] x = new Geospatial[3];
        x[0] = new Rectangle(5, 6);
        x[1] = new Circle(7);
        x[2] = new Triangle(5, 8);
        Pic.PictureArea(x);


    
    }
}