namespace KhineYar.Calo.WinForm
{
    partial class UCLogin
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
            label1 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtname
            // 
            txtname.Location = new Point(68, 158);
            txtname.Name = "txtname";
            txtname.Size = new Size(174, 23);
            txtname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 120);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 200);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(68, 237);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(174, 23);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(68, 310);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(174, 33);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(68, 363);
            btnback.Name = "btnback";
            btnback.Size = new Size(174, 33);
            btnback.TabIndex = 6;
            btnback.Text = "Back to Register";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += button2_Click;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnback);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            Name = "UCLogin";
            Size = new Size(326, 456);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Label label2;
        private Label label3;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnback;
    }
}
