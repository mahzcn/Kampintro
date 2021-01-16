using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya yeni başlangıç için temel kurs";
            string kurs3 = "java";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
          

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlamaya yeni başlangıç için temel kurs",
                "java" , "python"} ;

            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti ");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu ");
               
               string a = "new\\baby";
    

            Console.WriteLine(a);

            bool b = true;

            Console.WriteLine(b ? "evet" : "hayır");


            100   16
             x    2
            {

            }
            

        }
    }
}
