using Core.Entities;

namespace Entities.DTOs;

public class ProductDetailDto: IDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public short UnitPrice { get; set; }

    public override string ToString()
    {
        return $"{ProductName} | {CategoryName}";
    }
}