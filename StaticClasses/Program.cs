using System;

namespace StaticClasses
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var result = SstTechHelper.Topla(1, 2);
            // static class içine static olmayan bir şey tanımlarsak hata verir
            
            //exception kodu denemeleri
            var devideResult = SstTechHelper.Devide(1 , 0);
            // çalıştırdığımızda 1 0'a bölünmeyeceği için 
            // bir hata oluşur. bunu yaakalamak için try catch kullanalım
            var firstValue = Convert.ToInt32(Console.ReadLine());
            var secondValue = Convert.ToInt32(Console.ReadLine());
            //Convert static helper class
            var result2 = SstTechHelper.Devide(firstValue , secondValue);
            Console.WriteLine(result2);
            Console.WriteLine($"Result: {result2.Result} Message: {result2.Message}");
        }
    }
}