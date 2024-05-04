namespace KhineYar.Calo.WinForm
{
    partial class UCRegister
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
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnback = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 251);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(174, 171);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 9;
            label2.Text = "FirstName";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(174, 114);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 7;
            label1.Text = "Register";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(455, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(455, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(455, 370);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(174, 370);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(455, 171);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 16;
            label4.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(455, 251);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 17;
            label5.Text = "Reenter Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(455, 336);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 19;
            label6.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(174, 336);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 18;
            label7.Text = "Age";
            // 
            // btnback
            // 
            btnback.Location = new Point(455, 426);
            btnback.Name = "btnback";
            btnback.Size = new Size(174, 33);
            btnback.TabIndex = 20;
            btnback.Text = "Back to Home";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(174, 426);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(174, 33);
            btn_register.TabIndex = 21;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // UCRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_register);
            Controls.Add(btnback);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UCRegister";
            Size = new Size(849, 544);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnback;
        private Button btn_register;
    }
}
