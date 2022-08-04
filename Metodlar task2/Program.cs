using System;

namespace Metodlar_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(6));
            Console.WriteLine(Area(5, 6));
            Console.WriteLine(Area(3,5,7));
            Console.WriteLine(Area(6,8,10,3,4));
        }
        
        static int Area(int radius)
        {
            int area = 0;
            int pi = 3;
            area = pi * (radius * radius);
            return area;
        }

        static int Area(int a, int b)
        {
            int area = 0;
            area = a * b;
            return area;
        }

        static int Area(int a, int b, int c)
        {
            int area = 0;
            area = 2 * (a * b + a * c + b * c);
            return area;
        }
        static int Area(int a,int b, int c,int p,int radius)
        {
            int area = 0;
            p = a + b + c / 2;
            area = p * radius;
            return area;
        }
       
    }
}
