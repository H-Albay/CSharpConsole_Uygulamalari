using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enum
{
    public class DbLogicLayer
    {
        public DbKayıtİslemleri Kaydet()
        {
            /*
             *  gerekli işlemler
             */
            int sonuc = 1;
            return sonuc > 0 ? DbKayıtİslemleri.Basarılı : DbKayıtİslemleri.Basarısız;
        }

        public DbKayıtİslemleri Güncelle()
        {
            /*
            *  gerekli işlemler
            */
            int sonuc = 0;
            return sonuc > 0 ? DbKayıtİslemleri.Basarılı : DbKayıtİslemleri.Basarısız;
        }

        public DbKayıtİslemleri Sil()
        {
            /*
            *  gerekli işlemler
            */
            int sonuc = -1;
            return sonuc < 0 ? DbKayıtİslemleri.Basarılı : DbKayıtİslemleri.HataOlustu;

        }

        public  enum DbKayıtİslemleri
        {
            Basarılı=666, Basarısız=18, HataOlustu=23
        }
    }
}
