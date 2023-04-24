namespace Trainer
{
    public partial class TrainerForm : Form

        /*
         TODO:
         Найти БД со словами и преложениями
         Сохранить её локально
         Выводить слова/предложения в exerciseTextLabel
         Сравнивать введенное значение из textInput с нужным (после каждого введенного символа)
        */
    {
        int timeLeft = 30;
        string mode = "letter";
        int quantity = 10;

        public TrainerForm()
        {
            InitializeComponent();
            textInput.KeyPress += new KeyPressEventHandler(CheckEnterKeyPressing);
            exerciseTextBox.ForeColor = ColorTranslator.FromHtml("#CD5C5C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            exerciseTextBox.Text = textInput.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 1)
            {
                changeTimerLabel();
            }
            else
            {
                timeUp();
            }
        }

        private void changeTimerLabel()
        {
            timeLeft -= 1;
            if (5 <= timeLeft && timeLeft <= 20)
            {
                timerLabel.Text = timeLeft + " секунд";
            }
            else if (Convert.ToString(timeLeft)[^1] == '1')
            {
                timerLabel.Text = timeLeft + " секунда";
            }
            else if (Convert.ToString(timeLeft)[^1] == '2' || Convert.ToString(timeLeft)[^1] == '3' || Convert.ToString(timeLeft)[^1] == '4')
            {
                timerLabel.Text = timeLeft + " секунды";
            }
            else
            {
                timerLabel.Text = timeLeft + " секунд";
            }
        }

        private void timeUp()
        {
            timerLabel.Text = "Время вышло!";
            exerciseTextBox.Text = "Здесь будет текст упражнений...";
            exerciseTextBox.Enabled = false;
            startButton.Enabled = true;
            textInput.Text = "";
            textInput.Enabled = false;
            textInput.BackColor = ColorTranslator.FromHtml("#C0C0C0");
            textInput.Cursor = Cursors.Cross;
            startButton.BackColor = ColorTranslator.FromHtml("#FFD700");
            exerciseTimer.Stop();
            radioPanel.Enabled = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            startExercise();
        }

        private void startExercise()
        {
            exerciseTextBox.Enabled = true;
            exerciseTextBox.Text = mode; // тут будем подтягивать слова из БД
            timeLeft = Convert.ToInt32(Seconds.Value);
            timerLabel.Text = timeLeft + " секунд";
            exerciseTimer.Start();
            startButton.Enabled = false;
            startButton.BackColor = ColorTranslator.FromHtml("#C8D3D5");
            quantity = Convert.ToInt32(Quantity.Value);
            textInput.Enabled = true;
            textInput.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            textInput.Cursor = Cursors.IBeam;
            textInput.Select();
            radioPanel.Enabled = false;
        }

        private void CheckEnterKeyPressing(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                textInput.Text = "";
            }
        }

        private void modeRadio1_CheckedChanged(object sender, EventArgs e)
        {
            mode = "letter";
        }

        private void modeRadio2_CheckedChanged(object sender, EventArgs e)
        {
            mode = "word";
        }

        private void modeRadio3_CheckedChanged(object sender, EventArgs e)
        {
            mode = "sentence";
        }
    }
}