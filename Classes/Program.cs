using System;

namespace Classes
{
    
    class Program
    {
        // classlar en temel yapı ve işleri bolmek,gruplamak ve yonetmek için kul.
        // 
        static void Main(string[] args)
        {
            
            //instance oluşturmak,userdan oluşturuyoruz
            User user1 = new User();
            user1.FirstName = "galsum"; // upper case olunca contains metodu çalışmadı
            user1.Email = "gizem@gmail.com";
            user1.LastName = "yilmaz";
            var x = user1.FirstName;
            Console.WriteLine(x);
            //ikinci kullanım:
            User user3 = new User()
            {
                //control space
                Email = "kdjfs",
                FirstName = "d",
                LastName = "d"
                    
            }; // iyi bi kullanım o sınııfn içindeki bir property set edilecekse diğeri
            
            //üçüncü kullanım:
            User user4 = new User()
            {
                //control space
                
                FirstName = "d", // burada property içerisindeki set blogu çalışır
                LastName = "d"
                    
            };
            user4.Email = "kdjfs"; // sonradan birini tanımlayabilirim

            var name = user4.FirstName; // burada da get blogu çalışıoyr
            //-------------------------------------
            User user2 = new User();
            //IuserService i = new IuserService();
            //instance oluşturulamaz interfaceden
            EmailService emailService = new EmailService();
            emailService.SendMail(new GmailService());
            
            
            

        }
    }
}