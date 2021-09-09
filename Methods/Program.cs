using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();   //classın ornegi
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Dağ çileği";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };   // urun arrayi

            //type safe-tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------METOTLAR-----------");


            //encapsulation--ürünün özelliklerini tek bir classa almak,kapsüllemek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//sepete ürün1 ekler
            sepetManager.Ekle(urun2);//sepete urun2 ekler
            sepetManager.Ekle(urun3);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 25);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 3);
            sepetManager.Ekle2("Erik", "Yeşil erik", 12, 1);
        }
    }
}
