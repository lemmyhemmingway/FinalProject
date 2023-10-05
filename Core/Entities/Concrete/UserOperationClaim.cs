using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete;

[Table("user_operation_claims")]
public class UserOperationClaim: IEntity
{
    [Column("id")]
    public int Id { get; set; }
    [Column("user_id")]
    public int UserId { get; set; }
    [Column("operation_id")]
    public int OperationClaimId { get; set; }
    
}