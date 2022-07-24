using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfacelerde onu implemente eden classların referanslarını tutabilir.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            BavuruManager basvuruManager = new BavuruManager();
            /*basvuruManager.BasvuruYap(ihtiyacKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);*/

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            List<ILoggerService> fileLoggerServices = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService()};
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileLoggerServices);

        }
    }
}
