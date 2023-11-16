namespace UserManagement
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameComponent = new Label();
            EditButtonUser = new Button();
            DeleteButtonUser = new Button();
            SuspendLayout();
            // 
            // UsernameComponent
            // 
            UsernameComponent.AutoSize = true;
            UsernameComponent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameComponent.Location = new Point(26, 20);
            UsernameComponent.MaximumSize = new Size(125, 70);
            UsernameComponent.MinimumSize = new Size(125, 70);
            UsernameComponent.Name = "UsernameComponent";
            UsernameComponent.Size = new Size(125, 70);
            UsernameComponent.TabIndex = 0;
            UsernameComponent.Text = "label1";
            UsernameComponent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditButtonUser
            // 
            EditButtonUser.BackColor = Color.SeaGreen;
            EditButtonUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EditButtonUser.ForeColor = Color.White;
            EditButtonUser.Location = new Point(28, 93);
            EditButtonUser.Name = "EditButtonUser";
            EditButtonUser.Size = new Size(123, 45);
            EditButtonUser.TabIndex = 1;
            EditButtonUser.Text = "Edit";
            EditButtonUser.UseVisualStyleBackColor = false;
            EditButtonUser.Click += EditButtonUser_Click;
            // 
            // DeleteButtonUser
            // 
            DeleteButtonUser.BackColor = Color.Tomato;
            DeleteButtonUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButtonUser.ForeColor = Color.White;
            DeleteButtonUser.Location = new Point(54, 144);
            DeleteButtonUser.Name = "DeleteButtonUser";
            DeleteButtonUser.Size = new Size(75, 30);
            DeleteButtonUser.TabIndex = 2;
            DeleteButtonUser.Text = "Delete";
            DeleteButtonUser.UseVisualStyleBackColor = false;
            DeleteButtonUser.Click += DeleteButtonUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DeleteButtonUser);
            Controls.Add(EditButtonUser);
            Controls.Add(UsernameComponent);
            Name = "UserControl1";
            Size = new Size(182, 186);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameComponent;
        private Button EditButtonUser;
        private Button DeleteButtonUser;
    }
}
