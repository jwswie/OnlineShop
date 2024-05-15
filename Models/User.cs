namespace ASPNETMVCProject.Models
{
    public class User
    {
        public int USER_ID {  get; set; }
        public string Username {  get; set; }
        public string Email {  get; set; }

        public User(int userId, string username, string email)
        {
            USER_ID = userId;
            Username = username;
            Email = email;
        }
    }
}
