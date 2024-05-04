using MySqlConnector;
using System;
using System.Windows.Forms;

namespace KhineYar.Calo.WinForm
{
    public partial class UCLogin : UserControl
    {
        public Frm_main MainForm;

        public UCLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtpassword.Text))
                {
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM user WHERE Name = @Username AND Password = @Password";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", txtname.Text);
                        command.Parameters.AddWithValue("@Password", txtpassword.Text);
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                UcDashboard ucDashboard = new UcDashboard();

                                // Add the UCDashboard control to MainForm's panel3
                                MainForm.panel3.Controls.Add(ucDashboard);

                                // Set the position and size of the UCDashboard control within panel3
                                ucDashboard.Location = new System.Drawing.Point(0, 0);
                                ucDashboard.Size = MainForm.panel3.Size;

                                // Bring the UCDashboard control to the front
                                ucDashboard.BringToFront();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
