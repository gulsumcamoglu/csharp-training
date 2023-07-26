using System;

namespace Loops
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            //....while loop............
            var isAktif = true;
            var k = 1;
            var dongusayisi = 0;
            while (isAktif)
            {
                k++;
                if (k == 10)
                {
                    Console.WriteLine(k);
                    isAktif = false;
                }
            }
            Console.WriteLine("second");
            //....do while loop...........
            var isAktif2 = true;
            var k2 = 1;
            var dongusayisi2 = 0;
            do
            {
                dongusayisi2++;
                Console.WriteLine("Döngü : "+dongusayisi2);
                k2++;
                if (k2==10)
                {
                    Console.WriteLine("i : "+k2);
                    isAktif2 = false;
                }
            } while (isAktif2);
            //.......foreach..................
            string[] isim = new[] { "ali", "veli", "ceren" };
            foreach (var i in isim)
            {
                Console.WriteLine(i);
            }
        }
    }
}