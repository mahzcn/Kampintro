using System;

namespace Kampintro
{
	class Program
	{
		static void Main(string[] args)
		{
			
			string katagoriEtiketi = "Katagori ";
			int ogrenciSayisi =9000;
			double faizOrani = 1.35;
			bool sistemeGirisYapmisMi = false;
			double dolarDun = 7.35;
			double dolarBugün = 7.45;

            
        
            if (dolarDun>dolarBugün)
            {
				Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugün)
            {
				Console.WriteLine("artış butonu ");
            }
            else
            {
				Console.WriteLine("sabit butonu");
            }

			if (sistemeGirisYapmisMi == true) 

            {
				Console.WriteLine("kullanıcı ayarları butonu");
            }

            else

            {
				Console.WriteLine("Giriş yap butonu");
            }
			
			
			Console.WriteLine(faizOrani);
			Console.WriteLine(ogrenciSayisi);
			Console.WriteLine(katagoriEtiketi);
			

		}
	}
}
