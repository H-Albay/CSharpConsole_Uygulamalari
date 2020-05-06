using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_III
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alısverislistesi = new ArrayList();
            alısverislistesi.Add("1kg kıyma yağsız");
            alısverislistesi.Add("süt yarımyağlı");
            alısverislistesi.Add("15li yumurta");
            alısverislistesi.Add("2 tam buğday ekmek");

            ArrayList ekmarketliste = new ArrayList();
            ekmarketliste.Add("1,5kg yarım yağlı yoğurt");
            alısverislistesi.AddRange(ekmarketliste); //alışveriş listeme ek listesinide ekle

            ArrayList hliste = new ArrayList() { "muz", "yulaf" }; //farklı bir tanımla şekli
            alısverislistesi.AddRange(hliste);//alıveriş listeme hlisteyi ekle

            //alışveriş listesini listeleme
            foreach (var item in alısverislistesi)
            {
                Console.WriteLine(item);
            }

            //alışveriş listesini güncelleme
            alısverislistesi[0] = "1Kg Yağsız Kıyma";
            alısverislistesi[1] = "1Lt Yarım Yağlı Süt";
            alısverislistesi[2] = "15 Adet Yumurta";

            //alışveriş listesini sil
            alısverislistesi.Remove("muz");//listeki muz strigini sil
            alısverislistesi.RemoveRange(3, 2);//listemdeki 3indisten başla 2 adet sil


            //YARDIMCI METOTLAR
            alısverislistesi.Reverse();//diziyi tersten yazar
            alısverislistesi.Sort();//a-z sıralar
            bool kontrol = alısverislistesi.Contains("yulaf");//listede yulaf iceriyor mu?
            alısverislistesi.Clear();
            alısverislistesi.TrimToSize();//listeyi varsayılan degerine getirir.
            Console.ReadKey();
        }
    }
}