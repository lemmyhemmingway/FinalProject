using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IProductDal
{
    List<Product> GetAll();
    List<Product> GetAllByCategoryId(int categoryId);
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);

    Product? Find(Product product);
}