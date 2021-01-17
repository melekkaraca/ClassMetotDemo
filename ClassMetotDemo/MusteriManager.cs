using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("İşlem başarılı. " +musteri.Adi + " " + musteri.Soyadi + " isimli müşteri eklenmiştir.");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine($"İşlem başarılı. {musteri.Adi } {musteri.Soyadi } isimli müşteri güncellenmiştir.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"İşlem başarılı. {musteri.Adi } {musteri.Soyadi } isimli müşteri silinmiştir.");
        }
        public void ListEkle(Musteri[] musteriler)
        {
            
            foreach (var item in musteriler)
            {
                Ekle(item);
            }
        }
        public void Listele(Musteri[] musleriler)
        {
            int sayac = 0;
            foreach (var item in musleriler)
            {
                sayac++;
                Console.WriteLine($"{sayac}. müşteri: Id = {item.Id}, Adı= {item.Adi}, Soyadı = {item.Soyadi}");
            }
        }
    }
}
