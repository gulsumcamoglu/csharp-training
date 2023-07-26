using System;

namespace Method
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Login("a@gmail.com","1234",20);
            Console.WriteLine("-----Bir------");
            string email = "a@gmail.com";
            Register(ref email,"q"); // tanımlamadan gonderemeyiz
            Console.WriteLine("-----İki------");
            string email2;
            Register(out email2, "1234", false);
            Console.WriteLine("dışardaki email" + email2);
            Console.WriteLine("diğer email" + email);
            // ref çağrılan bir metodun iletilen parametreyi güncellemesi gerektiğinde kullanılır.
            //out iletilen birden çok parametreyi güncellemesi gerektiğinde kullanılır.
            //ref anahtar sözcüğü, verileri çift yönlü olarak iletmek için kullanılır.
            //out anahtar sözcüğü tek yönlü olarak veri almak için kullanılır.
            
            
            //---------------------iki farklı method çağırma------------------------------------
            int a = 10;
            int b = 20;
            int c = 30;

            int[] nums = new[] { 10, 20, 30 };
            ParamMethod(a,b,c,40,50);
            Console.WriteLine("---------");
            ParamMethod(nums);
            Console.WriteLine("---is aktif metodu------");
            IsActive();
            //--------------iki farklı tuple metod çağırma-----------------
            var result = AddBasket();
            Console.WriteLine(result.Item1); 
            Console.WriteLine(result.Item2); 
            var (isim, sayi) = AddBasket();
            Console.WriteLine(isim); 
            Console.WriteLine(sayi);  
            Console.ReadLine();
            
        }

        private static bool IsActive()
        {
            Console.WriteLine("Aktif");
            return true;
        }

        private static void Login(string email, string sifre, int yas, bool aktifMi = false)
        {
            if (email =="a@gmail.com")
            {
                aktifMi = false;
            }

            if (!aktifMi)
            {
                Console.WriteLine("A aktif değil");
            }
        }

        private static void Register(ref string email, string sifre)
        {
            email = "z@gmail.com";
            Console.WriteLine("içerdeki email"+email);
        }
        private static void Register(out string email, string sifre, bool calisan)
        {
            email = "email2@gmail.com";
            if (calisan)
            {
                email = "";
            }
            Console.WriteLine("içerdeki email"+email);
        }
        private static void ParamMethod(params int[] numbers) //params? int bir array adı numbers
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        
        private static Tuple<string, int> AddBasket() // tuple return eder
        {
            return Tuple.Create("SSTTEK Akademi", 100); // tuple creation
        }
    }
}