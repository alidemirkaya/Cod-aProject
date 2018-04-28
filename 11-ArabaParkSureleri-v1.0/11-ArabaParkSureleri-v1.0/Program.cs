using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArabaParkSureleri_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelen Araba Sayısını Giriniz : ");
            int arabasayisi = int.Parse(Console.ReadLine());
            int[] sureleri = new int[arabasayisi];
            for (int i = 0; i < arabasayisi; i++)
            {
                Console.WriteLine((i + 1) + ". Arabanın Park Süresi : ");
                sureleri[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Num.       Park Süresi         Ücret");
            Console.WriteLine("--------------------------------------");
            int sure;
            int ucreti=0;
            for (int i = 0; i < arabasayisi; i++)
            {
                sure = sureleri[i];
                if (sure <= 3)
                {
                    ucreti = 8;
                }
                else if(sure>3 && sure <= 24)
                {
                    ucreti = 8 + (sure - 3) * 2;
                }
                else if (sure > 24)
                {
                    ucreti = 75;
                }
                Console.WriteLine("   "+i + "            " + Convert.ToString(sure) + "              " + ucreti);
            }
            Console.ReadKey();
        }
    }
}
