using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrununAdı = "Elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.UrununAdı = "Karpuz";
            product2.Fiyati = 89;
            product2.Aciklama = "Kişin Karpuz Olmaz";

            Product[] products = new Product[] { product1, product2 };//dongude yazdırır iken product1. yazarak ikisini ayrı ayrı yazmamak için newledik
            foreach (Product product in products)
            {
                Console.WriteLine(product.UrununAdı+" Fiyati: "+ product.Fiyati +"  "+ product.Aciklama);
            }

            Console.WriteLine("--------------Metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle( product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Armut", "yeşil armut", 15);
            sepetManager.Ekle2("karpuz", "yeşil armut", 15);
            sepetManager.Ekle2("elma", "yeşil armut", 15);
        }
    }
}


// metotlar bizim için tekrar tekrar kullanılabilirliği sağlayan kod blolklarıdır
// Dont repeat yourself - DRY - Clean Code - Best Practice 