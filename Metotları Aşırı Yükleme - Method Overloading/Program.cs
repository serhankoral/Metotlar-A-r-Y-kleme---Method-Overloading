using System;

namespace Metotları_Aşırı_Yükleme___Method_Overloading
{
    class Program
    {
        /*
         * Overloading bir fonksiyonu farklı parametreler ile yeniden yazma demektir
         *constructor larda da kullanılır class için birden fazla oluşturma parametresi kullanılır 
         *bir fonksiyon tanımlanır ike static tanımlanmalı ki işlem blogu içerisinde kullanılabilsin
         */
        static void Main(string[] args)
        {
            Console.WriteLine(topla(5, 4));
            Console.WriteLine(topla(5, 4, 5));
            Console.WriteLine(topla(5.2,4));

        }
        static int topla(int a, int b)
        { return a + b; }
        static int topla(int a, int b, int c)
        { return a + b + c; }

        static double topla(double a, double b)
        { return a+b;}

    }
}
