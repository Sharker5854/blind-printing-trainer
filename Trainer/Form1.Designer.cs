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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.textInput = new System.Windows.Forms.TextBox();
            this.modeRadio1 = new System.Windows.Forms.RadioButton();
            this.modeRadio2 = new System.Windows.Forms.RadioButton();
            this.modeRadio3 = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.exerciseTimer = new System.Windows.Forms.Timer(this.components);
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxIndicator = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.radioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            resources.ApplyResources(this.textInput, "textInput");
            this.textInput.BackColor = System.Drawing.Color.Silver;
            this.textInput.Name = "textInput";
            this.textInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modeRadio1
            // 
            resources.ApplyResources(this.modeRadio1, "modeRadio1");
            this.modeRadio1.BackColor = System.Drawing.Color.Transparent;
            this.modeRadio1.Checked = true;
            this.modeRadio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modeRadio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.modeRadio1.Name = "modeRadio1";
            this.modeRadio1.TabStop = true;
            this.modeRadio1.UseVisualStyleBackColor = false;
            this.modeRadio1.CheckedChanged += new System.EventHandler(this.modeRadio1_CheckedChanged);
            // 
            // modeRadio2
            // 
            resources.ApplyResources(this.modeRadio2, "modeRadio2");
            this.modeRadio2.BackColor = System.Drawing.Color.Transparent;
            this.modeRadio2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modeRadio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.modeRadio2.Name = "modeRadio2";
            this.modeRadio2.UseVisualStyleBackColor = false;
            this.modeRadio2.CheckedChanged += new System.EventHandler(this.modeRadio2_CheckedChanged);
            // 
            // modeRadio3
            // 
            resources.ApplyResources(this.modeRadio3, "modeRadio3");
            this.modeRadio3.BackColor = System.Drawing.Color.Transparent;
            this.modeRadio3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modeRadio3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.modeRadio3.Name = "modeRadio3";
            this.modeRadio3.UseVisualStyleBackColor = false;
            this.modeRadio3.CheckedChanged += new System.EventHandler(this.modeRadio3_CheckedChanged);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.BackColor = System.Drawing.Color.Gold;
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // radioPanel
            // 
            resources.ApplyResources(this.radioPanel, "radioPanel");
            this.radioPanel.BackColor = System.Drawing.Color.Transparent;
            this.radioPanel.Controls.Add(this.modeRadio3);
            this.radioPanel.Controls.Add(this.modeRadio1);
            this.radioPanel.Controls.Add(this.modeRadio2);
            this.radioPanel.Name = "radioPanel";
            // 
            // exerciseTimer
            // 
            this.exerciseTimer.Interval = 1000;
            this.exerciseTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Quantity.Name = "Quantity";
            this.Quantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxIndicator
            // 
            resources.ApplyResources(this.textBoxIndicator, "textBoxIndicator");
            this.textBoxIndicator.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxIndicator.Name = "textBoxIndicator";
            // 
            // timerLabel
            // 
            resources.ApplyResources(this.timerLabel, "timerLabel");
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.timerLabel.Name = "timerLabel";
            // 
            // mainLabel
            // 
            resources.ApplyResources(this.mainLabel, "mainLabel");
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.ForeColor = System.Drawing.Color.Gold;
            this.mainLabel.Name = "mainLabel";
            // 
            // Seconds
            // 
            resources.ApplyResources(this.Seconds, "Seconds");
            this.Seconds.Name = "Seconds";
            this.Seconds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.ForeColor = System.Drawing.Color.Gold;
            this.quantityLabel.Name = "quantityLabel";
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.Color.Gold;
            this.timeLabel.Name = "timeLabel";
            // 
            // exerciseTextBox
            // 
            resources.ApplyResources(this.exerciseTextBox, "exerciseTextBox");
            this.exerciseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.exerciseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exerciseTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.ReadOnly = true;
            this.exerciseTextBox.TabStop = false;
            // 
            // TrainerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.exerciseTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.textBoxIndicator);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.radioPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.mainLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "TrainerForm";
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}