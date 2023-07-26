using GenericClasses.Abstract;

namespace GenericClasses;

public class Product : IEntity
{
    public int Id { get; set; }
    public string ProductName { get; set; }
}