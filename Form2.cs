using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Skills_International_School
{
    
    public partial class form2 : Form
    {
       // SqlConnection cnn = new SqlConnection(@"Data Source=GIRLFRIEND-2\LOCAL_SERVER;Initial Catalog=Student;Integrated Security=True");
        public form2()
        {
            InitializeComponent();
            //loadRegNo();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ClearFields();
        }
        /*
        private void btnRegister_Click(object sender, EventArgs e)
        {

            // cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("insert into Registration values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + DateTime.Parse(txtDOB.Text) + "','" + getGender() + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + int.Parse(txtMobile.Text) + "','" + int.Parse(txtHome.Text) + "','" + txtParent.Text + "','" + txtNIC.Text + "','" + int.Parse(txtcontact.Text) + "')", cnn);
                command.ExecuteNonQuery();

                MessageBox.Show("Record Added Successfully", "Register Student",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Add Failed", "Register Student",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadRegNo();
        }

        */
/*
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(txtRegNo.Text.Length > 0))
            {
                MessageBox.Show("Please select a record", "Update",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int regNumber = int.Parse(txtRegNo.Text);

            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("update Registration set firstName = '" + txtFirstName.Text + "', lastName = '" + txtLastName.Text + "',dateOfBirth = '" + DateTime.Parse(txtDOB.Text) + "',gender = '" + getGender() + "',address = '" + txtAddress.Text + "',email = '" + txtEmail.Text + "',mobilePhone = '" + int.Parse(txtMobile.Text) + "',homePhone = '" + int.Parse(txtHome.Text) + "',parentName = '" + txtParent.Text + "',nic = '" + txtNIC.Text + "',contactNo = '" + int.Parse(txtcontact.Text) + "' where  regNo = '" + regNumber + "'", cnn);
                command.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Update Student",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Updated Failed", "Update Student",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, Do you really want to Delete this Record..?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                int regNumber = int.Parse( txtRegNo.Text );
                try
                {
                    cnn.Open();
                    SqlCommand command = new SqlCommand("Delete from Registration where  regNo = '" + regNumber + "'", cnn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully", "Update Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);


                    cnn.Close();
                    loadRegNo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Delete Failed", "Update Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
*/
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit..?", "Exit", buttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Close();
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();

        }

        /*
                private void loadRegNo()
                {            

                    DataSet dataSet = new DataSet();

                    string getRegNoSql = "Select regNo from Registration";
                    SqlDataAdapter sqlData = new SqlDataAdapter(getRegNoSql, cnn);

                    try
                    {
                        cnn.Open();
                        sqlData.Fill(dataSet);
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("An error occured while connecting to database" + se.ToString());
                    }
                    finally
                    {
                        cnn.Close();
                    }

                    txtRegNo.DataSource = dataSet.Tables[0];
                    txtRegNo.DisplayMember = dataSet.Tables[0].Columns[0].ToString();

                }
        */
        /*
                private string getGender()
                {
                    string gender;
                    if (rdoMale.Checked)
                        gender = rdoMale.Text;
                    else if (rdoFemale.Checked)
                        gender = rdoFemale.Text;
                    else
                        gender = "";

                    return gender;
                }
        */
        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtHome.Text = "";
            txtParent.Text = "";
            txtNIC.Text = "";
            txtcontact.Text = "";
        }
       
        private void txtRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
           SqlConnection connection;
           SqlCommand command;
           connection = new SqlConnection();
           connection.ConnectionString = @"Data Source=GIRLFRIEND-2\LOCAL_SERVER;Initial Catalog=Student;Integrated Security=True";
           command = new SqlCommand();
           command.Connection = connection;
           command.CommandType = CommandType.Text;

           command.CommandText = "Select * from Registration where regNo = '" + txtRegNo.Text + "'";
           try
           {
               connection.Open();
               SqlDataReader reader = command.ExecuteReader();
               if (reader.HasRows)
               {
                   while (reader.Read())
                   {

                       txtFirstName.Text = reader.GetString(1).ToString();
                       txtLastName.Text = reader.GetString(2).ToString();
                       txtDOB.Text = reader.GetSqlDateTime(3).ToString();
                       if (reader.GetString(4).ToString() == "Male")
                       {
                           rdoMale.Checked = true;
                       }
                       else
                       {
                           rdoFemale.Checked = true;
                       }
                       txtAddress.Text = reader.GetString(5);
                       txtEmail.Text = reader.GetString(6).ToString();
                       txtMobile.Text = reader.GetInt32(7).ToString();
                       txtHome.Text = reader.GetInt32(8).ToString();
                       txtParent.Text = reader.GetString(9).ToString();
                       txtNIC.Text = reader.GetInt32(9).ToString();
                       txtcontact.Text = reader.GetInt32(10).ToString();


                   }
               }
           }catch (Exception ex)
           {

           }
       finally
       {
           connection.Close();
       }
*/

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }


}
