namespace StaticClasses;

public static class SstTechHelper
{    // static değerin içi değişmiyorsa kullanılır, static sabit işlemler için kullanılır
    // toplama işlemi gibi
    // static classlar prog çalıştığında belleğe kaydolur
    //istenildiğinde kullanılır
    // nesne oluştuamayız new ypamayız
    // direct olarak static classın elemanına ulaşabiliriz
    // değer tanımlayalım
    public static string? Name = "Mehmet";
    // soru işareti bu değerin null yapabilmemizi sağlar
    public static int? Age = null; // diyebilirz
    
    public static int Topla(int x, int y)
    {
        return x + y;
    } // static classın metodları da static olmalıdır.
    
    // public static const string Mail{
    //     get;
    //     set;
    //     
    // } hata verir
    //hata vermesinin sebebi const zaten değişmeyen değerdir
    // get set de veremeyiz static de koyamayız
    
    // örneğini Student classında yaptık
    //---------------Exceptions---------------------
    //hataya neden olabilecek bir kod varsa hatyı exception ile kod içinde ykalamam gerekebilir

    public static ResponceModel Devide(int x, int y)
    {
        if (y==0)// try yerine 
        {
            throw new Exception("Second parameter 0 olamaz");
        }

        try
        {
            var res = x / y;
            ResponceModel result = new ResponceModel();
            result.Result = res;
            result.Message = "Successed";
            return result;
        }
        catch (FormatException e)
        {
            return new ResponceModel();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Send this message to server: {e.Message}");
            return new ResponceModel();
        }
        finally
        {
            Console.WriteLine("");
        }//finally trydan bağımsız çalışır
        //her halukarda çalışırmak istediğim bir kodu yazarım
        
        
    }
    
}

public class ResponceModel
{
    public string Message{get;set;}
    public int  Result{get;set;}
    
}
//bellekte yer kapladığı için static gerekmedikçe tercih edilmez
