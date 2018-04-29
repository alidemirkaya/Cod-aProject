using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_VizeFinalSoruları_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notlar_vize = new int[] { 80, 40, 30, 50, 25, 75, 60, 50, 40, 90, 30 };
            int[] notlar_final = new int[] { 65, 60, 80, 70, 40, 50, 80, 35, 20, 15, 90 };

            double ortalama = 0;
            // Şimdi not ortalamalarını hesaplatıyoruz..
            Console.WriteLine(" Vize    Final     Ortalama");
            Console.WriteLine("------  --------  ----------");
            for(int i = 0; i < notlar_vize.Length; i++)
            {
                ortalama = (notlar_vize[i] * 40 + notlar_final[i] * 60)/100;
                Console.WriteLine("  {0}       {1}         {2}", notlar_vize[i], notlar_final[i], ortalama);
            }
            Console.ReadKey();
        }
    }
}
