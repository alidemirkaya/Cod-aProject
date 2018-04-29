using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BaklavaDilimi_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N değerini giriniz : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)s
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int k = n; k >= 1; k--)
            {
                for(int t = 1; t <= k; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
