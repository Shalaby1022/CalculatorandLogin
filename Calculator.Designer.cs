namespace Calculator
{
    partial class Calculator
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
            equal = new Button();
            add = new Button();
            substract = new Button();
            multiply = new Button();
            divide = new Button();
            button_ce = new Button();
            button_0 = new Button();
            button9 = new Button();
            button_8 = new Button();
            button_7 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            txt_result = new RichTextBox();
            SuspendLayout();
            // 
            // equal
            // 
            equal.BackColor = SystemColors.InactiveCaption;
            equal.FlatStyle = FlatStyle.Popup;
            equal.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            equal.ForeColor = SystemColors.ActiveCaptionText;
            equal.Location = new Point(211, 389);
            equal.Name = "equal";
            equal.Size = new Size(80, 80);
            equal.TabIndex = 34;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.InactiveCaption;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = SystemColors.ActiveCaptionText;
            add.Location = new Point(291, 309);
            add.Name = "add";
            add.Size = new Size(80, 80);
            add.TabIndex = 33;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // substract
            // 
            substract.BackColor = SystemColors.InactiveCaption;
            substract.FlatStyle = FlatStyle.Popup;
            substract.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            substract.ForeColor = SystemColors.ActiveCaptionText;
            substract.Location = new Point(291, 389);
            substract.Name = "substract";
            substract.Size = new Size(80, 80);
            substract.TabIndex = 32;
            substract.Text = "-";
            substract.UseVisualStyleBackColor = false;
            substract.Click += substract_Click;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.InactiveCaption;
            multiply.FlatStyle = FlatStyle.Popup;
            multiply.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            multiply.ForeColor = SystemColors.ActiveCaptionText;
            multiply.Location = new Point(291, 229);
            multiply.Name = "multiply";
            multiply.Size = new Size(80, 80);
            multiply.TabIndex = 31;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.InactiveCaption;
            divide.FlatStyle = FlatStyle.Popup;
            divide.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            divide.ForeColor = SystemColors.ActiveCaptionText;
            divide.Location = new Point(291, 149);
            divide.Name = "divide";
            divide.Size = new Size(80, 80);
            divide.TabIndex = 30;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // button_ce
            // 
            button_ce.BackColor = SystemColors.InactiveCaption;
            button_ce.FlatStyle = FlatStyle.Popup;
            button_ce.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_ce.ForeColor = SystemColors.ActiveCaptionText;
            button_ce.Location = new Point(131, 388);
            button_ce.Name = "button_ce";
            button_ce.Size = new Size(80, 80);
            button_ce.TabIndex = 29;
            button_ce.Text = "CE";
            button_ce.UseVisualStyleBackColor = false;
            button_ce.Click += button_ce_Click;
            // 
            // button_0
            // 
            button_0.BackColor = SystemColors.InactiveCaption;
            button_0.FlatStyle = FlatStyle.Popup;
            button_0.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_0.ForeColor = SystemColors.ActiveCaptionText;
            button_0.Location = new Point(51, 389);
            button_0.Name = "button_0";
            button_0.Size = new Size(80, 80);
            button_0.TabIndex = 28;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = false;
            button_0.Click += button_0_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.InactiveCaption;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(211, 309);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 27;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button_8
            // 
            button_8.BackColor = SystemColors.InactiveCaption;
            button_8.FlatStyle = FlatStyle.Popup;
            button_8.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_8.ForeColor = SystemColors.ActiveCaptionText;
            button_8.Location = new Point(131, 308);
            button_8.Name = "button_8";
            button_8.Size = new Size(80, 80);
            button_8.TabIndex = 26;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = false;
            button_8.Click += button_8_Click;
            // 
            // button_7
            // 
            button_7.BackColor = SystemColors.InactiveCaption;
            button_7.FlatStyle = FlatStyle.Popup;
            button_7.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_7.ForeColor = SystemColors.ActiveCaptionText;
            button_7.Location = new Point(51, 309);
            button_7.Name = "button_7";
            button_7.Size = new Size(80, 80);
            button_7.TabIndex = 25;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = false;
            button_7.Click += button_7_Click;
            // 
            // button_6
            // 
            button_6.BackColor = SystemColors.InactiveCaption;
            button_6.FlatStyle = FlatStyle.Popup;
            button_6.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_6.ForeColor = SystemColors.ActiveCaptionText;
            button_6.Location = new Point(211, 229);
            button_6.Name = "button_6";
            button_6.Size = new Size(80, 80);
            button_6.TabIndex = 24;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = false;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.BackColor = SystemColors.InactiveCaption;
            button_5.FlatStyle = FlatStyle.Popup;
            button_5.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_5.ForeColor = SystemColors.ActiveCaptionText;
            button_5.Location = new Point(131, 228);
            button_5.Name = "button_5";
            button_5.Size = new Size(80, 80);
            button_5.TabIndex = 23;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = false;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.BackColor = SystemColors.InactiveCaption;
            button_4.FlatStyle = FlatStyle.Popup;
            button_4.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_4.ForeColor = SystemColors.ActiveCaptionText;
            button_4.Location = new Point(51, 229);
            button_4.Name = "button_4";
            button_4.Size = new Size(80, 80);
            button_4.TabIndex = 22;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = false;
            button_4.Click += button_4_Click;
            // 
            // button_3
            // 
            button_3.BackColor = SystemColors.InactiveCaption;
            button_3.FlatStyle = FlatStyle.Popup;
            button_3.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_3.ForeColor = SystemColors.ActiveCaptionText;
            button_3.Location = new Point(211, 149);
            button_3.Name = "button_3";
            button_3.Size = new Size(80, 80);
            button_3.TabIndex = 21;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = false;
            button_3.Click += button_3_Click;
            // 
            // button_2
            // 
            button_2.BackColor = SystemColors.InactiveCaption;
            button_2.FlatStyle = FlatStyle.Popup;
            button_2.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_2.ForeColor = SystemColors.ActiveCaptionText;
            button_2.Location = new Point(131, 149);
            button_2.Name = "button_2";
            button_2.Size = new Size(80, 80);
            button_2.TabIndex = 20;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = false;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.InactiveCaption;
            button_1.FlatStyle = FlatStyle.Popup;
            button_1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_1.ForeColor = SystemColors.ActiveCaptionText;
            button_1.Location = new Point(51, 149);
            button_1.Name = "button_1";
            button_1.Size = new Size(80, 80);
            button_1.TabIndex = 19;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // txt_result
            // 
            txt_result.Enabled = false;
            txt_result.Location = new Point(2, 23);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(554, 93);
            txt_result.TabIndex = 18;
            txt_result.Text = "";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(558, 634);
            Controls.Add(equal);
            Controls.Add(add);
            Controls.Add(substract);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(button_ce);
            Controls.Add(button_0);
            Controls.Add(button9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(txt_result);
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button equal;
        private Button add;
        private Button substract;
        private Button multiply;
        private Button divide;
        private Button button_ce;
        private Button button_0;
        private Button button9;
        private Button button_8;
        private Button button_7;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private RichTextBox txt_result;
    }
}