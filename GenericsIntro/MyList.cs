using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{

    // Çalışacağın veri tipi -> T
    // Ben MyList'imde T ile çalışmak istiyorum demek.
    // Programcı bu class'ı new'lerken hangi tipi gönderecekse T o olacak.
    class MyList<T>
    {
       T[] items; // MyClass new'lendiğinde bu itemsin oluşturulması lazım. O yüzden constructor olşturulması lazım.
        public MyList()
        {
            // Bu class new'lenirse constructor otomatik olarak oluşur.
            items = new T[0]; // 0 elemanlı dizi oluştu.
        }
        public void Add(T item)
        {
            T[] tempArray = items; // Gecici dizinin referansı items'in referansı.Artık elemanlar kaybolmayacak.
            items = new T[items.Length + 1]; // newlendiği zaman yeni referans numarası alır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
