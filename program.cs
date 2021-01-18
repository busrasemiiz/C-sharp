using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Koç";
            musteri1.YatirimMiktari = 150000;
            musteri1.Süre = " 5 yıl ";
            musteri1.FaizOrani = 0.5;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Busra";
            musteri2.YatirimMiktari = 200000;
            musteri2.Süre = " 4 yıl ";
            musteri2.FaizOrani = 0.4;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Acun";
            musteri3.YatirimMiktari = 500000;
            musteri3.Süre = " 5 yıl ";
            musteri3.FaizOrani = 0.8;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Sabancı";
            musteri4.YatirimMiktari = 250000;
            musteri4.Süre = " 7 yıl ";
            musteri4.FaizOrani = 0.7;

            Musteri [] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Adı : " + musteri.MusteriAdi + " Yatirim Miktari : " + musteri.YatirimMiktari
                    + " Yatırılan Süre : " + musteri.Süre + " Faiz Orani : " + musteri.FaizOrani);

            }

            YeniMusteriler yenimusteri1 = new YeniMusteriler();
            yenimusteri1.MusteriAdi = "ali";
            yenimusteri1.YatirimMiktari = 300000;
            yenimusteri1.Süre = "3 yıl";
            yenimusteri1.FaizOrani = 0.9;

            YeniMusteriler yenimusteri2 = new YeniMusteriler();
            yenimusteri2.MusteriAdi = "ahmet";
            yenimusteri2.YatirimMiktari = 400000;
            yenimusteri2.Süre = "4 yıl";
            yenimusteri2.FaizOrani = 0.7;

            YeniMusteriler[] yenimusteriler = new YeniMusteriler[] { yenimusteri1, yenimusteri2 };
            foreach (YeniMusteriler yenimusteri in yenimusteriler)
            {
                Console.WriteLine("Musteri Adı : " + yenimusteri.MusteriAdi + " Yatirim Miktari : " + yenimusteri.YatirimMiktari
                    + " Yatırılan Süre : " + yenimusteri.Süre + " Faiz Orani : " + yenimusteri.FaizOrani);

            }

            //sıraya eklendi ve yeni müşteri sıraya eklendi yazılarını yazdıran metodlar aşağıdaki gibidir.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle2(yenimusteri1);
            musteriManager.Ekle2(yenimusteri2);
       
        }
    }
}
