using GenericClasses.Abstract;

namespace GenericClasses;

public class CustomerService : IRepository<Customer>
{
    public void Add(Customer model)
    {
        
        throw new NotImplementedException();
    }

    public void Delete(Customer model)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetList()
    {
        throw new NotImplementedException();
    }
}