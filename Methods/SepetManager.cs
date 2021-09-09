using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun) // Urun tipinde urun takma adlı parametre
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
