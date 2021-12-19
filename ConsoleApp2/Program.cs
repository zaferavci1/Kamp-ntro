using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety  tip korumalı
            //Do not repeat your self - Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 10;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }

            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Eşittir");
            }
            

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);
            
            
        }
    }
}
