namespace UserManagement
{
    partial class EditPage
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
            EditUsername = new TextBox();
            EditPassword = new TextBox();
            SubmitEdit = new Button();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(228, 45);
            label1.Name = "label1";
            label1.Size = new Size(357, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit User Account";
            // 
            // EditUsername
            // 
            EditUsername.Location = new Point(213, 162);
            EditUsername.Name = "EditUsername";
            EditUsername.Size = new Size(373, 23);
            EditUsername.TabIndex = 3;
            EditUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // EditPassword
            // 
            EditPassword.Location = new Point(213, 242);
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(373, 23);
            EditPassword.TabIndex = 4;
            EditPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // SubmitEdit
            // 
            SubmitEdit.BackColor = Color.White;
            SubmitEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitEdit.ForeColor = Color.Black;
            SubmitEdit.Location = new Point(259, 309);
            SubmitEdit.Name = "SubmitEdit";
            SubmitEdit.Size = new Size(273, 48);
            SubmitEdit.TabIndex = 5;
            SubmitEdit.Text = "Submit";
            SubmitEdit.UseVisualStyleBackColor = false;
            SubmitEdit.Click += SubmitEdit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(80, 38);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(324, 131);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 8;
            label4.Text = "New Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(324, 211);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 9;
            label2.Text = "New Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -18);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 130);
            panel1.TabIndex = 11;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(SubmitEdit);
            Controls.Add(EditPassword);
            Controls.Add(EditUsername);
            Controls.Add(panel1);
            Name = "EditPage";
            Text = "EditPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EditUsername;
        private TextBox EditPassword;
        private Button SubmitEdit;
        private Button button1;
        private Label label4;
        private Panel panel1;
    }
}