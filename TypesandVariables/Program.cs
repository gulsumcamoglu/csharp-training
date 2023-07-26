using System;

namespace TypesandVariables
{
    enum akademi 
    {
        battal,merve
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veri Tipleri");
            //int veri tipi 32 bit 
            int tip1 = 1;
            //long veri tipi 64 bit
            long tip2 = 1;
            //short veri tipi 16 bit
            short tip3 = 1;
            //byte veri tipi 8 bit, Byte değişkeni 0 ile 255 arasında pozitif değer depolayabilmektedir.
            //
            byte min = byte.MinValue;
            byte max = byte.MaxValue;
            double ondalikSayi = 5.2; // 64 bit
            decimal decimalSayi = 100.8M; //Double ile ayırmak için M koyarız
            //virgulden sonra 19 karakter yazabiliriz
            //double'a göre daha hassastır.
            //her verilen değeri verilmesi gerektiği kadar yer verilmemesi
            //uzun vadeli performans eksikliklerine sebep olur
            var variable = 5; //verilen değerin tipini alır
            //--------ENUM------------
            var kisi = akademi.battal;
            Console.WriteLine("int veri tipi "+tip1);
            Console.WriteLine("long veri tipi "+tip2);
            Console.WriteLine("short veri tipi "+tip3);
            Console.WriteLine("min byte değeri "+min+" max byte değeri "+max);
            Console.WriteLine("Ondalık "+ondalikSayi+" decimal sayı "+decimalSayi);
            Console.WriteLine("variable "+variable+" enum: "+kisi);
        }
    }
}