using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task4.2");
            //int a = int.Parse(Console.ReadLine());
            //if ((a >= 12) && (a <= 18))
            //{ Console.WriteLine("teenarer"); }
            //else if ((a > 18) && (a < 60))
            //{ Console.WriteLine("adult"); }
            //else if (a >= 60)
            //{ Console.WriteLine("eldery"); }
            //else
            //{ Console.WriteLine("child"); }
            //Console.WriteLine();


            //Console.WriteLine("Task 4.4");
            //Console.WriteLine("Amount of goods:");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine("Price:");
            //int C = int.Parse(Console.ReadLine());
            //Console.WriteLine("Amount of money:");
            //int M = int.Parse(Console.ReadLine());

            ////int N = 10, C = 10, M = 90;

            //int a = M / C;//how many can buy
            //int b = M - N * C; // rest of money
            //int c = b / C;// amount of goods can buy for more money  
            //int d = c + N; //amount more than N
            //int e = b%C; //would be enough for amount of whole good
            //int f = M - a * C;// rest of money after buying more


            //Console.WriteLine($"{"You can buy - "}{a} {"goods"}");

            //if (a < 1)
            //{ Console.WriteLine("You can't buy even one of goods"); }
            //else if ((a > N) && (e == 0))
            //{ Console.WriteLine($"{"You can buy more than - "} {N} {"per "}{c}"); }
            //else if ((e != 0) && (b < C))
            //{ Console.WriteLine($"{"If you buy"} {N} {"of goods, you would have"} {e} {"of money"}"); }
            //else if ((e != 0) && (f > 0))
            //{ Console.WriteLine($"{"If you buy"} {N} {"of goods, you can buy more per"} {c} {"and have"} {e} {"of money"}"  ); }
            //else
            //{ Console.WriteLine($"{"You have money on "} {a}{"goods"}"); }


            //Console.WriteLine("Task 4.5");
            //int a = 10, b = 100;
            //int c = int.Parse(Console.ReadLine());
            //if ((c < a)&&(c>b))
            //{if (c < a)
            //    { Console.WriteLine("c<a"); }
            //    else if (c > b)
            //    { Console.WriteLine("c>b"); }
            //}

            //}
            //else           { Console.WriteLine("ok"); }

            Console.WriteLine("Task 4.7");
            string a = Console.ReadLine();
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());

            string b = Console.ReadLine();
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            string c = Console.ReadLine();
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());


            Console.WriteLine(" Car:{0,0}         MaxSpeed: {1,10 }             FuelUsage:{2, 20}",  a, a1, a2);
            Console.WriteLine(" Car:{0,0}         MaxSpeed: {1,10 }             FuelUsage:{2, 20}", b, b1, b2);
            Console.WriteLine(" Car:{0,0}         MaxSpeed: {1,10 }             FuelUsage:{2, 20}", c, c1, c2);











        }
    }
}
