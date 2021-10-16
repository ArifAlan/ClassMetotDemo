using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri kullanicilar )
        {
            Console.WriteLine("Tebrikler müşteri başarıyla eklenildi.");
            Console.WriteLine("Müşteri adı : " + kullanicilar.Adi);

        }
        public void Silme(Musteri kullanicilar)
        {
            Console.WriteLine("Tebrikler müşteri başarıyla silindi.");
            Console.WriteLine("Müşteri adı : "+ kullanicilar.Adi);
        }

        public void Liste(Musteri kullanicilar)
        {
            Console.WriteLine("Kişiler listelendi.");
            Console.WriteLine("Müşteri adı : " + kullanicilar.Adi);
        }

    }
}
