namespace Classes;

public interface IuserService
{
    //I ile başlaması interface old belirtmek amacıyla yaptık
    //interface amacı temel bir nesne oluşturmak, iskelet gibi
    // classları bu ana iskeletten üretmek için kullanırız
    // temel bir nesne de diyebiliriz
    //interface tek başına bir şey ifade etmez ve classlar tarafından çağırıldıkça anlam 
    //kazanır,soyuttur ve classlar somutlaştırır.

    User getByUser();
}
