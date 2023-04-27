using System;

namespace Trainer
{
    public partial class TrainerForm : Form

        /*
         TODO:
         ��������� ���������� �� exerciseTextBox
         ������ ���� ��� ������� �� Enter
         ����������� (������ ���, ����� ��������� ���������� ��� ���� ������ ������)
         ������ ���������� � ��
         ����� � ������� ���������� ��� ������������� �����
         �������� ������� ������???
         */
    {
        public string mode = "letter";
        public int quantity = 10;
        public int timeLeft = 30;
        public bool regime_text = true;
        public bool regime_hot_key = false;

        public int exercise_completed_counter = 0;

        public ExerciseContext db;
        public List<Exercise> letter_exercises = new List<Exercise>();
        public List<Exercise> word_exercises = new List<Exercise>();
        public List<Exercise> sentence_exercises = new List<Exercise>();
        public Exercise? current_exercise;



        public TrainerForm()
        {
            InitializeComponent();
            db = new ExerciseContext();
            DivideExercisesInLists();
            textInput.KeyPress += new KeyPressEventHandler(CheckEnterKeyPressing);
            exerciseTextBox.ForeColor = ColorTranslator.FromHtml("#CD5C5C");
        }

        public void DivideExercisesInLists()
        {
            foreach (Exercise exercise in db.Exercises)
            {
                switch (exercise.type)
                {
                    case "letter":
                        letter_exercises.Add(exercise); break;
                    case "word":
                        word_exercises.Add(exercise); break;
                    case "sentence":
                        sentence_exercises.Add(exercise); break;
                }
            }
        }

        public Exercise GetRandomExercise()
        {
            var random = new Random();
            switch (mode)
            {
                case "letter":
                    return letter_exercises[random.Next(letter_exercises.Count)];
                case "word":
                    return word_exercises[random.Next(word_exercises.Count)];
                case "sentence":
                    return sentence_exercises[random.Next(sentence_exercises.Count)];
                default:
                    return letter_exercises[random.Next(letter_exercises.Count)];
            }
            
            
        }

        private string getModeRussian()
        {
            switch (mode)
            {
                case "letter":
                    return "��������";
                case "word":
                    return "����";
                case "sentence":
                    return "�����������";
                default:
                    return "��������";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startExercise();
        }

        private void startExercise()
        {
            exerciseTextBox.Enabled = true;
            current_exercise = GetRandomExercise();
            exerciseTextBox.Text = current_exercise.value; // ��� ����� ����������� ����� �� ��
            quantity = Convert.ToInt32(Quantity.Value);
            Quantity.Enabled = false;
            timeLeft = Convert.ToInt32(Seconds.Value);
            timerLabel.Text = timeLeft + " ������";
            Seconds.Enabled = false;
            exerciseTimer.Start();
            startButton.Enabled = false;
            startButton.BackColor = ColorTranslator.FromHtml("#C8D3D5");
            textInput.Enabled = true;
            textInput.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            textInput.Cursor = Cursors.IBeam;
            textInput.Select();
            radioPanel.Enabled = false;
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
                timerLabel.Text = timeLeft + " ������";
            }
            else if (Convert.ToString(timeLeft)[^1] == '1')
            {
                timerLabel.Text = timeLeft + " �������";
            }
            else if (Convert.ToString(timeLeft)[^1] == '2' || Convert.ToString(timeLeft)[^1] == '3' || Convert.ToString(timeLeft)[^1] == '4')
            {
                timerLabel.Text = timeLeft + " �������";
            }
            else
            {
                timerLabel.Text = timeLeft + " ������";
            }
        }

        private void timeUp()
        {
            timerLabel.Text = $"����� �����! �� ������ ������ {exercise_completed_counter} {getModeRussian()}";
            exercise_completed_counter = 0;
            exerciseTextBox.Text = "����� ����� ����� ����������...";
            exerciseTextBox.Enabled = false;
            startButton.Enabled = true;
            textInput.Text = "";
            textInput.Enabled = false;
            textInput.BackColor = ColorTranslator.FromHtml("#C0C0C0");
            textInput.Cursor = Cursors.Cross;
            textBoxIndicator.BackColor = ColorTranslator.FromHtml("#4169E1");
            startButton.BackColor = ColorTranslator.FromHtml("#FFD700");
            exerciseTimer.Stop();
            radioPanel.Enabled = true;
            Quantity.Enabled = true;
            Seconds.Enabled = true;
        }

        private void finishEarlier()
        {
            int exc_completed = exercise_completed_counter;
            timeUp();
            timerLabel.Text = $"�����������! �� ������ ������ {exc_completed} {getModeRussian()} ��������!";
        }

        private void CheckEnterKeyPressing(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                // ��� �� �����:
                // ���� �� ���������� ������ �����-�� ������, �� ���, ������, ����������� � �����-�� ��������� �������. ��� �� �����, ��� ������ ����������� ���-�� � �� ����� ���������. �� � DB Browsere'e �� ������������.
                // � �����, ���� ����� GUI ��-�������� � �������� ����� ������ � �������, �� �� ��� ���� ��������� ����� ���������� - ����� ������� �����. �� ����� ������ ���������� �����������, �� ��.
                
                if (textInput.Text.Trim() == current_exercise.value)
                {
                    quantity -= 1;
                    if (quantity > 0)
                    {
                        current_exercise = GetRandomExercise();
                        textInput.Text = "";
                        exerciseTextBox.Text = current_exercise.value;
                        textBoxIndicator.BackColor = ColorTranslator.FromHtml("#4169E1");
                        exercise_completed_counter += 1;
                    }
                    else
                    {
                        exercise_completed_counter += 1;
                        finishEarlier();
                    }
                }
                else
                {
                    textBoxIndicator.BackColor = ColorTranslator.FromHtml("#F55762");
                }
                
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

        private void textCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (textCheck.Checked)
            {
                regime_text = true;
            } else
            {
                regime_text = false;
            }
        }

        private void hotKeyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hotKeyCheck.Checked)
            {
                regime_hot_key = true;
            }
            else
            {
                regime_hot_key = false;
            }
        }

    }
}