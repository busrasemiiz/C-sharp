using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Sıraya eklendi : " + musteri.MusteriAdi);
          

        }

        public void Ekle2(YeniMusteriler yenimusteri)

        {
            Console.WriteLine("Yeni Müşteri Sıraya Eklendi : " + yenimusteri.MusteriAdi);

        }
    }
}
