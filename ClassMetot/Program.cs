using ClassMetotDemo;
using System;

namespace ClassMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 12345;
            musteri1.Ad = "Hasan";
            musteri1.Soyad ="Mutlu";
            musteri1.Yas = 18;
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 19745;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Mutlu";
            musteri2.Yas = 88;
           
            Musteri musteri3 = new Musteri();
            musteri3.Id = 15645;
            musteri3.Ad = "Cevher";
            musteri3.Soyad = "Mutlu";
            musteri3.Yas = 38;
            
            Musteri musteri4 = new Musteri();
            musteri4.Id = 19605;
            musteri4.Ad = "Ahmet";
            musteri4.Soyad = "Mutlu";
            musteri4.Yas = 48;

            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri1);
            manager.Sil(musteri4);
            manager.liste(musteri1);
           
        }

    }
}
