using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BasamakDegerliBul_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz..");
            string girilen = Console.ReadLine();
            char[] dizi_s = girilen.ToCharArray();
            int dizi_boyut = dizi_s.Length;
            int toplam = 0;
            Console.WriteLine("Basamak Değerleri : ");
            for (int i = 0; i < dizi_boyut; i++)
            {
                toplam = toplam +int.Parse(dizi_s[i].ToString());
                Console.Write(dizi_s[i] + " , ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Toplamları : " + toplam);
            Console.ReadKey();
        }
    }
}
