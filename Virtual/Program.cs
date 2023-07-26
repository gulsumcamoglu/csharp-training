using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            GmailService g = new GmailService();
            g.sendMail();
        }
    }
}