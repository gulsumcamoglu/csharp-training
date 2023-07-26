namespace GenericClasses.Abstract;

public interface IRepository<T> where T:class,IEntity, new()// kısıt veriyoruz
// T bir referans tipli oluşacak ve newlenebilen bir şey olmalı
{
    public void Add(T model);
    public void Delete(T model);

    List<T> GetList();
}