using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete;

[Table("operation_claims")]
public class OperationClaim: IEntity
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    
}