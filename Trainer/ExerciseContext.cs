using System.Data.Entity;
using System.Data.SQLite;

namespace Trainer {

    public class ExerciseContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }

        public ExerciseContext() : base(new SQLiteConnection(@"Data Source=trainer_database.db; Version=3"), true)
        {
            Database.SetInitializer<ExerciseContext>(null);
            DbConfiguration.SetConfiguration(new SQLiteConfig());
        }
    }
}