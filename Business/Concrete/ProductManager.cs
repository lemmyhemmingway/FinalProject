using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }


    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public List<Product> GetByCategoryId(int id)
    {
        return _productDal.GetAll(p => p.CategoryId == id);
    }

    public List<Product> GetByUnitPrice(decimal minPrice, decimal maxPrice)
    {
        return _productDal.GetAll(p => p.UnitPrice > minPrice && p.UnitPrice < maxPrice);
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        return _productDal.GetProductDetails();
    }
}