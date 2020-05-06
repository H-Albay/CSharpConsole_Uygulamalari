using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_VI_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack kitaplar=new Stack();//MANTIGI: Son giren ilk çıkar
            kitaplar.Push("Gölgelerin Efendisi");//Veri Ekleme
            kitaplar.Push("Açlık Oyunları");
            kitaplar.Push("Yüzüklerin Efendisi");
            kitaplar.Push("Şeker Kutusu");
            foreach (var item in kitaplar)//Veri Listeleme
            {
                Console.WriteLine(item);
            }        
            Console.WriteLine("Listeden çıkar: {0} \n{0}çıkarıldı",kitaplar.Pop());
            Console.WriteLine("Çıkarılmayı bekleyen kitap: {0}",kitaplar.Peek());
            bool kontrol = kitaplar.Contains("Yüzüklerin Efendisi");
            Console.WriteLine("Aramış olduğunuz veri içerde {0}", kontrol?"Var":"Yok");
            Console.ReadKey();
        }
    }
}
