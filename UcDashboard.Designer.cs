namespace KhineYar.Calo.WinForm
{
    partial class UcDashboard
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
            panel1 = new Panel();
            lblRemainingCalories = new Label();
            btnStart = new Button();
            label25 = new Label();
            label24 = new Label();
            txtTarget = new TextBox();
            lblcaloriesburn = new Label();
            label21 = new Label();
            panel3 = new Panel();
            chkrunning = new CheckBox();
            chkcycling = new CheckBox();
            chkrowing = new CheckBox();
            chkyoga = new CheckBox();
            chkwalking = new CheckBox();
            chkswimming = new CheckBox();
            label2 = new Label();
            pnrunning = new Panel();
            txtrunningavgpace = new TextBox();
            txtrunningduration = new TextBox();
            txtrunningdistance = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            pnyoga = new Panel();
            txtintensity = new TextBox();
            txtpoes = new TextBox();
            txtyogaduration = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pncycling = new Panel();
            txtcyclingdistance = new TextBox();
            txtcyclingduration = new TextBox();
            txtavgspeed = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            pnrowing = new Panel();
            txtstockperminute = new TextBox();
            txtrowingduration = new TextBox();
            txtrowingdistance = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pnwalking = new Panel();
            txtwalkingtime = new TextBox();
            txtwalkingdistance = new TextBox();
            txtsteps = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pnswimming = new Panel();
            txtswimtime = new TextBox();
            txtheartbeat = new TextBox();
            txtlaps = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnrunning.SuspendLayout();
            pnyoga.SuspendLayout();
            pncycling.SuspendLayout();
            pnrowing.SuspendLayout();
            pnwalking.SuspendLayout();
            pnswimming.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(lblRemainingCalories);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(txtTarget);
            panel1.Controls.Add(lblcaloriesburn);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnrunning);
            panel1.Controls.Add(pnyoga);
            panel1.Controls.Add(pncycling);
            panel1.Controls.Add(pnrowing);
            panel1.Controls.Add(pnwalking);
            panel1.Controls.Add(pnswimming);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 544);
            panel1.TabIndex = 0;
            // 
            // lblRemainingCalories
            // 
            lblRemainingCalories.AutoSize = true;
            lblRemainingCalories.Location = new Point(752, 505);
            lblRemainingCalories.Name = "lblRemainingCalories";
            lblRemainingCalories.Size = new Size(57, 15);
            lblRemainingCalories.TabIndex = 16;
            lblRemainingCalories.Text = "----------";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Khaki;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.BlueViolet;
            btnStart.Location = new Point(155, 489);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(117, 47);
            btnStart.TabIndex = 15;
            btnStart.Text = "Strat Exercise";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ButtonFace;
            label25.Location = new Point(564, 494);
            label25.Name = "label25";
            label25.Size = new Size(182, 28);
            label25.TabIndex = 14;
            label25.Text = "Remaining Calories:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ButtonFace;
            label24.Location = new Point(278, 451);
            label24.Name = "label24";
            label24.Size = new Size(47, 28);
            label24.TabIndex = 13;
            label24.Text = "Cals";
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(155, 456);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(117, 23);
            txtTarget.TabIndex = 11;
            // 
            // lblcaloriesburn
            // 
            lblcaloriesburn.AutoSize = true;
            lblcaloriesburn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblcaloriesburn.ForeColor = SystemColors.ButtonFace;
            lblcaloriesburn.Location = new Point(564, 451);
            lblcaloriesburn.Name = "lblcaloriesburn";
            lblcaloriesburn.Size = new Size(145, 28);
            lblcaloriesburn.TabIndex = 10;
            lblcaloriesburn.Text = "Calories Burn   :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(5, 451);
            label21.Name = "label21";
            label21.Size = new Size(144, 28);
            label21.TabIndex = 9;
            label21.Text = "Target Calories:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(chkrunning);
            panel3.Controls.Add(chkcycling);
            panel3.Controls.Add(chkrowing);
            panel3.Controls.Add(chkyoga);
            panel3.Controls.Add(chkwalking);
            panel3.Controls.Add(chkswimming);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 50);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // chkrunning
            // 
            chkrunning.AutoSize = true;
            chkrunning.Location = new Point(729, 19);
            chkrunning.Name = "chkrunning";
            chkrunning.Size = new Size(71, 19);
            chkrunning.TabIndex = 12;
            chkrunning.Text = "Running";
            chkrunning.UseVisualStyleBackColor = true;
            chkrunning.CheckedChanged += chkrunning_CheckedChanged;
            // 
            // chkcycling
            // 
            chkcycling.AutoSize = true;
            chkcycling.Location = new Point(640, 18);
            chkcycling.Name = "chkcycling";
            chkcycling.Size = new Size(66, 19);
            chkcycling.TabIndex = 11;
            chkcycling.Text = "Cycling";
            chkcycling.UseVisualStyleBackColor = true;
            chkcycling.CheckedChanged += chkcycling_CheckedChanged_1;
            // 
            // chkrowing
            // 
            chkrowing.AutoSize = true;
            chkrowing.Location = new Point(551, 18);
            chkrowing.Name = "chkrowing";
            chkrowing.Size = new Size(66, 19);
            chkrowing.TabIndex = 10;
            chkrowing.Text = "Rowing";
            chkrowing.UseVisualStyleBackColor = true;
            chkrowing.CheckedChanged += chkrowing_CheckedChanged;
            // 
            // chkyoga
            // 
            chkyoga.AutoSize = true;
            chkyoga.Location = new Point(462, 18);
            chkyoga.Name = "chkyoga";
            chkyoga.Size = new Size(52, 19);
            chkyoga.TabIndex = 9;
            chkyoga.Text = "Yoga";
            chkyoga.UseVisualStyleBackColor = true;
            chkyoga.CheckedChanged += chkyoga_CheckedChanged;
            // 
            // chkwalking
            // 
            chkwalking.AutoSize = true;
            chkwalking.Location = new Point(373, 19);
            chkwalking.Name = "chkwalking";
            chkwalking.Size = new Size(69, 19);
            chkwalking.TabIndex = 8;
            chkwalking.Text = "Walking";
            chkwalking.UseVisualStyleBackColor = true;
            chkwalking.CheckedChanged += chkwalking_CheckedChanged;
            // 
            // chkswimming
            // 
            chkswimming.AutoSize = true;
            chkswimming.Location = new Point(284, 18);
            chkswimming.Name = "chkswimming";
            chkswimming.Size = new Size(83, 19);
            chkswimming.TabIndex = 7;
            chkswimming.Text = "Swimming";
            chkswimming.UseVisualStyleBackColor = true;
            chkswimming.CheckedChanged += chkswimming_CheckedChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(263, 28);
            label2.TabIndex = 6;
            label2.Text = "Select the Activity in here:";
            // 
            // pnrunning
            // 
            pnrunning.BackColor = Color.DarkSlateGray;
            pnrunning.Controls.Add(txtrunningavgpace);
            pnrunning.Controls.Add(txtrunningduration);
            pnrunning.Controls.Add(txtrunningdistance);
            pnrunning.Controls.Add(label18);
            pnrunning.Controls.Add(label19);
            pnrunning.Controls.Add(label20);
            pnrunning.Location = new Point(563, 307);
            pnrunning.Name = "pnrunning";
            pnrunning.Size = new Size(274, 141);
            pnrunning.TabIndex = 5;
            // 
            // txtrunningavgpace
            // 
            txtrunningavgpace.Location = new Point(103, 95);
            txtrunningavgpace.Name = "txtrunningavgpace";
            txtrunningavgpace.Size = new Size(142, 23);
            txtrunningavgpace.TabIndex = 11;
            // 
            // txtrunningduration
            // 
            txtrunningduration.Location = new Point(103, 62);
            txtrunningduration.Name = "txtrunningduration";
            txtrunningduration.Size = new Size(142, 23);
            txtrunningduration.TabIndex = 10;
            // 
            // txtrunningdistance
            // 
            txtrunningdistance.Location = new Point(103, 23);
            txtrunningdistance.Name = "txtrunningdistance";
            txtrunningdistance.Size = new Size(142, 23);
            txtrunningdistance.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(29, 99);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 8;
            label18.Text = "Avg Pace";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(29, 66);
            label19.Name = "label19";
            label19.Size = new Size(53, 15);
            label19.TabIndex = 7;
            label19.Text = "Duration";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(29, 32);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 6;
            label20.Text = "Distance";
            // 
            // pnyoga
            // 
            pnyoga.BackColor = Color.GreenYellow;
            pnyoga.Controls.Add(txtintensity);
            pnyoga.Controls.Add(txtpoes);
            pnyoga.Controls.Add(txtyogaduration);
            pnyoga.Controls.Add(label9);
            pnyoga.Controls.Add(label10);
            pnyoga.Controls.Add(label11);
            pnyoga.Location = new Point(563, 162);
            pnyoga.Name = "pnyoga";
            pnyoga.Size = new Size(274, 141);
            pnyoga.TabIndex = 2;
            // 
            // txtintensity
            // 
            txtintensity.Location = new Point(116, 95);
            txtintensity.Name = "txtintensity";
            txtintensity.Size = new Size(142, 23);
            txtintensity.TabIndex = 11;
            // 
            // txtpoes
            // 
            txtpoes.Location = new Point(116, 62);
            txtpoes.Name = "txtpoes";
            txtpoes.Size = new Size(142, 23);
            txtpoes.TabIndex = 10;
            // 
            // txtyogaduration
            // 
            txtyogaduration.Location = new Point(116, 23);
            txtyogaduration.Name = "txtyogaduration";
            txtyogaduration.Size = new Size(142, 23);
            txtyogaduration.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 98);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 8;
            label9.Text = "Intensity Level";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 65);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 7;
            label10.Text = "No of Poses";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 31);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 6;
            label11.Text = "Duration";
            // 
            // pncycling
            // 
            pncycling.BackColor = Color.MediumAquamarine;
            pncycling.Controls.Add(txtcyclingdistance);
            pncycling.Controls.Add(txtcyclingduration);
            pncycling.Controls.Add(txtavgspeed);
            pncycling.Controls.Add(label15);
            pncycling.Controls.Add(label16);
            pncycling.Controls.Add(label17);
            pncycling.Location = new Point(283, 307);
            pncycling.Name = "pncycling";
            pncycling.Size = new Size(274, 141);
            pncycling.TabIndex = 4;
            // 
            // txtcyclingdistance
            // 
            txtcyclingdistance.Location = new Point(103, 95);
            txtcyclingdistance.Name = "txtcyclingdistance";
            txtcyclingdistance.Size = new Size(142, 23);
            txtcyclingdistance.TabIndex = 11;
            // 
            // txtcyclingduration
            // 
            txtcyclingduration.Location = new Point(103, 62);
            txtcyclingduration.Name = "txtcyclingduration";
            txtcyclingduration.Size = new Size(142, 23);
            txtcyclingduration.TabIndex = 10;
            // 
            // txtavgspeed
            // 
            txtavgspeed.Location = new Point(103, 23);
            txtavgspeed.Name = "txtavgspeed";
            txtavgspeed.Size = new Size(142, 23);
            txtavgspeed.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 99);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 8;
            label15.Text = "Distance";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 66);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 7;
            label16.Text = "Duration";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 32);
            label17.Name = "label17";
            label17.Size = new Size(63, 15);
            label17.TabIndex = 6;
            label17.Text = "Avg Speed";
            // 
            // pnrowing
            // 
            pnrowing.BackColor = Color.DarkSeaGreen;
            pnrowing.Controls.Add(txtstockperminute);
            pnrowing.Controls.Add(txtrowingduration);
            pnrowing.Controls.Add(txtrowingdistance);
            pnrowing.Controls.Add(label12);
            pnrowing.Controls.Add(label13);
            pnrowing.Controls.Add(label14);
            pnrowing.Location = new Point(3, 307);
            pnrowing.Name = "pnrowing";
            pnrowing.Size = new Size(274, 141);
            pnrowing.TabIndex = 3;
            // 
            // txtstockperminute
            // 
            txtstockperminute.Location = new Point(127, 95);
            txtstockperminute.Name = "txtstockperminute";
            txtstockperminute.Size = new Size(142, 23);
            txtstockperminute.TabIndex = 11;
            // 
            // txtrowingduration
            // 
            txtrowingduration.Location = new Point(127, 62);
            txtrowingduration.Name = "txtrowingduration";
            txtrowingduration.Size = new Size(142, 23);
            txtrowingduration.TabIndex = 10;
            // 
            // txtrowingdistance
            // 
            txtrowingdistance.Location = new Point(127, 23);
            txtrowingdistance.Name = "txtrowingdistance";
            txtrowingdistance.Size = new Size(142, 23);
            txtrowingdistance.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 99);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 8;
            label12.Text = "Stock Per Minute";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 66);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 7;
            label13.Text = "Duration";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 32);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 6;
            label14.Text = "Distance";
            // 
            // pnwalking
            // 
            pnwalking.BackColor = Color.Olive;
            pnwalking.Controls.Add(txtwalkingtime);
            pnwalking.Controls.Add(txtwalkingdistance);
            pnwalking.Controls.Add(txtsteps);
            pnwalking.Controls.Add(label6);
            pnwalking.Controls.Add(label7);
            pnwalking.Controls.Add(label8);
            pnwalking.Location = new Point(283, 162);
            pnwalking.Name = "pnwalking";
            pnwalking.Size = new Size(274, 141);
            pnwalking.TabIndex = 2;
            // 
            // txtwalkingtime
            // 
            txtwalkingtime.Location = new Point(103, 95);
            txtwalkingtime.Name = "txtwalkingtime";
            txtwalkingtime.Size = new Size(142, 23);
            txtwalkingtime.TabIndex = 11;
            // 
            // txtwalkingdistance
            // 
            txtwalkingdistance.Location = new Point(103, 62);
            txtwalkingdistance.Name = "txtwalkingdistance";
            txtwalkingdistance.Size = new Size(142, 23);
            txtwalkingdistance.TabIndex = 10;
            // 
            // txtsteps
            // 
            txtsteps.Location = new Point(103, 23);
            txtsteps.Name = "txtsteps";
            txtsteps.Size = new Size(142, 23);
            txtsteps.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 98);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "TimeTaken";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 65);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 7;
            label7.Text = "Distance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 31);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 6;
            label8.Text = "Steps";
            // 
            // pnswimming
            // 
            pnswimming.BackColor = Color.PaleGoldenrod;
            pnswimming.Controls.Add(txtswimtime);
            pnswimming.Controls.Add(txtheartbeat);
            pnswimming.Controls.Add(txtlaps);
            pnswimming.Controls.Add(label5);
            pnswimming.Controls.Add(label4);
            pnswimming.Controls.Add(label3);
            pnswimming.Location = new Point(3, 162);
            pnswimming.Name = "pnswimming";
            pnswimming.Size = new Size(274, 141);
            pnswimming.TabIndex = 1;
            // 
            // txtswimtime
            // 
            txtswimtime.Location = new Point(90, 88);
            txtswimtime.Name = "txtswimtime";
            txtswimtime.Size = new Size(142, 23);
            txtswimtime.TabIndex = 5;
            // 
            // txtheartbeat
            // 
            txtheartbeat.Location = new Point(90, 55);
            txtheartbeat.Name = "txtheartbeat";
            txtheartbeat.Size = new Size(142, 23);
            txtheartbeat.TabIndex = 4;
            // 
            // txtlaps
            // 
            txtlaps.Location = new Point(90, 16);
            txtlaps.Name = "txtlaps";
            txtlaps.Size = new Size(142, 23);
            txtlaps.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 91);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 2;
            label5.Text = "TimeTaken";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 58);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 1;
            label4.Text = "HeartBeat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "Laps";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 96);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(188, 41);
            label1.Name = "label1";
            label1.Size = new Size(470, 54);
            label1.TabIndex = 0;
            label1.Text = "Transformer Fitness Pro";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcDashboard";
            Size = new Size(849, 544);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnrunning.ResumeLayout(false);
            pnrunning.PerformLayout();
            pnyoga.ResumeLayout(false);
            pnyoga.PerformLayout();
            pncycling.ResumeLayout(false);
            pncycling.PerformLayout();
            pnrowing.ResumeLayout(false);
            pnrowing.PerformLayout();
            pnwalking.ResumeLayout(false);
            pnwalking.PerformLayout();
            pnswimming.ResumeLayout(false);
            pnswimming.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel pnswimming;
        private Panel pnrunning;
        private Panel pnyoga;
        private Panel pncycling;
        private Panel pnrowing;
        private Panel pnwalking;
        private Panel panel3;
        private CheckBox chkrunning;
        private CheckBox chkcycling;
        private CheckBox chkrowing;
        private CheckBox chkyoga;
        private CheckBox chkwalking;
        private CheckBox chkswimming;
        private Label label2;
        private TextBox txtswimtime;
        private TextBox txtheartbeat;
        private TextBox txtlaps;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtrunningavgpace;
        private TextBox txtrunningduration;
        private TextBox txtrunningdistance;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox txtintensity;
        private TextBox txtpoes;
        private TextBox txtyogaduration;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtcyclingdistance;
        private TextBox txtcyclingduration;
        private TextBox txtavgspeed;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtstockperminute;
        private TextBox txtrowingduration;
        private TextBox txtrowingdistance;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtwalkingtime;
        private TextBox txtwalkingdistance;
        private TextBox txtsteps;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label21;
        private Label lblcaloriesburn;
        private Label label25;
        private Label label24;
        private TextBox txtTarget;
        private Button btnStart;
        private Label lblRemainingCalories;
    }
}
