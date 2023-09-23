using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    IDataResult<List<Product>> GetAll();
    IResult Add(Product product);
    IDataResult<List<Product>> GetByCategoryId(int id);
    IDataResult<List<Product>> GetByUnitPrice(decimal minPrice, decimal maxPrice);

    IDataResult<List<ProductDetailDto>> GetProductDetails();

    IDataResult<Product> GetById(int id);
}