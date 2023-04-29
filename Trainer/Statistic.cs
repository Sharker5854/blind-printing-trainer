
namespace Trainer
{
    public class Statistic
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int total_rounds { get; set; }
        public double total_time_minutes { get; set; }
        public int total_symbols { get; set; }
        public int average_symbols_in_minute { get; set; }
        public int total_mistakes { get; set; }
        public int average_mistakes_per_round { get; set; }

        public Statistic(
            int user_id, 
            int total_rounds, 
            double total_time_minutes, 
            int total_symbols, 
            int average_symbols_in_minute, 
            int total_mistakes, 
            int average_mistakes_per_round
            )
        {
            this.user_id = user_id;
            this.total_rounds = total_rounds;
            this.total_time_minutes = total_time_minutes;
            this.total_symbols = total_symbols;
            this.average_symbols_in_minute = average_symbols_in_minute;
            this.total_mistakes = total_mistakes;
            this.average_mistakes_per_round = average_mistakes_per_round;
        }

        public Statistic() { }
    }
}
