using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri kullanıcılar )
        {
            Console.WriteLine("Tebrikler müşteri başarıyla eklenildi.");
            Console.WriteLine("Müşteri adı : " + kullanıcılar.Adi);

        }
        public void Silme(Musteri kullanıcılar)
        {
            Console.WriteLine("Tebrikler müşteri başarıyla silindi.");
            Console.WriteLine("Müşteri adı : "+kullanıcılar.Adi);
        }

        public void Liste(Musteri kullanıcılar)
        {
            Console.WriteLine("Kişiler listelendi.");
            Console.WriteLine("Müşteri adı : " + kullanıcılar.Adi);
        }

    }
}
