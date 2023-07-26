namespace AbstractClass;

public class AccessModifiersandConstructurs
{
    public string Name { get; set; } 
    // yaratıldığı yerde heryerden erişim sağlanır
    private string Address { get; set; }
    // bunu private yaptığımda eğer bir method ile göndermezsem
    // çağırdığım main classta hata alrıım
    // private sadece kendi class içerinde çağrılır
    protected string Mail { get; set; }
    // yaparsam yine başka classtan çağıramam
    public AccessModifiersandConstructurs(string name,string adress)
    {
        Name = name;
        Address = adress;
    }
    
    // private field diğer classlardan çağırmak için
    public string getAddress(string adr)
    {
        return adr;
    }
    public void SetAdr(string adr){
        Address = adr + "-test";
    }
}

public class specialClass : AccessModifiersandConstructurs
{
    public specialClass(string name, string adress) : base(name, adress)
    {
        // address private old için burada çağıramıyoruz
        Name = name;
        Mail = adress;// mail protected fakat aynı classta çağırabildim

    }
}