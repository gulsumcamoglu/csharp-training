namespace StaticClasses;

public class Student
{
    public readonly string _SecretName; // genelde read only değişkenler alt tire ile isimlendirilir
    //constructerda değer alır ve sonra değişmez,burada değer setlememiz zorunlu değil
    public const string SecretMail = "aaa";
    //tanımlaama anında değer alı rve sonra değişmez
    public Student(string newName)
    {
        _SecretName = newName;
        //burada setleyebilirim fakat sonra değişmez
        //SecretMail = "aaa"; bunu yapamam yukarda setlediğim ile değiştiremem
    }
    public Student()
    {
        // eğer yukarıda secretName atadıysam ve değiştirmek istemiyosam bu constructer'ı çağırırım
    }
}