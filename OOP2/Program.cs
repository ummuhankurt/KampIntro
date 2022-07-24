using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "222222";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "ABC Kimya";
            musteri2.VergiNo = "5654789532";

            // Musteri classı hem GercekMusterinin referansını tutabiliyor, hem de TuzelMusterinin referansını tutabiliyor.
            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
