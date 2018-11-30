using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba=new Araba();
            araba.marka = "Volvo";
            araba.model = 2018;
            araba.renk = "Beyaz";
            Console.WriteLine("{0}-{1}-{2}",araba.model,araba.marka,araba.renk);
            Console.ReadKey();
        }

    }
    public  class Araba
    {
        public int Id;
        public int model;
        public string marka;
        public string renk;
    }
}
