namespace Trainer
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            authLabel = new Label();
            usernameInput = new TextBox();
            usernameLabel = new Label();
            authTextBoxIndicator = new Panel();
            authButton = new Button();
            SuspendLayout();
            // 
            // authLabel
            // 
            authLabel.AutoSize = true;
            authLabel.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            authLabel.ForeColor = Color.Gold;
            authLabel.Location = new Point(269, 76);
            authLabel.Name = "authLabel";
            authLabel.Size = new Size(261, 46);
            authLabel.TabIndex = 0;
            authLabel.Text = "Авторизация";
            // 
            // usernameInput
            // 
            usernameInput.CausesValidation = false;
            usernameInput.Cursor = Cursors.IBeam;
            usernameInput.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameInput.Location = new Point(141, 192);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(515, 29);
            usernameInput.TabIndex = 1;
            usernameInput.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.Gold;
            usernameLabel.Location = new Point(296, 163);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(203, 23);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Введите имя пользователя:";
            // 
            // authTextBoxIndicator
            // 
            authTextBoxIndicator.BackColor = Color.RoyalBlue;
            authTextBoxIndicator.Location = new Point(141, 220);
            authTextBoxIndicator.Margin = new Padding(4);
            authTextBoxIndicator.Name = "authTextBoxIndicator";
            authTextBoxIndicator.Size = new Size(515, 6);
            authTextBoxIndicator.TabIndex = 12;
            // 
            // authButton
            // 
            authButton.BackColor = Color.Gold;
            authButton.Cursor = Cursors.Hand;
            authButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            authButton.ImeMode = ImeMode.NoControl;
            authButton.Location = new Point(328, 293);
            authButton.Margin = new Padding(4);
            authButton.Name = "authButton";
            authButton.Size = new Size(130, 55);
            authButton.TabIndex = 7;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = false;
            authButton.Click += authButton_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 62);
            ClientSize = new Size(799, 446);
            Controls.Add(authButton);
            Controls.Add(authTextBoxIndicator);
            Controls.Add(usernameLabel);
            Controls.Add(usernameInput);
            Controls.Add(authLabel);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AuthForm";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label authLabel;
        private TextBox usernameInput;
        private Label usernameLabel;
        private Panel authTextBoxIndicator;
        private Button authButton;
    }
}