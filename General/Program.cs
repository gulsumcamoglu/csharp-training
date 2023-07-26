using System;
using System.Reflection.Metadata;

namespace General
{
    class Program
    {
        static void Main(string[] args)
        {
           // as - is
           Object[] dizi = { "kamet", "onur", 5, 99, false, "nisa" };
           foreach (var i in dizi)
           {
               if (i is string)
               {
                   Console.WriteLine("bu str "+ i);
               } 
               if (i is string)
               {
                   string x = i as string; // obje stringinden normal stringe çeviriyorum
                   // ama objenin de string olması gerek
                   Console.WriteLine("bu str "+ x);
               } 
           }
           
           // tip dönüşümleri ve cast etmeler
           //implicit-kapalı dönüşüm(veri kaybı yaşamayız)
           //explicit-açık dönüşüm(data kaybı olabilir)
           int sayi = 100;
           long sayiLong = (int)sayi; // long intten daha büyük old için kayıp olmaz 

           long sayi2 = 500;
           int sayiInt = (int)sayi2; // int casti olmazsa hata verir

           int sayi3 = 300;
           byte sayiByte = (byte)sayi3;// 44 döner
           
           // boxing value => reference
           // unboxing reference => value

           int deger = 100;
           Object obj = deger; //boxing
           Object obj2 = 200;
           int d = (int)obj2; //unboxing

           string pagekey = Settings.PAGEKEY; // const değerini newleme yapmadan çağırdık
           
           // casting 
           long sayi5 = 500;
           int sayiInt2 = (int)sayi5;

           int sayiInt3 = Convert.ToInt32(sayi5);
           bool isAktif = Convert.ToBoolean(1);
           
           // parse,tryparse

           var ss = int.Parse("500"); // strin içinde eğer bir int varsa pars edilir
           var yeniSayi = int.Parse("k4"); // çeviremediği için hata verir
           int result;
           var çevirdiMi = int.TryParse("5", out result);

           string s1 = sayi5.ToString();
           Console.WriteLine(s1);












        }
    }
    
    //const : sabit ve değiştirilemeyen bir değer atama
    //property,stack,arraylere uygulanmaz
    //class,method array oluşturulmaz ama value type uygulanır
    class Settings
    {
        private readonly string _deger;
        public const string PAGEKEY = "BISI";// HERHANGİ BİR NEWLEME YAPMADAN ÇAĞRILABİLİR
        public Settings(string deger)
        {
            _deger = deger; // readonly değeri sadece constructer içerisinde setlenir
            // sonrasında herhangi bir update yapılmaz
        }
    }
}