using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{
    public List<ProductDetailDto> GetProductDetails()
    {
        using (var context = new NorthwindContext())
        {
            var result = from p in context.Products
                join c in context.Categories
                    on p.CategoryId equals c.CategoryId
                select new ProductDetailDto
                {
                    ProductId = p.ProductId,
                    CategoryName = c.CategoryName,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice


                };

            return result.ToList();
        }
    }
}