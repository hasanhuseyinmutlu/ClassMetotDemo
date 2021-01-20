using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri ekle)
        {
            Console.WriteLine(ekle.Ad +"Adı:" +ekle.Soyad +"Soyadı:"+ekle.Id +"Id:");
            Console.WriteLine();
        }
        public void Sil(Musteri sil)
        {
            Console.WriteLine(sil.Ad + "Adı:" + sil.Soyad + "Soyadı:" + sil.Id + "Id:");
            Console.WriteLine();

        }

    }

}
