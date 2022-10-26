using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCustomerDal: ICustomerDal
{
    public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Customer? FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Customer? Find(Customer entity)
    {
        throw new NotImplementedException();
    }
}