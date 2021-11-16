using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faziOrani = 1.45;

            bool sistemegirisYapmısmı = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemegirisYapmısmı == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
