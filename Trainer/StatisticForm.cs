using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer
{
    public partial class StatisticForm : Form
    {
        Statistic user_statistic;

        public StatisticForm(User current_user)
        {
            InitializeComponent();
            statFormUsernameTextBox.Text = $"Статистика {current_user.username}";
            user_statistic = new StatisticContext().Statistics.First(stat => stat.user_id == current_user.id);
            totalRoundsTextBox.Text = user_statistic.total_rounds.ToString();
            totalMinutesTextBox.Text = user_statistic.total_time_minutes.ToString();
            totalSymbolsTextBox.Text = user_statistic.total_symbols.ToString();
            totalMistakesTextBox.Text = user_statistic.total_mistakes.ToString();
            averageSymbolsPerMinuteTextBox.Text = user_statistic.average_symbols_in_minute.ToString();
            averageMistakesPerRoundTextBox.Text = user_statistic.average_mistakes_per_round.ToString();
        }

        private void closeStatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            closeStatButton.Focus();
        }
    }
}
