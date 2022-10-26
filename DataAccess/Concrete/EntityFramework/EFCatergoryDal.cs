using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EFCatergoryDal: ICategoryDal
{
    public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }

    public Category? FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Category? Find(Category entity)
    {
        throw new NotImplementedException();
    }
}