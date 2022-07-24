using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
     /*
     Eğer bir veri üzerinde matematiksel işlem yapmıyorsan, çarpmıyorsan bölmüyorsan, toplamıyorsan o veriyi string olarak tanımlayabilirsin.
     */

     /*
     ÖNEMLİ ! 
     Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, o nesneye ait değilmiş gibi duruyorsa,
     demek ki orada soyutlama hatası yapıyorsun.
     SOLID'in L harfi.
     */

     // Base class.Base classlar referans tutucudur.
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
