using System;
using System.Windows.Forms;

namespace KhineYar.Calo.WinForm
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the UCLogin user control
            UCLogin ucLogin = new UCLogin();
            ucLogin.MainForm = this;
            
            panel3.Controls.Add(ucLogin);
         
            ucLogin.Location = new System.Drawing.Point(0, 0);
            ucLogin.Size = panel3.Size;
           
            ucLogin.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the UCLogin user control
            UCRegister ucregister = new UCRegister();

            // Set the properties of the UCLogin control if needed

            // Add the UCLogin control to panel3
            panel3.Controls.Add(ucregister);

            // Set the position and size of the UCLogin control within panel3
            ucregister.Location = new System.Drawing.Point(0, 0);
            ucregister.Size = panel3.Size;

            // Bring the UCLogin control to the front
            ucregister.BringToFront();
        }
    }
}
