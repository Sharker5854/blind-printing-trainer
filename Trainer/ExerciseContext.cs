using Microsoft.EntityFrameworkCore;

namespace Trainer {

    public class ExerciseContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=exercises.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { Mode = "letter", Value = "а" },
                new Exercise { Mode = "word", Value = "капибара" },
                new Exercise { Mode = "word", Value = "карабин" },
                new Exercise { Mode = "sentence", Value = "Пришел увидел победил." }
            );

    
        }
    }
}