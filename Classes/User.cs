namespace Classes;

public class User : IuserService //pascal case metod ve sınıflarda
{
    //field and properties
    private string a = " "; //field
    //private yaparak sadece bu class içerisinde kullanırız
    private string firstName; //camel case field 
    private string lastName;
    private string email;

    public string FirstName //propertylerde pascal case
    {
        get
        {
            return firstName;
        }
        set
        {
            var varmi = value.Contains("a");
            if (varmi)
            {
                firstName = "merhaba" + value;// set'e gelen value
            }
            else
            {
                firstName = value;
            } 
        }
    } // property oluştururken pro yazarak tab ile hılzı oluşturma

    //public diğer class'lardan çağrılabilir
    public string LastName { get; set; }
    public string Email { get; set; } 
    //get set ne ve neden yazıyoruz? 
    public User getByUser()
    {
        throw new NotImplementedException();
    }// interfacenin içerisindeki bu metodun taslağı 
    // buradaki gövdesi ve kişiselleştirebileceğiz
    
    
    
}