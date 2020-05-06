using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_VIII_Uygulama_I
{
    class Program
    {
        static void Main(string[] args)
        {
           //Uygulama-I
           //10elemanlı bir dizi oluşturalım her bir indise 1-100 arası rasgele sayı atıyalım
           //dizi içerisini küçükten büyüğe sıralıyalım
           //dizini en küçük ve en büyük elemanını ekrana yazdıralım.

           int[] sayi=new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayi[i] = random.Next(1, 100);
                Console.WriteLine("{0}.indis degerine sahip sayı:{1}",i,sayi[i]);
            }
            Array.Sort(sayi);
            Console.WriteLine("En küçük değer:{0}",sayi.Max());
            Console.WriteLine("En büyük değer:{0}", sayi.Min());
            Console.ReadKey();
        }
    }
}
