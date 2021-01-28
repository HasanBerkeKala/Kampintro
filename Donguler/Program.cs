using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            //Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız.

            //sayısı fazla olan listelerimizi arraylerde yani dizilerimizde tutarız.
            string[] kurslar = new String[]{ "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C#"};

            for (int i = 0; i < kurslar.Length; i++) //length eleman sayısını komple verir. yani biz oraya rakam göstermeksizin hepsini çalıştıracak. Sayfayı dinamikleştirir.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)   //foreach dizi temelli yapıların tek tek dönmesine yarıyor.Kursları tek tek dolaş demek.
            {                                   //for u genel olarak kullanırız. foreach i hepsinde daha rahat gezinmek için kullanırız.
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
