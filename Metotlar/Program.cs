using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Kıpkırmızı";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 5;
            product2.Aciklama = "Keleksiz";

            Product[] products = new Product[]
            { product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.add(product1);
            sepetManager.add(product2);


        }
    }
}
