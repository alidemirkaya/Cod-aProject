using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FaktoriyelHesapla_v2._0
{
    class Program
    {
        public static int FaktoriyelHesapla(int sayi)
        {
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyeli Hesaplanacak sayıyı giriniz ..");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = FaktoriyelHesapla(sayi);          
            Console.WriteLine(sayi + " sayısının Faktöriyeli : " + faktoriyel);
            Console.ReadKey();
        }
    }
}
