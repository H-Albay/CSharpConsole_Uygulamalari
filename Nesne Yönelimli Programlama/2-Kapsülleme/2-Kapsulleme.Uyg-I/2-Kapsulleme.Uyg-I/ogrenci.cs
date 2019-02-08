using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kapsulleme.Uyg_I
{
    public class ogrenci
    {
        private string _ogrno;

        public string ogrno
        {
            private get { return _ogrno.Substring(0, 5); }
            set
            {
                if (value.Length == 8)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (karakterkontrol)
                        {
                            //öğrenci numarası sayısal girilmiş.

                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }

                    }
                    if (bayrak)
                    {
                        Console.WriteLine("Öğrenci numarası içindeki değerler sayısal olmalıdır.");
                    }
                    else
                    {
                        Console.WriteLine("Ogrenci Numarası: {0}***", value.Substring(0, 5));
                        this._ogrno = value;
                    }


                }
                else { Console.WriteLine("Öğrenci Numarası 8 haneli olmalıdır."); }
            }

        }
    }
}
