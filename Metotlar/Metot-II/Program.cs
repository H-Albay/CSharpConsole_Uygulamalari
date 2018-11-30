using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Metot_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 0;
            int Secim = 0;
            int sonuc = 0;
            YenidenSec:
            Console.WriteLine("Birinci sayıyı giriniz.");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz.");
            sayi2=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Menu");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Seçiminiz:");
            Secim=int.Parse(Console.ReadLine());
            
            switch (Secim)
            {
                    
                case 1:
                    sonuc=Toplama(sayi1, sayi2);
                    yazdır(string.Format("{0}+{1}={2}",sayi1,sayi2,sonuc));
                    if (YenidenSecim() > 0){ goto YenidenSec; }
                    break;
                case 2:
                    sonuc = Cıkarma(sayi1, sayi2);
                    yazdır(string.Format("{0}-{1}={2}",sayi1,sayi2,sonuc));
                    if (YenidenSecim() > 0) { goto YenidenSec; }
                    break;
                case 3:
                    sonuc = Carpma(sayi1, sayi2);
                    yazdır(string.Format("{0}x{1}={2}",sayi1,sayi2,sonuc));
                    if (YenidenSecim() > 0) { goto YenidenSec; }
                    break;
                case 4:
                    sonuc = Bolme(sayi1, sayi2);
                    yazdır(string.Format("{0}/{1}={2}", sayi1, sayi2, sonuc));
                    if (YenidenSecim() > 0) { goto YenidenSec; }
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen yeniden seçim yapınız ");
                    goto YenidenSec;
            }

            Console.WriteLine("Uygulama Sonu..");
            Console.ReadKey();
        }

        private static int Bolme(int b1, int b2)
        {
            int sonuc = b1 / b2;
            return sonuc;
        }

        private static int Carpma(int c1, int c2)
        {
            int sonuc = c1 * c2;
            return sonuc;
        }

        public static int Toplama(int s1, int s2)
        {
            return s1 + s2;
        }

        public static void yazdır(string metin)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(metin);
        }

        private static int YenidenSecim()
        {
            Console.WriteLine("Yeniden Seçim yapmak istiyor musunuz [E]-[H]");
            string e=Console.ReadLine();
            if (e=="E"||e=="e")
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public static int Cıkarma(int c1, int c2)
        {
            int sonuc = c1 - c2;
            return sonuc;
        }

    }
}
