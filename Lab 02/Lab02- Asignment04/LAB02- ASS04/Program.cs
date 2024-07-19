using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{

    static void Main(string[] args)
    {

        int rowsNum = GetValueFromUser("Enter number of rows ");
        int[][] arr = new int[rowsNum][];       
            


        for (int i = 1; i <= rowsNum; i++)
        {

            int ColNum = GetValueFromUser("Enter No of Columns in Row # " + i + " ");
            arr[i - 1] = new int [ColNum];
            Console.WriteLine(ColNum);

            for (int j = 1; j <= ColNum; j++)
            {
                arr[i - 1][j-1] =  GetValueFromUser("Row # " + i + " column # " + j +" ");
            }
        }
        for (int i = 1; i <= rowsNum; i++)
        {

            for (int j = 1; j <= arr[i-1].Length; j++)
            {
                Console.WriteLine ("row # {0} and column {1} #",i,j,arr[i-1][j-1]);
               
            }
        }


        static int GetValueFromUser(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
