namespace Trainer
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            statFormUsernameTextBox = new TextBox();
            totalRoundsTitleTextBox = new TextBox();
            totalMinutesTitleTextBox = new TextBox();
            totalSymbolsTitleTextBox = new TextBox();
            averageSymbolsPerMinuteTitleTextBox = new TextBox();
            totalMistakesTitleTextBox = new TextBox();
            averageMistakesPerRoundTitleTextBox = new TextBox();
            closeStatButton = new Button();
            SuspendLayout();
            // 
            // statFormUsernameTextBox
            // 
            statFormUsernameTextBox.BackColor = Color.FromArgb(28, 41, 62);
            statFormUsernameTextBox.BorderStyle = BorderStyle.None;
            statFormUsernameTextBox.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            statFormUsernameTextBox.ForeColor = Color.IndianRed;
            statFormUsernameTextBox.ImeMode = ImeMode.NoControl;
            statFormUsernameTextBox.Location = new Point(34, 39);
            statFormUsernameTextBox.Name = "statFormUsernameTextBox";
            statFormUsernameTextBox.ReadOnly = true;
            statFormUsernameTextBox.ShortcutsEnabled = false;
            statFormUsernameTextBox.Size = new Size(420, 32);
            statFormUsernameTextBox.TabIndex = 1000002;
            statFormUsernameTextBox.TabStop = false;
            statFormUsernameTextBox.Text = "Статистика";
            statFormUsernameTextBox.MouseClick += TextBox_MouseClick;
            // 
            // totalRoundsTitleTextBox
            // 
            totalRoundsTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            totalRoundsTitleTextBox.BorderStyle = BorderStyle.None;
            totalRoundsTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalRoundsTitleTextBox.ForeColor = Color.Gold;
            totalRoundsTitleTextBox.ImeMode = ImeMode.NoControl;
            totalRoundsTitleTextBox.Location = new Point(34, 92);
            totalRoundsTitleTextBox.Margin = new Padding(4);
            totalRoundsTitleTextBox.Name = "totalRoundsTitleTextBox";
            totalRoundsTitleTextBox.ReadOnly = true;
            totalRoundsTitleTextBox.ShortcutsEnabled = false;
            totalRoundsTitleTextBox.Size = new Size(471, 25);
            totalRoundsTitleTextBox.TabIndex = 1000003;
            totalRoundsTitleTextBox.TabStop = false;
            totalRoundsTitleTextBox.Text = "Всего раундов:";
            totalRoundsTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // totalMinutesTitleTextBox
            // 
            totalMinutesTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            totalMinutesTitleTextBox.BorderStyle = BorderStyle.None;
            totalMinutesTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalMinutesTitleTextBox.ForeColor = Color.Gold;
            totalMinutesTitleTextBox.ImeMode = ImeMode.NoControl;
            totalMinutesTitleTextBox.Location = new Point(34, 125);
            totalMinutesTitleTextBox.Margin = new Padding(4);
            totalMinutesTitleTextBox.Name = "totalMinutesTitleTextBox";
            totalMinutesTitleTextBox.ReadOnly = true;
            totalMinutesTitleTextBox.ShortcutsEnabled = false;
            totalMinutesTitleTextBox.Size = new Size(471, 25);
            totalMinutesTitleTextBox.TabIndex = 1000004;
            totalMinutesTitleTextBox.TabStop = false;
            totalMinutesTitleTextBox.Text = "Всего минут:";
            totalMinutesTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // totalSymbolsTitleTextBox
            // 
            totalSymbolsTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            totalSymbolsTitleTextBox.BorderStyle = BorderStyle.None;
            totalSymbolsTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalSymbolsTitleTextBox.ForeColor = Color.Gold;
            totalSymbolsTitleTextBox.ImeMode = ImeMode.NoControl;
            totalSymbolsTitleTextBox.Location = new Point(34, 158);
            totalSymbolsTitleTextBox.Margin = new Padding(4);
            totalSymbolsTitleTextBox.Name = "totalSymbolsTitleTextBox";
            totalSymbolsTitleTextBox.ReadOnly = true;
            totalSymbolsTitleTextBox.ShortcutsEnabled = false;
            totalSymbolsTitleTextBox.Size = new Size(471, 25);
            totalSymbolsTitleTextBox.TabIndex = 1000005;
            totalSymbolsTitleTextBox.TabStop = false;
            totalSymbolsTitleTextBox.Text = "Всего символов:";
            totalSymbolsTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // averageSymbolsPerMinuteTitleTextBox
            // 
            averageSymbolsPerMinuteTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            averageSymbolsPerMinuteTitleTextBox.BorderStyle = BorderStyle.None;
            averageSymbolsPerMinuteTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            averageSymbolsPerMinuteTitleTextBox.ForeColor = Color.Gold;
            averageSymbolsPerMinuteTitleTextBox.ImeMode = ImeMode.NoControl;
            averageSymbolsPerMinuteTitleTextBox.Location = new Point(34, 224);
            averageSymbolsPerMinuteTitleTextBox.Margin = new Padding(4);
            averageSymbolsPerMinuteTitleTextBox.Name = "averageSymbolsPerMinuteTitleTextBox";
            averageSymbolsPerMinuteTitleTextBox.ReadOnly = true;
            averageSymbolsPerMinuteTitleTextBox.ShortcutsEnabled = false;
            averageSymbolsPerMinuteTitleTextBox.Size = new Size(471, 25);
            averageSymbolsPerMinuteTitleTextBox.TabIndex = 1000006;
            averageSymbolsPerMinuteTitleTextBox.TabStop = false;
            averageSymbolsPerMinuteTitleTextBox.Text = "Среднее кол-во символов в минуту:";
            averageSymbolsPerMinuteTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // totalMistakesTitleTextBox
            // 
            totalMistakesTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            totalMistakesTitleTextBox.BorderStyle = BorderStyle.None;
            totalMistakesTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalMistakesTitleTextBox.ForeColor = Color.Gold;
            totalMistakesTitleTextBox.ImeMode = ImeMode.NoControl;
            totalMistakesTitleTextBox.Location = new Point(34, 191);
            totalMistakesTitleTextBox.Margin = new Padding(4);
            totalMistakesTitleTextBox.Name = "totalMistakesTitleTextBox";
            totalMistakesTitleTextBox.ReadOnly = true;
            totalMistakesTitleTextBox.ShortcutsEnabled = false;
            totalMistakesTitleTextBox.Size = new Size(471, 25);
            totalMistakesTitleTextBox.TabIndex = 1000007;
            totalMistakesTitleTextBox.TabStop = false;
            totalMistakesTitleTextBox.Text = "Всего ошибок:";
            totalMistakesTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // averageMistakesPerRoundTitleTextBox
            // 
            averageMistakesPerRoundTitleTextBox.BackColor = Color.FromArgb(28, 41, 62);
            averageMistakesPerRoundTitleTextBox.BorderStyle = BorderStyle.None;
            averageMistakesPerRoundTitleTextBox.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            averageMistakesPerRoundTitleTextBox.ForeColor = Color.Gold;
            averageMistakesPerRoundTitleTextBox.ImeMode = ImeMode.NoControl;
            averageMistakesPerRoundTitleTextBox.Location = new Point(34, 257);
            averageMistakesPerRoundTitleTextBox.Margin = new Padding(4);
            averageMistakesPerRoundTitleTextBox.Name = "averageMistakesPerRoundTitleTextBox";
            averageMistakesPerRoundTitleTextBox.ReadOnly = true;
            averageMistakesPerRoundTitleTextBox.ShortcutsEnabled = false;
            averageMistakesPerRoundTitleTextBox.Size = new Size(471, 25);
            averageMistakesPerRoundTitleTextBox.TabIndex = 1000008;
            averageMistakesPerRoundTitleTextBox.TabStop = false;
            averageMistakesPerRoundTitleTextBox.Text = "Среднее кол-во ошибок за раунд:";
            averageMistakesPerRoundTitleTextBox.MouseClick += TextBox_MouseClick;
            // 
            // closeStatButton
            // 
            closeStatButton.BackColor = Color.Gold;
            closeStatButton.Cursor = Cursors.Hand;
            closeStatButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeStatButton.ImeMode = ImeMode.NoControl;
            closeStatButton.Location = new Point(34, 319);
            closeStatButton.Margin = new Padding(4);
            closeStatButton.Name = "closeStatButton";
            closeStatButton.Size = new Size(120, 48);
            closeStatButton.TabIndex = 1000015;
            closeStatButton.Text = "Закрыть";
            closeStatButton.UseVisualStyleBackColor = false;
            closeStatButton.Click += closeStatButton_Click;
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 62);
            ClientSize = new Size(563, 409);
            Controls.Add(closeStatButton);
            Controls.Add(averageMistakesPerRoundTitleTextBox);
            Controls.Add(totalMistakesTitleTextBox);
            Controls.Add(averageSymbolsPerMinuteTitleTextBox);
            Controls.Add(totalSymbolsTitleTextBox);
            Controls.Add(totalMinutesTitleTextBox);
            Controls.Add(totalRoundsTitleTextBox);
            Controls.Add(statFormUsernameTextBox);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StatisticForm";
            Text = "Статистика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox statFormUsernameTextBox;
        private TextBox totalRoundsTitleTextBox;
        private TextBox totalMinutesTitleTextBox;
        private TextBox totalSymbolsTitleTextBox;
        private TextBox averageSymbolsPerMinuteTitleTextBox;
        private TextBox totalMistakesTitleTextBox;
        private TextBox averageMistakesPerRoundTitleTextBox;
        private Button closeStatButton;
    }
}