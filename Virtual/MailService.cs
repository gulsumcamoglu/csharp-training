using System;
using AcademyBackend.Project;

namespace AcademyBackend.Project
{
    public  class MailService
    {
        public virtual void sendMail() // alt classlarda override edilebilir
        {
            Console.WriteLine("birinci");
        }
    }
}

public class GmailService : MailService //inheritance
{
    public override void sendMail()
    {
        Console.WriteLine("İKİNCİ"); // send mail kullanılacak ama kendine özgü de bişi yapılacaksa
        base.sendMail();// ana class içindeki
    }
}