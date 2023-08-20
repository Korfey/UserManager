namespace UserManager.Models
{
    public record class UserModel(int Id, string Name, string Email, string RegistationDate, string LastLoginDate, Status.IsActive IsActive);
}
