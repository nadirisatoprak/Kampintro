using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1  = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("-------- methotlar--------------");


            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil", 12, 2);
            sepetManager.Ekle2("elma", "yeşil elma", 13 , 4);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 15, 5);
            







            // Console.WriteLine("Hello World!");
        }
    }
}
