namespace ajaxMadeEasy.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public UserTypes Type { get; set; }
    }

    public enum UserTypes
    {
        User = 1,
        PowerUser = 2,
        Admin = 3
    }

    public class UpdateUser
    {
        public int UserId { get; set; }
        public UserTypes Type { get; set; }
    }
}