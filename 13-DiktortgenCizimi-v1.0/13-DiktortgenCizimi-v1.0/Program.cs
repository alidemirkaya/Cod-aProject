using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DiktortgenCizimi_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörgenin genişliğini Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diktörgenin yüksekliğini Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi2 + 1; i++)
            {
                for(int j=1;j<= sayi1 + 1; j++)
                {
                    if ((i == 1 || i==sayi2+1) && j <= sayi1 + 1)
                    {
                        Console.Write("*");
                    }
                    else if((j==1 || j==sayi1+1) && i<= sayi2 + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
