using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txtUsername.Text.Length>0 && txtPassword.Text.Length > 0))
            {
                MessageBox.Show("Please enter username & password");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(login(username, password))//username == "Admin" && password == "Skills@123"
            {
                form2 form2 = new form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credintials, please check Username and Password and try again", "Invalid login Details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit..?", "Exit", buttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            
        }

        private bool login(string username, string password)
        {
            SqlConnection cnn;
            string connetionString;
            connetionString = @"Data Source=GIRLFRIEND-2\LOCAL_SERVER;Initial Catalog=Student;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Logins WHERE username='" + username + "' AND password='" + password + "'", cnn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
                return false;
        }
    }
}
