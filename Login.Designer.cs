namespace Calculator
{
    partial class Login
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
            label2 = new Label();
            txt_name = new TextBox();
            txt_pass = new TextBox();
            B_LOGIN = new Button();
            Label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 179);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 34);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(285, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 34);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_name
            // 
            txt_name.AcceptsTab = true;
            txt_name.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name.Location = new Point(403, 179);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(242, 41);
            txt_name.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pass.Location = new Point(403, 256);
            txt_pass.Margin = new Padding(4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(242, 41);
            txt_pass.TabIndex = 4;
            // 
            // B_LOGIN
            // 
            B_LOGIN.BackColor = SystemColors.ControlLight;
            B_LOGIN.BackgroundImageLayout = ImageLayout.None;
            B_LOGIN.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            B_LOGIN.FlatStyle = FlatStyle.Popup;
            B_LOGIN.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B_LOGIN.ForeColor = Color.Black;
            B_LOGIN.Location = new Point(453, 336);
            B_LOGIN.Margin = new Padding(4);
            B_LOGIN.Name = "B_LOGIN";
            B_LOGIN.Size = new Size(141, 41);
            B_LOGIN.TabIndex = 5;
            B_LOGIN.Text = "Login";
            B_LOGIN.UseVisualStyleBackColor = false;
            B_LOGIN.Click += B_LOGIN_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(453, 106);
            Label3.Name = "Label3";
            Label3.Size = new Size(101, 28);
            Label3.TabIndex = 6;
            Label3.Text = "Welcome";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(909, 522);
            Controls.Add(Label3);
            Controls.Add(B_LOGIN);
            Controls.Add(txt_pass);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_pass;
        private Button B_LOGIN;
        private Label Label3;
    }
}