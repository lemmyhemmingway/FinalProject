using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{
    private readonly List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product>
        {
            // new() { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15 },
            // new() { ProductId = 2, CategoryId = 2, ProductName = "Kamera", UnitPrice = 20, UnitsInStock = 20 },
            // new() { ProductId = 3, CategoryId = 3, ProductName = "Klavye", UnitPrice = 22, UnitsInStock = 5 },
            // new() { ProductId = 4, CategoryId = 4, ProductName = "Mouse", UnitPrice = 44, UnitsInStock = 53 },
            // new() { ProductId = 5, CategoryId = 5, ProductName = "Sise", UnitPrice = 3, UnitsInStock = 100 },
        };
    }


    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        var productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        if (productToUpdate == null) return;
        productToUpdate.ProductId = product.ProductId;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.UnitPrice = product.UnitPrice;
        // productToUpdate.UnitsInStock = product.UnitsInStock;
    }

    public void Delete(Product product)
    {
        var productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        if (productToDelete != null) _products.Remove(productToDelete);
    }

    public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        throw new NotImplementedException();
    }
}