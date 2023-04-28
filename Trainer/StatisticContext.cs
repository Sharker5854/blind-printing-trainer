using System.Data.Entity;
using System.Data.SQLite;

namespace Trainer
{
    public class StatisticContext : DbContext
    {
        public DbSet<Statistic> Statistics { get; set; }

        public StatisticContext() : base(new SQLiteConnection(@"Data Source=./trainer_database.db; Version=3"), true)
        {
            Database.SetInitializer<StatisticContext>(null);
            DbConfiguration.SetConfiguration(new SQLiteConfig());
        }
    }
}
