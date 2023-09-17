using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete;

[Table("orders")]
public class Order: IEntity
{
    [Column("orderid")] public int OrderId { get; set; }
    [Column("customerid")] public int CustomerId { get; set; }
    [Column("employeeid")] public int EmployeeId { get; set; }
    [Column("shipperid")] public int ShipperId { get; set; }
    [Column("orderdate")] public DateTime OrderDate { get; set; }
}