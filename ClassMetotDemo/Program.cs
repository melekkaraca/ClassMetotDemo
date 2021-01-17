using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1,
                TcKimlik = "11111111111",
                Adi = "Melek",
                Soyadi = "Karaca",
                Email = "kullanici@mail.com",
                GSM = "05554443322",
                Aktiflik = true,
                

            };
            Musteri musteri2 = new Musteri
            {
                Id = 2,
                TcKimlik = "22222222222",
                Adi = "Muhittin",
                Soyadi = "Can",
                Email = "kullanici@mail.com",
                GSM = "05554443333",
                Aktiflik = true,


            };
            Musteri musteri3 = new Musteri
            {
                Id = 3,
                TcKimlik = "33333333333",
                Adi = "Murtaza",
                Soyadi = "Elibol",
                Email = "kullanici@mail.com",
                GSM = "05554443355",
                Aktiflik = true,


            };
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Müşteri listesi eklemesi");
            musteriManager.ListEkle(musteriler);
            Console.WriteLine();
            Console.WriteLine("Güncelleme");
            musteriManager.Guncelle(musteriler[0]);
            Console.WriteLine();
            Console.WriteLine("Silme");
            musteriManager.Sil(musteriler[2]);
            Console.WriteLine();
            Console.WriteLine("Müşteri listeleme");
            musteriManager.Listele(musteriler);
        }
    }
}
