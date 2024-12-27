using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float UserPoint;
            string point;
            Console.WriteLine("plz enter a number");
            point = Console.ReadLine();
            UserPoint = int.Parse(point);
            string res;
            if (UserPoint < 10)

            {
                res = "failed";
            }

            else
            {
                res = "pass";
            }
            Console.WriteLine(res);
            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
                    





    
        }
    }
}
