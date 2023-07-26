using GenericClasses.Abstract;

namespace GenericClasses;

public class Customer : IEntity
{
    public int Id { get; set; }
    public string ProductName { get; set; }
}