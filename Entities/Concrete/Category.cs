using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete;

[Table("categories")]
public class Category : IEntity
{
    [Column("categoryid")] public int CategoryId { get; set; }
    [Column("categoryname")] public string CategoryName { get; set; }
}