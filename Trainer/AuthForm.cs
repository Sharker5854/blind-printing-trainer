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
    public partial class AuthForm : Form
    {
        public string entered_username;
        public UserContext user_db_context;

        public AuthForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            user_db_context = new UserContext();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            entered_username = usernameInput.Text.Trim();
            if (entered_username != "")
            {
                User? user = this.GetUserByUsername(entered_username);
                if (user == null)
                {
                    user = this.CreateNewUser(entered_username);
                }
                this.Hide();
                var trainer_form = new TrainerForm(user);
                trainer_form.StartPosition = FormStartPosition.CenterScreen;
                trainer_form.FormClosed += (s, args) => this.Close();
                trainer_form.Show();
            }
            else
            {
                authTextBoxIndicator.BackColor = ColorTranslator.FromHtml("#CD5C5C");
            }
            
        }

        public User? GetUserByUsername(string username)
        {
            User? user = user_db_context.Users.FirstOrDefault(user => user.username == username);
            return user;
        }

        public User CreateNewUser(string username)
        {
            User new_user = new User(username);
            user_db_context.Users.Add(new_user);
            user_db_context.SaveChanges();
            int new_user_id = this.GetUserByUsername(username).id;
            Statistic new_statistic = new Statistic(new_user_id, 0, 0.0, 0, 0, 0, 0);
            StatisticContext stat_db_context = new StatisticContext();
            stat_db_context.Statistics.Add(new_statistic);
            stat_db_context.SaveChanges();
            return new_user;
        }

    }
}

















