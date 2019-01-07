using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            kitap k = new kitap(); // statik olmadan örneklenen nesne
            k.ISBN = 554123;
            k.isim = "Gölgelerin Efendisi";
            k.Kategori = "Bilim Kurgu";         
            //---
            //Static metotun özelliği kitap.? kullanılır.
            kitap.kütüphane_adı = "Fırat Üniversitesi Merkez Kütüphanesi";
            kitap.kütüphane_adres = "MERKEZ/ELAZIĞ";
            //---
            k.ekranayaz();
            kitap.static_ekranayaz();
            //---
            emailgöndermeislemleri.KullanıcıAdı = "H-Albay";
            emailgöndermeislemleri.Şifre = "15487965541";
            emailgöndermeislemleri.EmailAdres = "h@gmail.com";
            emailgöndermeislemleri.Port = 7;

            emailgöndermeislemleri.Emailgönder("e.t@firat.edu.tr", "Dersler Hakkında",
                "Algoritma Analiz Örnek çalışma soruları nerden bulabilirim?", "---");

            Console.ReadLine();
            }
    }

    public class kitap
    {
        public static string kütüphane_adı; //Statik alan tanımlandı.
        public static string kütüphane_adres;

        //static yapıcı metotlar bir kere çalışırlar.
        //önce static metot sonra yapıcı metot çalışır.
        static kitap()      //public static kitap() yazamadım neden? 
        {                   //ben statiğim örneklenmiyorum(new) bana erişim belirliyici vermene gerek yok.
            Console.WriteLine("Statik yapıcı metot çalıştı.");
        }

        public kitap()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }



        /*Statik olamayan*/
        public int ISBN { get; set; }
        public string isim { get; set; }
        public string Kategori { get; set; }

        public void ekranayaz()
        {
            Console.WriteLine("ISBN: {0}-İsim: {1} - Kategori : {2} -Kütüphane: {3} -Adres: {4} ", ISBN, isim, Kategori, kütüphane_adı, kütüphane_adres);
        }

        public static void static_ekranayaz()
        {
            Console.WriteLine("Static ekrana yaz çalıştı");
        }

       
    }

    //Static sınıflar örneklenemezler(new)
    //Static sınıflar içerisinde static sınıflar bulunmalı.
    public static class emailgöndermeislemleri
    {
        public static string KullanıcıAdı { get; set; } // static kullanmassam çalışmaz.
        public static string Şifre { get; set; }
        public static string EmailAdres { get; set; }
        public static int Port { get; set; }

        public static void Emailgönder(string _kime,string _cc,string _konu,string içerik)
        {
            //email işlemleri
        }


    }
}
