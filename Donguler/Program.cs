using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılımcı geliştirme kursu";
            string kurs2 = "proglamalamay giriş kampı kursu";
            string kurs3 = "Java";

            //array-- dizi

            string[] kurslar = new string[] { "yazılımcı geliştirme kursu", 
                                              "proglamalamay giriş kampı kursu", "Java", "python" };

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---------For Bitti");

            foreach (string abcxyz in kurslar)
            {
                Console.WriteLine( abcxyz );

            }
            Console.WriteLine("-----------sayfa sonu-----------");
        }
    }
}
