using System;
//using static System.Console;

namespace ConsoleApp1 //없어도 되는 것(범위 지정자?)
{
    class Program
    {
        static void Main(string[] args) //메모리에서 남아 있는 반환되지 않는 것(static)
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 123;
            object f = (object)a;
            int g = (int)b;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            double x = 3.1414213;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
