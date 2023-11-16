namespace UserManagement
{
    partial class RegisterForm
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
            label1 = new Label();
            UsernameRegister = new TextBox();
            PasswordRegister = new TextBox();
            SubmitRegistration = new Button();
            BackButton = new Button();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 48);
            label1.Name = "label1";
            label1.Size = new Size(509, 51);
            label1.TabIndex = 0;
            label1.Text = "Register Your New Account";
            // 
            // UsernameRegister
            // 
            UsernameRegister.Location = new Point(356, 152);
            UsernameRegister.Name = "UsernameRegister";
            UsernameRegister.Size = new Size(370, 23);
            UsernameRegister.TabIndex = 3;
            UsernameRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordRegister
            // 
            PasswordRegister.Location = new Point(356, 228);
            PasswordRegister.Name = "PasswordRegister";
            PasswordRegister.Size = new Size(370, 23);
            PasswordRegister.TabIndex = 4;
            PasswordRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // SubmitRegistration
            // 
            SubmitRegistration.BackColor = Color.White;
            SubmitRegistration.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitRegistration.ForeColor = Color.SeaGreen;
            SubmitRegistration.Location = new Point(406, 298);
            SubmitRegistration.Name = "SubmitRegistration";
            SubmitRegistration.Size = new Size(273, 48);
            SubmitRegistration.TabIndex = 5;
            SubmitRegistration.Text = "Submit";
            SubmitRegistration.UseVisualStyleBackColor = false;
            SubmitRegistration.Click += SubmitRegistration_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkGreen;
            BackButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(29, 273);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(224, 48);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(488, 121);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(488, 197);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BackButton);
            panel1.Location = new Point(-6, -30);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 487);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(51, 225);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 9;
            label5.Text = "You liar, go back!";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(271, 102);
            label3.TabIndex = 8;
            label3.Text = "Already Have \r\nan Account?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(SubmitRegistration);
            Controls.Add(PasswordRegister);
            Controls.Add(UsernameRegister);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameRegister;
        private TextBox PasswordRegister;
        private Button SubmitRegistration;
        private Button BackButton;
        private Label label4;
        private Panel panel1;
        private Label label5;
    }
}