using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EFProductDal: IProductDal
{
    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        using (var northwindContext = new NorthwindContext())
        {
            return filter == null
                ? northwindContext.Set<Product>().ToList()
                : northwindContext.Set<Product>().Where(filter).ToList();
        }
    }
    
    
    public Product? Get(Expression<Func<Product, bool>> filter)
    {
        using (var northwindContext = new NorthwindContext())
        {
            return northwindContext.Set<Product>().SingleOrDefault(filter);
        }
    }

    public void Add(Product entity)
    {
        // IDisposable pattern implementasyonu
        using (var northwindContext = new NorthwindContext())
        {
            var addedEntity = northwindContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            northwindContext.SaveChanges();
        }
    }

    public void Update(Product entity)
    {
        
        using (var northwindContext = new NorthwindContext())
        {
            var updatedEntity = northwindContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            northwindContext.SaveChanges();
        }
    }

    public void Delete(Product entity)
    {
        
        using (var northwindContext = new NorthwindContext())
        {
            var deletedEntity = northwindContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            northwindContext.SaveChanges();
        }
    }

    public Product? FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Product? Find(Product entity)
    {
        throw new NotImplementedException();
    }
}