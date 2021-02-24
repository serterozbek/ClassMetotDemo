using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgi listeleme başarılı:" + musteri.Adi + " "+ musteri.Soyadi+ " "+musteri.Id);
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ekleme işlemi başarılı:" + musteri.Adi+" "+musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemi başarılı:"+musteri.Adi+" "+musteri.Soyadi);
        }
    }
}
