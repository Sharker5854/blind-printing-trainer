namespace Trainer
{
    partial class TrainerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            textInput = new TextBox();
            modeRadio1 = new RadioButton();
            modeRadio2 = new RadioButton();
            modeRadio3 = new RadioButton();
            startButton = new Button();
            radioPanel = new Panel();
            exerciseTimer = new System.Windows.Forms.Timer(components);
            Quantity = new NumericUpDown();
            textBoxIndicator = new Panel();
            timerLabel = new Label();
            mainLabel = new Label();
            Seconds = new NumericUpDown();
            quantityLabel = new Label();
            timeLabel = new Label();
            exerciseTextBox = new TextBox();
            showStatTextBox = new TextBox();
            radioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Seconds).BeginInit();
            SuspendLayout();
            // 
            // textInput
            // 
            resources.ApplyResources(textInput, "textInput");
            textInput.BackColor = Color.Silver;
            textInput.Name = "textInput";
            // 
            // modeRadio1
            // 
            resources.ApplyResources(modeRadio1, "modeRadio1");
            modeRadio1.BackColor = Color.Transparent;
            modeRadio1.Checked = true;
            modeRadio1.Cursor = Cursors.Hand;
            modeRadio1.ForeColor = Color.FromArgb(255, 92, 0);
            modeRadio1.Name = "modeRadio1";
            modeRadio1.TabStop = true;
            modeRadio1.UseVisualStyleBackColor = false;
            modeRadio1.CheckedChanged += modeRadio1_CheckedChanged;
            // 
            // modeRadio2
            // 
            resources.ApplyResources(modeRadio2, "modeRadio2");
            modeRadio2.BackColor = Color.Transparent;
            modeRadio2.Cursor = Cursors.Hand;
            modeRadio2.ForeColor = Color.FromArgb(255, 92, 0);
            modeRadio2.Name = "modeRadio2";
            modeRadio2.UseVisualStyleBackColor = false;
            modeRadio2.CheckedChanged += modeRadio2_CheckedChanged;
            // 
            // modeRadio3
            // 
            resources.ApplyResources(modeRadio3, "modeRadio3");
            modeRadio3.BackColor = Color.Transparent;
            modeRadio3.Cursor = Cursors.Hand;
            modeRadio3.ForeColor = Color.FromArgb(255, 92, 0);
            modeRadio3.Name = "modeRadio3";
            modeRadio3.UseVisualStyleBackColor = false;
            modeRadio3.CheckedChanged += modeRadio3_CheckedChanged;
            // 
            // startButton
            // 
            resources.ApplyResources(startButton, "startButton");
            startButton.BackColor = Color.Gold;
            startButton.Cursor = Cursors.Hand;
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // radioPanel
            // 
            resources.ApplyResources(radioPanel, "radioPanel");
            radioPanel.BackColor = Color.Transparent;
            radioPanel.Controls.Add(modeRadio3);
            radioPanel.Controls.Add(modeRadio1);
            radioPanel.Controls.Add(modeRadio2);
            radioPanel.Name = "radioPanel";
            // 
            // exerciseTimer
            // 
            exerciseTimer.Interval = 1000;
            exerciseTimer.Tick += timer1_Tick;
            // 
            // Quantity
            // 
            resources.ApplyResources(Quantity, "Quantity");
            Quantity.BackColor = Color.WhiteSmoke;
            Quantity.Name = "Quantity";
            Quantity.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // textBoxIndicator
            // 
            resources.ApplyResources(textBoxIndicator, "textBoxIndicator");
            textBoxIndicator.BackColor = Color.RoyalBlue;
            textBoxIndicator.Name = "textBoxIndicator";
            // 
            // timerLabel
            // 
            resources.ApplyResources(timerLabel, "timerLabel");
            timerLabel.BackColor = Color.Transparent;
            timerLabel.ForeColor = Color.IndianRed;
            timerLabel.Name = "timerLabel";
            // 
            // mainLabel
            // 
            resources.ApplyResources(mainLabel, "mainLabel");
            mainLabel.BackColor = Color.Transparent;
            mainLabel.ForeColor = Color.Gold;
            mainLabel.Name = "mainLabel";
            // 
            // Seconds
            // 
            resources.ApplyResources(Seconds, "Seconds");
            Seconds.Name = "Seconds";
            Seconds.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // quantityLabel
            // 
            resources.ApplyResources(quantityLabel, "quantityLabel");
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.ForeColor = Color.Gold;
            quantityLabel.Name = "quantityLabel";
            // 
            // timeLabel
            // 
            resources.ApplyResources(timeLabel, "timeLabel");
            timeLabel.BackColor = Color.Transparent;
            timeLabel.ForeColor = Color.Gold;
            timeLabel.Name = "timeLabel";
            // 
            // exerciseTextBox
            // 
            resources.ApplyResources(exerciseTextBox, "exerciseTextBox");
            exerciseTextBox.BackColor = Color.FromArgb(28, 41, 62);
            exerciseTextBox.BorderStyle = BorderStyle.None;
            exerciseTextBox.ForeColor = Color.IndianRed;
            exerciseTextBox.Name = "exerciseTextBox";
            exerciseTextBox.ReadOnly = true;
            exerciseTextBox.TabStop = false;
            // 
            // showStatTextBox
            // 
            resources.ApplyResources(showStatTextBox, "showStatTextBox");
            showStatTextBox.BackColor = Color.FromArgb(28, 41, 62);
            showStatTextBox.BorderStyle = BorderStyle.None;
            showStatTextBox.Cursor = Cursors.Hand;
            showStatTextBox.ForeColor = Color.FromArgb(255, 92, 0);
            showStatTextBox.Name = "showStatTextBox";
            showStatTextBox.ReadOnly = true;
            showStatTextBox.MouseClick += showStatTextBox_MouseClick;
            showStatTextBox.MouseEnter += showStatTextBox_MouseEnter;
            showStatTextBox.MouseLeave += showStatTextBox_MouseLeave;
            // 
            // TrainerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 62);
            Controls.Add(showStatTextBox);
            Controls.Add(exerciseTextBox);
            Controls.Add(timeLabel);
            Controls.Add(quantityLabel);
            Controls.Add(Seconds);
            Controls.Add(timerLabel);
            Controls.Add(textBoxIndicator);
            Controls.Add(Quantity);
            Controls.Add(radioPanel);
            Controls.Add(startButton);
            Controls.Add(textInput);
            Controls.Add(mainLabel);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerForm";
            radioPanel.ResumeLayout(false);
            radioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)Seconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textInput;
        private RadioButton modeRadio1;
        private RadioButton modeRadio2;
        private RadioButton modeRadio3;
        private Button startButton;
        private Panel radioPanel;
        private System.Windows.Forms.Timer exerciseTimer;
        private NumericUpDown Quantity;
        private Panel textBoxIndicator;
        private Label timerLabel;
        private Label mainLabel;
        private NumericUpDown Seconds;
        private Label quantityLabel;
        private Label timeLabel;
        private TextBox exerciseTextBox;
        private TextBox showStatTextBox;
    }
}