namespace GenericClasses.Helper;

public class Tools
{
    public List<T> CreateList<T>(params T[] items)
    {
        return new List<T>(items);
    }
}