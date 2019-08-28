using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExamplePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , y ;
            Console.Write("Enter x value :");
            x=Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter y value :");
            y=Convert.ToInt32(Console.ReadLine());
            
           Console.Write("The sum of two inters is: " x + y);
        }
    }
}
