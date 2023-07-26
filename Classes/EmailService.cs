namespace Classes;

public class EmailService
{
    public void SendMail(IMailService mailModel)
    {
        mailModel.sendMail();
    }
        
    public void SendMails(IMailService mailModel)
    {
        mailModel.sendMail();
    }
    
}