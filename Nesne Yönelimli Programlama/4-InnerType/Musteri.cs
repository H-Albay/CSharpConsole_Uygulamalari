using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InnerType
{
    class Musteri
    {
        public int MusteriID { get; set; }

        public string isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }

        public void emailgonder(string _konu, string _icerik)
        {
            Console.WriteLine("Email gönderildi.");
        }
    }
}
