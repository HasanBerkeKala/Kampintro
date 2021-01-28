using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasa Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----------------Metodlar---------------");
            //instance - örnek
            //encapsulation - kapsülleme Ayrı ayrı yazacağım ve düzensiz olacak yapıyı düzenli bir kapsüle sokuyorum.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Armut", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);



        }
    }
}
//Type-safe C# gibi dillerde vardır.(Çalışacağım veri tipini bilmeliyim diyor.)
//Diziler çoğul isimlendirilir.
//Methodlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
//Do not repeat yourself. DRY.-Clean Code(Temiz Kod Yazma teknikleri) Best Practice(Doğru Uygulama Teknikleri)