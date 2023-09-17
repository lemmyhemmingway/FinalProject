using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete;

[Table("products")]
public class Product : IEntity
{
    [Column("productid")] public int ProductId { get; set; }

    [Column("categoryid")] public int CategoryId { get; set; }

    [Column("productname")] public string ProductName { get; set; }

    //public short UnitsInStock { get; set; }
    [Column("price")] public short UnitPrice { get; set; }

    [Column("supplierid")] public int SupplierId { get; set; }
    // public override string ToString()
    // {
    // return $"{ProductId} | {CategoryId} | {ProductName} | {UnitsInStock} | {UnitPrice}";
    // }
}