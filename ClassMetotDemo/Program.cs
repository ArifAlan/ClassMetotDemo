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

                Console.WriteLine("   bu kadar aq             ");

            }
            
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle();
            musteriManager.Silme();

          
        }
    }
}
