using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            DbLogicLayer DLL = new DbLogicLayer();


            DbLogicLayer.DbKayıtİslemleri GDeger = DLL.Kaydet();

            switch (GDeger)
            {   //Enumlar arkaplanda sayısal değerlerle işlem yapmamıza yaramaktadır.
                //Sayısal değerlerle çalışmak kod yazarken kolaylık sağlamaktadır.
                //Büyük uygulamalarda işimizi kolaylaştırmaktadır;
                //çünkü işlemin durumları yazı tipinde kod  tarafında sayısal veriler tutulmaktda
                case DbLogicLayer.DbKayıtİslemleri.Basarılı:
                    break;
                case DbLogicLayer.DbKayıtİslemleri.Basarısız:
                    break;
                case DbLogicLayer.DbKayıtİslemleri.HataOlustu:
                    break;
            }
        }
    }
}
