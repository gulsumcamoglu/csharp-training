using System;

namespace Strings
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings");
            char c = 'a';
            string name = "ahmet"; // stringler char dizisi old söyledik
            string lastname = "türkoğlu";

            string template = "Merhaba benim adım {0} {1}";
            var result1 = name + " " + lastname;// fazla kullanılmıyor, ama toplanılabilirlik ozelliği var
            
            //
            string result2 = string.Empty; // empty string oluşturmak
            
            Console.WriteLine("char: "+c);
            Console.WriteLine("temlate: "+template);
            Console.WriteLine("var result1 = name +  + lastname;" + result1);
            
            
            // Format metodu
            Console.WriteLine("format metodu-----------");
            result2 = string.Format(template,name,lastname);//
            Console.WriteLine("temlate: "+result2);
            //burada hem empty string oluşturdum hem format metodunu kullandım
            // cumle içerisindeki bir şeyi sonradan set etmek istiyosak
            
            
            Console.WriteLine("-------------------");
            string cumle = "merhaba arkadaşlar, dersimiz devam ediyor              ";
            var sayi = cumle.Length; //char sayısı
            //bosluklarla birlikte virgulleri de char olarak gorur
            
            
            var cumle2 = cumle.Clone(); //aynı cumleden bir tane daha oluşturur
            Console.WriteLine("cumle1: "+cumle2+" sayı: "+sayi);
            // cumle2 clone ile objeye donuşmüş oluyor ve metodlar da ona gore değişiyor
            
            
            
            Console.WriteLine("-------replacement------------");
            var cumle3 = cumle.Replace("dersimiz", "eğitimimiz");
            Console.WriteLine("cumle3: "+cumle3);
            Console.WriteLine("-------------------");
            
            
            var sDizi = cumle.Split(" "); // cumle parçalama, dizi dondurur
            Console.WriteLine(sDizi[0]); // ilk kelimeyi dondurur
            
            var subCumle = cumle.Substring(0, 7);
            // 0 dan 7 ye 
            Console.WriteLine(cumle3.Substring(8)); 
            //8'i atlar ve sonrasını döndürür
            
            Console.WriteLine("sDizi.Length: "+sDizi.Length);
            for (int i = 0; i < sDizi.Length; i++)
            {
                Console.WriteLine(sDizi[i]); 
                Console.WriteLine(subCumle[i]); 
            }
            Console.WriteLine("--------trim-----------");
            var tCumle = cumle.Trim(); // başında sonunda boşluk olan cumlerde cumları kaldırır
            Console.WriteLine(tCumle);
            
            var t1 = cumle.TrimEnd(); // sonundaki boşluğu siler
            Console.WriteLine(t1);
            var t2 = cumle.TrimStart(); // başındaki boşluğu siler
            Console.WriteLine(t2);
            
            Console.WriteLine("-------------------");
            var tCumle2up = tCumle.ToUpper(); // büyütür
            var tCumle2low = tCumle.ToLower(); // Küçültür.
            
            Console.WriteLine("-------------------");
            var varmi1 = cumle.EndsWith("e"); // e ile biten
            var varmi2 = cumle.StartsWith("e"); // e ile başlayan
            Console.WriteLine(varmi1);
            Console.WriteLine(varmi2);

        }
    }
}