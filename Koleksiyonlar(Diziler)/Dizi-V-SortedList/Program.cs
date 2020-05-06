using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_V_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sehir Listesi tanımlama
            SortedList SehirList=new SortedList();
            //Sehir Ekleme
            SehirList.Add(59,"Tekirdağ");
            SehirList.Add(55,"Samsun");
            SehirList.Add(41,"Kocaeli");
            SehirList.Add(23,"elazıg");
            //Güncelleme
            SehirList[23] = "Elazığ";
            //Silme
            SehirList.Remove("Tekirdağ");
            //Listeleme
            foreach (DictionaryEntry lists in SehirList)
            {
                Console.WriteLine(lists.Key);
                Console.WriteLine(lists.Value);
            }
        }
    }
}
