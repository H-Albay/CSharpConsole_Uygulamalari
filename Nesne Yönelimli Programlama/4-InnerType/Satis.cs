using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_InnerType
{
    class Satis
    {
        //Musteri, Musteri sınıfıdaki özellikleri taşımaktadır.
        public Musteri _musteritanim { get; set; }
        //Urun, Urun sınıfıdaki özellikleri taşımaktadır.
        public Urun _uruntanim { get; set; }

        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public DateTime SatisTarih { get; set; }
        
        //Yapıcı metot tanımladım.
        public Satis()
        {
            //Musteri ve Urunu örnekledim.
            _musteritanim=new Musteri();
            _uruntanim=new Urun();
        }

    }
}
