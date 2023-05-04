using System.Data.Entity;
using System.Data.SQLite;

namespace Trainer
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext() : base(new SQLiteConnection(@"Data Source=trainer_database.db; Version=3"), true)
        {
            Database.SetInitializer<UserContext>(null);
            DbConfiguration.SetConfiguration(new SQLiteConfig());
        }
    }
}
