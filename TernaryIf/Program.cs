using System;

namespace TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ternary Operator
            // Ternary operatorü şart kontrolünü tek satıra indirir. ?:
            bool evliMi = false;
            // Bu mesaj medeni hale göre bir değer alacak.
            string mesaj = evliMi ? "Evlilere Kampanya" : "Bekarlara Kampanya";
            Console.WriteLine(mesaj);
            #endregion

            #region Ornek1

            //Kullanıcı tarafından girilen sayının aşağıdaki önermelere göre hesabını gerçekleştiren kod.
            //sayı < 3 => sayı*5
            //sayı > 3 && sayı<9 => sayı*3
            //sayı >= 9 && sayi%2 == 0 => sayı*10
            //sayı %2 == 1 => sayı
            Console.WriteLine("Bir sayı giriniz : ");
            string sayi =  Console.ReadLine(); // Kullanıcının girdiği değeri string olarak okuyan komut.
            int _sayi = int.Parse(sayi);

            _sayi = _sayi < 3 ? _sayi * 5 : _sayi < 9 ? _sayi * 3 : _sayi % 2 == 0 ? _sayi * 10 : _sayi; 
            Console.WriteLine(_sayi);
            #endregion
        }
    }
}
