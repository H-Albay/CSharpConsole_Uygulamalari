using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi oluşturma
            string[] dersler = new string[6];
            //Veri ekleme
            dersler[0] = "yapay zeka";
            dersler[1] = "algoritma analizi";
            dersler[2] = "algoritma ve programlama";
            dersler[3] = "veri yapıları";
            dersler[4] = "işletim sistemleri";
            dersler[5] = "yazılım kalite güvencesi";
            //Veri Güncelleme
            dersler[2] = "veri yapıları";
            dersler[3] = "algoritma ve programlama";
            //Veri Silme
            dersler[4] = "null";
            //Veri Listeleme-I
            foreach (var listele in dersler)
            {
                Console.WriteLine(listele.ToString());
            }
            //Veri Listeleme-II
            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }
            Console.ReadKey();
        }
    }
}