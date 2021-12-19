using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Zafer";
            //int yas = 18;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 18;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Zafer Avci";
            kurs2.IzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "İsa ";
            kurs3.IzlenmeOrani = 20;

            //Console.WriteLine(kurs1.KursAdi + ": " + kurs1.KursunEgitmeni);

            //(1-string kurs1 = "yazılımcı geliştirme kursu";
            //2-Kurs kurs1 = new Kurs();
            //1. satırdaki kurs1 in tipi string ama 2. satırdaki kurs1 in tipi Kurs olarak oluşturduğumuz
            //   dizinin içinde belirttiğimiz string ve int tipi alabilir) birden fazla tip içeriyor

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +": "+ kurs.KursunEgitmeni);
            }

        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
