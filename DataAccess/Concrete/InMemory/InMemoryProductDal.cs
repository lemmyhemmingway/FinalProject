using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal: IProductDal
{
    private List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product>
        {
            new Product {ProductId = 1, CategoryId = 1, ProductName = "First", UnitPrice = 15, UnitsInStock = 15},
            new Product {ProductId = 2, CategoryId = 2, ProductName = "Second", UnitPrice = 22, UnitsInStock = 24},
            new Product {ProductId = 3, CategoryId = 3, ProductName = "Third", UnitPrice = 200, UnitsInStock = 33},
            new Product {ProductId = 4, CategoryId = 4, ProductName = "Fourth", UnitPrice = 4000, UnitsInStock = 77},
            new Product {ProductId = 5, CategoryId = 5, ProductName = "Fifth", UnitPrice = 7722, UnitsInStock = 357},
            new Product {ProductId = 6, CategoryId = 6, ProductName = "Sixth", UnitPrice = 444, UnitsInStock = 1515},

        };
    }
    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAllByCategoryId(int categoryId)
    {
        return _products.Where(s => s.CategoryId == categoryId).ToList();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        var p = Find(product);
        if (p != null) 
        {
            p.CategoryId = product.CategoryId;
            p.ProductName = product.ProductName;
            p.UnitPrice = product.UnitPrice;
            p.UnitsInStock = product.UnitsInStock;
        }
    }

    public void Delete(Product product)
    {
        var p = Find(product);
        if (p != null) _products.Remove(p);
    }

    public Product? Find(Product product)
    {
        return _products.SingleOrDefault(s => s.ProductId == product.ProductId);
    }
}