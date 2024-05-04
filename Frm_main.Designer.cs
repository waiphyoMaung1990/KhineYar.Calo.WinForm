namespace KhineYar.Calo.WinForm
{
    partial class Frm_main
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnlogin = new Button();
            panel3 = new Panel();
            btnregister = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 44);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(798, -1);
            button1.Name = "button1";
            button1.Size = new Size(50, 44);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(-2, 537);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 10);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 38.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 61);
            label1.Name = "label1";
            label1.Size = new Size(786, 68);
            label1.TabIndex = 3;
            label1.Text = "Welcome To Transformer FitnessPro";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(258, 229);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(127, 87);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnregister);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 544);
            panel3.TabIndex = 5;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(401, 229);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(127, 87);
            btnregister.TabIndex = 5;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += button3_Click;
            // 
            // Frm_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_main";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Button btnlogin;
        public Panel panel3;
        private Button btnregister;
    }
}
