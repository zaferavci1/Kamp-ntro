using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pc1 = new Product();
            pc1.marka = "Asus";
            pc1.renk = "Siyah";
            pc1.fıyat = 1000.356;
            pc1.urunCesidi = "";
            pc1.urunCesidi = "DizÜStü";

            Product[] pcs = new Product[] { pc1 };
            foreach (Product pc in pcs )
            {
                Console.WriteLine(pc1.marka +" Fiyat: "+ pc1.fıyat+ " Renk:  "+ pc1.renk +" Çeşidi: "+ pc1.urunCesidi);
            }
        }
    }

    class Product
    {
        public string marka { get; set; }
        public double fıyat { get; set; }
        public string  urunCesidi { get; set; }
        public string renk { get; set; }
    }
}
