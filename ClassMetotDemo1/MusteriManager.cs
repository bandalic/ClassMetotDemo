using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi" + " " + musteri.MusteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri sil " + musteri.MusteriId);
        }

    }
}
