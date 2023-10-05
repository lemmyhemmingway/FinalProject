using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete;

[Table("users")]
public class User
{
    [Column("id")]
    public int Id { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("password")]
    public byte[] Password { get; set; }
    public byte[] PasswordHash { get; set; }
    [Column("password_salt")]
    public byte[] PasswordSalt { get; set; }
    [Column("status")]
    public bool Status { get; set; }
    
}