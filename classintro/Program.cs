using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string adi = "nadir";
            int yas = 34;

            kurs kurs1 = new kurs();

            kurs1.KursAdi = "c#";
            
            kurs1.Egitmen = "Nadir";

            kurs1.IzlenmeOranı = 68;

            kurs kurs2 = new kurs();

            kurs2.KursAdi = "java";

            kurs2.Egitmen = "Sinem";
            kurs2.IzlenmeOranı = 44;

            //Console.WriteLine(kurs1.KursAdi + " ...." + kurs1.Egitmen);

            kurs[] kurslar = new kurs[]
                { kurs1,kurs2
                };
            foreach (var  kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " ....." +  kurs.IzlenmeOranı + " : " + kurs.Egitmen);
                
            }

           // Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}
