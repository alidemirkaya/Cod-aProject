using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_AsalSayiBulma_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int kalan;
            int[] Asal;
            Console.WriteLine("Hangi Sayıya Kadar Asal Sayılar Bulunsun : ");
            int sayi = int.Parse(Console.ReadLine());
            for(int i = 2; i < sayi; i++)
            {
                kalan = 1;
                for(int j = 2; j < (i - 1); j++)
                {
                    if (i % j == 0)
                    {
                        kalan = 0;
                        break;
                    }
                }
                if (kalan == 1)
                {                   
                    b = b + 1;
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
