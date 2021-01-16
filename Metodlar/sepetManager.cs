using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class sepetManager
    {
        //naming convetion
        //syntax
        public void Ekle(Urun urun) 
        {
         
            
            
            Console.WriteLine("Tebrikler,Sepete eklendi!! : " + urun.Adi);


        }
        public void Ekle2(string urunAdi, string acıklama, double fiyat, int stockAdeti)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi : "+ urunAdi);
        }


    }
}
