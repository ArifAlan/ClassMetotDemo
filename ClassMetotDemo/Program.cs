using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kullanici1 = new Musteri();
            kullanici1.Id = 1;
            kullanici1.Adi = "Engin Demiroğ";
            kullanici1.Yasi = 33;
            kullanici1.Sehri = "Diyarbakır";

            Musteri kullanici2 = new Musteri();
            kullanici2.Id = 2;
            kullanici2.Adi = "Kaan Gök";
            kullanici2.Yasi = 24;
            kullanici2.Sehri = "Gaziantep";

            Musteri[] kullancılar = new Musteri[] { kullanici1, kullanici2 };

            foreach (var musteri in kullancılar) 
            {
                Console.WriteLine("Müşteri Id : "+musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri yaşı : " + musteri.Yasi);
                Console.WriteLine("Müşteri şehri : " + musteri.Sehri);

                Console.WriteLine("               ");

            }
            
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Müşteri Ekleme : ");
      
                musteriManager.Ekle(kullanici1);
                musteriManager.Ekle(kullanici2);
                Console.WriteLine(" ");
               
              Console.WriteLine("Müşteri silme : ");
                musteriManager.Silme(kullanici1);
               
            musteriManager.Silme(kullanici2);
                Console.WriteLine(" ");


            Console.WriteLine("Kullancı Listeleme : ");
                musteriManager.Liste(kullanici1);
                musteriManager.Liste(kullanici2);
            

        }
    }
}
