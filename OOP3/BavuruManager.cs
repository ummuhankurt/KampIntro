using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BavuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)
        {

            krediManager.Hesapla(); // Gönderiğin class referansının Hesapla() metodunu çalıştıracak.
            /*
             Başvuru bilgilerini değrlendirme.
             KonutKrediManager konutKrediManager = new KonutKrediManager();
             konutKrediManager.Hesapla(); -> Eğer böyle bir şey yaparsan tüm başvuruları konut kredisine bağımlı hale getirirsin. 
            */
            foreach (var log in loggerServices)
            {
                log.Log();
            }

        }
        // Birden fazla kredinin ön bilgilendirmesi istenebilir.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
