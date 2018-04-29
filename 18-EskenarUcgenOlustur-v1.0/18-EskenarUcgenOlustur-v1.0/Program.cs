using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EskenarUcgenOlustur_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K sayısını Giriniz : ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i <= (k - 1); i++)
            {
                for (int j = 1; j <= (k - i); j++)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= (2 * i + 1); m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int i = (k - 1); i >= -0; i--)
            {
                for (int j = 0; j <= (k - i); j++)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= (2 * i + 1); m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
