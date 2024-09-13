using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Assignment_02
{   public static class Pic
    {
       static Geospatial[] G;
        public  static void PictureArea(Geospatial[] G)
        {
            for (int i = 0; i < G.Length; i++)
            {
                G[i].CalcArea();
            }
        }
    }
    public abstract class Geospatial
    {
        protected int dim1 { get; set; }
        protected int dim2 { get; set; }
        public Geospatial(int dim1, int dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }
        public Geospatial(int dim1)
        {
            this.dim1 = dim1;
         
        }

        public abstract int CalcArea();
        
    }

    public class Rectangle : Geospatial
    {
        
        public Rectangle (int dim1, int dim2) :base (dim1, dim2) {
           

        }
        public override int CalcArea()
        {
            Console.WriteLine(dim1 * dim2);
            return dim1*dim2;
        }
    }
    public class Circle : Geospatial
    {

        public Circle(int dim1) : base(dim1)
        {


        }
        public override int CalcArea()
        {
            Console.WriteLine(22/7 * dim1*dim1);
            return 22 / 7 * dim1 * dim1;
        }
    }
    public class Triangle : Geospatial
    {

        public Triangle(int dim1, int dim2) : base(dim1, dim2)
        {


        }
        public override int CalcArea()
        {
            Console.WriteLine(1/2 * dim2 * dim1);
            return 1 / 2 * dim2 * dim1;
        }
    }
}


