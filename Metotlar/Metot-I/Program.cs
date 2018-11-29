using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_I
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz();
            //---
            yaz("Parametre alan geriye değer döndürmeyen metot yazdım");
            //---
            int toplam=topla(41, 55);
            yaz(toplam.ToString());
            //---
            string donendeger=topla("Yazılım", "Mühendisliği");
            yaz(donendeger);
            Console.ReadKey();
        }
        // Parametre almayan ve geriye değer döndürmeyen metot 
        static void EkranaYaz()
        {
            Console.WriteLine("Merhaba Parametre almayan ve geriye değer döndürmeyen metot yazdım.");
        }
        // Parametre alan ve geriye değer döndürmeyen metot 
        static void yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        // Parametre alan ve geriye değer döndüren metot 
        static int topla(int s1, int s2)
        {
            int sonuc=s1 + s2;
            return sonuc;
        }

        //yaz metotunu aşırı yükleme
        static decimal topla(decimal sayı1,decimal sayı2)
        {
            decimal toplam = sayı1 + sayı2;
            return toplam;
        }
        static string topla(string m1, string m2)
        {
            return m1+" "+m2;
        }

    }
}
