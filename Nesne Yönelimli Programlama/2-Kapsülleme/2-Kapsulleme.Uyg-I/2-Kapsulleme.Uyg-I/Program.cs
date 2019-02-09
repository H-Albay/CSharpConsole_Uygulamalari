using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kapsulleme.Uyg_I
{
    class Program
    {
        /*  KAPSÜLLEME ÖRNEK
             -ogrenci sınıfının içerisinde _ogrno bir private field tanımı yapalım.
             Set-> 
             -Girilen değer 8 haneli olmalıdır.
             -Girilen değer içerisindeki tüm değerler sayısal değer olmak zorundadır.
             Get->
             -Öncelikle değer okunamaz şekilde ayarlansın
             -ilk 5 hanesini gösterelim.
        */
        static void Main(string[] args)
        {
            ogrenci o1 = new ogrenci();
            ogrenci o2 = new ogrenci();
            ogrenci o3 = new ogrenci();

            o1.ogrno = "85236417";  //Doğru giriş
            o2.ogrno = "741258";    //8 haneden az öğrenci girişi
            o3.ogrno = "41HS5523";  //8 haneli öğrenci numarası fakat karakterlerin tümü sayısal olmalı

            Console.ReadKey();
        }
    }
}
