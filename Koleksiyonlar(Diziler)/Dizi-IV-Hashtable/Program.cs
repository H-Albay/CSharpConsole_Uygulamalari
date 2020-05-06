using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_IV_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ciceksepeti = new Hashtable();
            //Veri Ekleme
            ciceksepeti.Add(121341, "kardelen");
            ciceksepeti.Add("2114mdakak", "zambak");
            ciceksepeti.Add(7166, "orkide");
            //Veri Güncelleme
            ciceksepeti["2114mdakak"] = "Zambak";
            //Veri Silme
            ciceksepeti.Remove(7166);
            //Veri Listeleme 
            foreach (DictionaryEntry item in ciceksepeti)
            {
                Console.WriteLine("Anahtar:{0}-Deger:{1}", item.Key, item.Value);
            }
            //arama işlemleri(key yada values)
            bool keycontrol = ciceksepeti.ContainsKey(7166);
            bool valuescontrol = ciceksepeti.ContainsValue("zambak");
        }
    }
}
