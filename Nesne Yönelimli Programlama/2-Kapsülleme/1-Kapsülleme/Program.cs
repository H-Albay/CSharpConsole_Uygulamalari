using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kapsülleme
{
    /*  Kapsülleme nedir?
     * içeride saklamış olduğumuz private fieldın önüne koymuş olduğumuz bir property sayesinde get ve set bloklarını atıyarak değer atamasıdır.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Musteri M = new Musteri();
            M._isim = "Hakan";
            M._soyisim = "Albay";
            M._musterino = 1;
            M._tckimlikno = "11111111111";

            M.EkranaYaz();
            Console.ReadKey();
        }

    }

    class Musteri
    {
        private int MusteriNo;
        private string Isim;
        private string Soyisim;
        private string TCKimlikNo;
        private Guid MusteriID; //Guid benzersiz bir alan yaratır (id) 

        public Musteri()
        {
            MusteriID = Guid.NewGuid();

        }
        //Kapsülleme
        public Guid _musteriid
        {
            get { return this.MusteriID; }
        }

        public int _musterino
        {
            get { return MusteriNo; }
            set { this.MusteriNo = value; }
        }

        public string _isim
        {
            get { return Isim; }
            set { this.Isim = value; }
        }

        public string _soyisim
        {
            get { return Soyisim; }
            set { this.Soyisim = value; }
        }

        public string _tckimlikno
        {
            get { return "***" + this.TCKimlikNo.Substring(3); }
            set
            {
                if (value.Length == 11)
                {
                    this.TCKimlikNo = value;
                }
                else
                {
                    this.TCKimlikNo = string.Empty;
                }
            }
        }
        public void EkranaYaz()
        {
            Console.WriteLine("{0} -> {1} -> {2} -> {3}->{4}", this._musterino, this._isim, this._soyisim, this._tckimlikno, this._musteriid);
        }

    }
}
