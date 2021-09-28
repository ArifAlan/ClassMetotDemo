using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kullanıcı1 = new Musteri();
            kullanıcı1.Id = 1;
            kullanıcı1.Adi = "Engin Demiroğ";
            kullanıcı1.Yasi = 33;
            kullanıcı1.Sehri = "Diyarbakır";

            Musteri kullanıcı2 = new Musteri();
            kullanıcı2.Id = 2;
            kullanıcı2.Adi = "Kaan Gök";
            kullanıcı2.Yasi = 24;
            kullanıcı2.Sehri = "Gaziantep";

            Musteri[] kullancılar = new Musteri[] {kullanıcı1, kullanıcı2};

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
      
                musteriManager.Ekle(kullanıcı1);
                musteriManager.Ekle(kullanıcı2);
                Console.WriteLine(" ");
               
              Console.WriteLine("Müşteri silme : ");
                musteriManager.Silme(kullanıcı1);
               
            musteriManager.Silme(kullanıcı2);
                Console.WriteLine(" ");
                musteriManager.Liste(kullanıcı1);
                musteriManager.Liste(kullanıcı2);
            

        }
    }
}
