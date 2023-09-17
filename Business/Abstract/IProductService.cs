using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    void Add(Product product);
    List<Product> GetByCategoryId(int id);
    List<Product> GetByUnitPrice(decimal minPrice, decimal maxPrice);

    List<ProductDetailDto> GetProductDetails();
}