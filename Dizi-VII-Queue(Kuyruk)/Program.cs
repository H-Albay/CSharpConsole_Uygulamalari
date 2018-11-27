using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_VII_Queue_Kuyruk_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue kuyruk = new Queue();
            //kuyruga ekleme
            kuyruk.Enqueue("tren");
            kuyruk.Enqueue("vagon1");
            kuyruk.Enqueue("vagon2");
            kuyruk.Enqueue("vagon3");
            kuyruk.Enqueue("vagon4");
            kuyruk.Enqueue("vagon5");
            //listeleme
            foreach (var i in kuyruk)
            {
                Console.WriteLine(i.ToString());
            }
            //koleksiyondan çıkarma
            var cik1 = kuyruk.Dequeue();
            var kuyruktakiyenideger = kuyruk.Peek();
            //koleksiyonda deger arama
            bool aranan = kuyruk.Contains("vagon6");
            Console.ReadKey();
        }
    }
}
