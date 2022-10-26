using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete;

[Table($"products")]
public class Product: IEntity
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }
    [Column("category_id")]
    public int CategoryId { get; set; }
    [Column("product_name")]
    public string ProductName { get; set; }
    [Column("units_in_stock")]
    public short UnitsInStock { get; set; }
    [Column("unit_price")]
    public float UnitPrice { get; set; }


    public override string ToString()
    {
        return $"{ProductId}, {ProductName}, {UnitsInStock}, {UnitPrice}";
    }
}