
namespace Trainer
{
    public class Statistic
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int total_time_minutes { get; set; }
        public int total_symbols { get; set; }
        public int average_symbols_in_minutes { get; set; }
        public int average_mistakes { get; set; }

        public Statistic(int user_id, int total_time_minutes, int total_symbols, int average_symbols_in_minutes, int average_mistakes)
        {
            this.user_id = user_id;
            this.total_time_minutes = total_time_minutes;
            this.total_symbols = total_symbols;
            this.average_symbols_in_minutes = average_symbols_in_minutes;
            this.average_mistakes = average_mistakes;
        }

        public Statistic() { }
    }
}
