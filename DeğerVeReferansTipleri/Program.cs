using System;

namespace DeğerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // int - decimal -float-double bool = değer tip
            // array clas interface =referans tip
            //stock==  sayi1= 10 sayi birin değeri 10   sayi2=30 sayi ikinin değeri 30  sayi1=sayi2 sadece değerler atanır 
            //ve sayi 1 30 olur sayi2=65 olsada sonuç 30 olur
            
             //heap==  sayilar 1  101[10,20,30] sayilar2 =102/[100,200,300] sayilar1=sayilar2 sayilar1 in ref numarası 102 olur

             int sayi1 = 10;
             int sayi2 = 30;

            sayi1 = sayi2;
             sayi2 = 65;
            int[] sayilar1 = new int[] { 10, 20, 30 };

            int[] sayilar2 = new int[] { 100, 200, 300 };
                sayilar1 = sayilar2;
                sayilar2[0] = 999;
            Console.WriteLine(sayilar1[1]);

        }
    }
}
