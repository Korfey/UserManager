namespace UserManager.Models
{
    public class UserViewModel
    {
        public IEnumerable<UserModel> UserModels { get; set; } = new List<UserModel>();
    }
}
