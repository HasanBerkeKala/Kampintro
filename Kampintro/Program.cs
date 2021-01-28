using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety= Tip güvenliği.
            //DO NOT REPEAT YOURSELF!
            //kategoriEtiketi bir değer tutucu yani bir takma isimdir.(alias)
            //string metinsel, int tam sayı değerlerdir. Double ondalıklı sayılar içindir.
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Okunu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Okunu Göster");
            }else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);

          

        }
    }
}
