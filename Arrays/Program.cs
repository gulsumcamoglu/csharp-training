using System;

namespace Arrays
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            // 1.yöntem 
            string[] isimler = new[] { "ali", "veli", "demir" };
            Console.WriteLine(isimler.Length);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            // 2.yöntem 
            string[] isimler2 = new string[3];
            isimler2[0] = "ahmet";
            // 3.yöntem
            string[] isimler3 = { "ali" };
            // dimentionals
            int[,] intsDim = new int[2, 3]
            {
                {1,2,3},
                {4,5,6}
            };
            Console.WriteLine(intsDim[1,2]);
            
            

        }
    }
}