using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation - Bir model classı'na yeni bir özellik eklendiği zaman diğer sayfalar patlamaz.
            // Urun classına StokAdedi diye yeni bir özellik ekledik. Ve diğer sayfalar hata vermedi.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 45;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun1.StokAdedi = 23;

            Urun[] urunler = new Urun[] { urun1,urun2};

            // type safe -> tip güvenliği. Çalışacağın veri tipini vereceksin.
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun adi : " + urun.Adi);
                Console.WriteLine("Urun Fiyati : " + urun.Fiyati);
                Console.WriteLine("Urun Aciklaması : " + urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("---------Metotlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // Manuel olarak bu şekilde ekleyebilirsin. Ama yarın yönetim dedi ki stok adedi de eklensin ürünlere.
            //Ekle2 metoduna stokAdedi parametresini de eklersin ama Ekle2 yi kullandığın sayfalar patlar.
            //Ekle2 yi çağırdığın her sayfada gidip ürünlere tek tek stokAdedini girmen lazım.
            sepetManager.Ekle2("Armut", "Yeşil", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",12,8);

        }
    }
}
// Don't repeat yourself - DRY - Clean Code - Best Practise