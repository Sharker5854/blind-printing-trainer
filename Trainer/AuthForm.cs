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

        public AuthForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            entered_username = usernameInput.Text;
            // Попробовать достать юзера с таким ником из БД.
            // Если такого нет, то создать новую запись в Users и нулёвую запись в Statistics связанную с новоиспеченным юзером
            Console.WriteLine(entered_username);
            var trainer_form = new TrainerForm();
            trainer_form.Location = this.Location;
            trainer_form.StartPosition = FormStartPosition.Manual;
            trainer_form.FormClosing += delegate { this.Show(); };
            trainer_form.ShowDialog();
            this.Hide();
        }

    }
}
