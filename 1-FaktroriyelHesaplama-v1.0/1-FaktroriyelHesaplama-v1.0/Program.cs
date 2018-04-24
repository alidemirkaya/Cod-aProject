using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FaktroriyelHesaplama_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyeli Hesaplanacak sayıyı giriniz ..");
            int sayi =int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            for(int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine(sayi + " sayısının Faktöriyeli : " + faktoriyel);
            Console.ReadKey();
        }
    }
}
