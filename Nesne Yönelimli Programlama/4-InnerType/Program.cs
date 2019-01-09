using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Satis s1 = new Satis();

            s1._musteritanim = new Musteri()
            {
                isim = "Ali",
                Soyisim = "Demir",
                EmailAdres = "ademir@gmail.com",
                MusteriID = 1
            };

            s1._uruntanim = new Urun()
            {
                UrunKod = "1549add",
                DepoKod = "1SS",
                UrunAdı = "İphone 6S PLUS"
            };
            s1.Adet = 5;
            s1.Fiyat = 2999;

            //Musteri ile alakalı sınıfa eriştim(innertype),Satıs sınıfı üzerinden..
            //İnnertype sayasinde uygulama yapımı bozmadan eklemeler yapabilirim.
            s1._musteritanim.emailgonder("Satıs","X tarihte aldığınız Y ürünü için bilgilendirme maili");
            Console.ReadLine();
        }
    }
}
