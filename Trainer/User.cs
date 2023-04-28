
namespace Trainer
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }

        public User(string username)
        {
            this.username = username;
        }

        public User() {}
    }
}
