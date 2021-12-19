using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
        //encapsulatıon
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklediniz: "+ product.UrununAdı +" "+ product.Fiyati);

        }
        public void Ekle2(string productName, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklediniz: " + productName + " " + fiyat);
        }
            
    }
}
