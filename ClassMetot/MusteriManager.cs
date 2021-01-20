using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri ekle)
        {
            Console.WriteLine(ekle.Ad + " " +ekle.Soyad + " bilgileri eklenmiştir.");
        }
        public void Sil(Musteri sil)
        {
            Console.WriteLine(sil.Ad + " " + sil.Soyad + " Bilgileri Silinmiştir.");

        }
        public void liste(Musteri list)
        {
            Console.WriteLine(list.Ad + " " + list.Soyad + " Bilgileri Listelenmiştir.");
        }


    }

}
