using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Trainer
{
    public class StatisticSaver
    {
        public User user;
        private Statistic user_statistic;
        public int round_time_seconds;
        public int symbols_entered;
        public int mistakes;
        private StatisticContext stat_db_context;

        public StatisticSaver(User user)
        {
            this.user = user;
            stat_db_context = new StatisticContext();
        }

        public void WriteToDb()
        {
            user_statistic = stat_db_context.Statistics.First(stat => stat.user_id == user.id);
            user_statistic.total_rounds = user_statistic.total_rounds + 1;
            user_statistic.total_time_minutes = Math.Round(user_statistic.total_time_minutes + ((double)round_time_seconds / 60), 1);
            user_statistic.total_symbols = user_statistic.total_symbols + symbols_entered;
            user_statistic.average_symbols_in_minute = CalculateNewAverageSymbolsPerMinuteValue();
            user_statistic.total_mistakes = user_statistic.total_mistakes + mistakes;
            user_statistic.average_mistakes_per_round = CalculateAverageMistakesPerRound();
            stat_db_context.SaveChanges();
            Console.WriteLine(stat_db_context.Database.Connection.ConnectionString);
            Console.WriteLine(user_statistic.total_rounds);
            Console.WriteLine(user_statistic.total_time_minutes);
            Console.WriteLine(user_statistic.total_symbols);
            Console.WriteLine(user_statistic.average_symbols_in_minute);
            Console.WriteLine(user_statistic.total_mistakes);
            Console.WriteLine(user_statistic.average_mistakes_per_round);
            ResetValues();
        }

        public int CalculateNewAverageSymbolsPerMinuteValue()
        {
            int total_symbols = user_statistic.total_symbols + symbols_entered;
            double total_time_minutes = user_statistic.total_time_minutes + ((double)round_time_seconds / 60);
            return (int)Math.Round((double)total_symbols / total_time_minutes);
        }

        public int CalculateAverageMistakesPerRound()
        {
            int total_mistakes = user_statistic.total_mistakes + mistakes;
            int total_rounds = user_statistic.total_rounds + 1;
            return (int)Math.Round((double)total_mistakes / total_rounds);
        }

        private void ResetValues()
        {
            user_statistic = null;
            round_time_seconds = 0;
            symbols_entered = 0;
            mistakes = 0;
        }
    }
}
