using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] marka = new string[5];
            marka[0] = "Alfa Romeo";
            marka[1] = "Aston Martin";
            marka[2] = "Audi";
            marka[3] = "BMW";
            marka[4] = "Bugatti";
            //diziyi yeniden nasıl boyutlandırabilirim?
            marka = yenidenboyutlandır(marka, marka.Length + 5);

            //Varlık kontrolu nasıl yapılır?
            bool kontrol = Array.Exists(marka, i => i == "BMW");// BMW markası mevcut mu?
            if (kontrol)
            {
                Console.WriteLine("aradığınız marka kolleksiyonun içersinde mevcut.");
            }


            int bulunanindex = Array.IndexOf(marka, "Audi");//marka koleksiyonunda bulunan Audinin index numarası
            // Array.Sort(marka); a-z sıralama yapar.
            // Array.Reverse(marka); diziyi tersine çevirir.
            Console.ReadKey();
        }

        private static string[] yenidenboyutlandır(string[] marka, int limit)
        {
            string[] temp = new string[limit];
            for (int i = 0; i < marka.Length; i++)
            {
                temp[i] = marka[i];
            }
            return temp;

        }
    }
}