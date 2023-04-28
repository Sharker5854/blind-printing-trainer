using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    public class StatisticSaver
    {
        // В конце каждого раунда создается экземпляр этого класса
        // И отсюда статистика
        public User user;
        public int round_time_seconds;
        public int symbols_entered;
        public int mistakes; // кол-во раз, когда юзер нажал enter и введенный им текст не соответствовал ожидаемому (крч textInput загорелся красным)

        public StatisticSaver(User user)
        {
            this.user = user;
        }

        public void WriteToDb()
        {
            // Заносим данные в БД
            Console.WriteLine(user.username);
            Console.WriteLine(round_time_seconds + "секунд затрачено");
            Console.WriteLine(symbols_entered + "символов введено");
            Console.WriteLine(mistakes + "ошибок допущено");
            ResetValues();
        }

        public int CalculateNewAverageSymbolsPerMinuteValue()
        {
            // Рассчитываем:
            // Получаем из БД из таблицы Statistic значение total_symbols (по внешнему ключу юзера)
            // Прибавляем   symbols_entered
            // Получаем из БД из таблицы Statistic значение total_time_minutes (по внешнему ключу юзера)
            // Прибавляем   round_time_seconds // 60  чтоб получить кол-во минут (подумать над округлением времени раундов, которые длились меньше минуты)
            // Сумму введенных символов делим на сумму всех минут
            return 1;
        }

        private void ResetValues()
        {
            round_time_seconds = 0;
            symbols_entered = 0;
            mistakes = 0;
        }
    }
}
