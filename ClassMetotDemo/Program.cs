using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 35; 
            musteri1.Adi = "Serter";
            musteri1.Soyadi = "Özbek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 34;
            musteri2.Adi = "Hasan";
            musteri2.Soyadi = "Demirci";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 25;
            musteri3.Adi = "Fatma";
            musteri3.Soyadi = "Çağlayan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
            }

            Console.WriteLine("---------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Liste(musteri3);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
        }
    }
}
