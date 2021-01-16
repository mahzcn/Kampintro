using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Açiklama = "Bafra karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 } ;


            foreach  (Urun urun in urunler)
            {



                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("---------------");


            }
            //instance - örnek
            //encapsulation

            Console.WriteLine("---------METODLAR-----------");

            sepetManager sepetManager = new sepetManager() ;
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil armut ", 12,2);
            sepetManager.Ekle2("Elma", "Yeşil elma ", 12,3);
            sepetManager.Ekle2("Kavun", "Bafra  kavunu ", 12,4);




        }
    }
}

//dont repeat yourself =DRY - Clean code - best practics(doğru uygulama)