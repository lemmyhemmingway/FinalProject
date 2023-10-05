using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete;

[Table("users")]
public class User : IEntity
{
    [Column("id")]
    public int Id { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    // public byte[] Password { get; set; }
    [Column("password_hash")]
    public byte[] PasswordHash { get; set; }
    [Column("password_salt")]
    public byte[] PasswordSalt { get; set; }
    [Column("status")]
    public bool Status { get; set; }
    [Column("email")]
    public string Email { get; set; }
}