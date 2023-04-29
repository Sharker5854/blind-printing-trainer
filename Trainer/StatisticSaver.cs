using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    public class StatisticSaver
    {
        // В начале каждого раунда создается экземпляр этого класса
        // И отсюда статистика
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
            user_statistic.total_time_minutes = user_statistic.total_time_minutes + ((double)round_time_seconds / 60);
            user_statistic.total_symbols = user_statistic.total_symbols + symbols_entered;
            user_statistic.average_symbols_in_minute = CalculateNewAverageSymbolsPerMinuteValue();
            user_statistic.total_mistakes = user_statistic.total_mistakes + mistakes;
            user_statistic.average_mistakes_per_round = CalculateAverageMistakesPerRound();
            stat_db_context.SaveChanges();
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
