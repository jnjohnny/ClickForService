using System;
using System.Collections.Generic ;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickForService.PresentationLayer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void MobilenumberregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Loginregisterbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AgreeregistercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgreeregistercheckBox.Checked)
            {
                Registerformbutton.Enabled = true;
            }
            else Registerformbutton.Enabled = false;
        }

        private void CountryregistercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleregisterradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaleregisterradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateofbirthregisterdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmailregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmpasswordregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            ////Login login = new Login();
            //this.Hide();
            //login.Show();

            if (AgreeregistercheckBox.Text == "")
            {
                MessageBox.Show("agree can not be empty");
            }

            else if (NameregistertextBox.Text == "")
            { MessageBox.Show("Name can not be empty"); }

            else if (UsernameregistertextBox.Text == "")
            { MessageBox.Show("User Name can not be empty"); }

            else if (PasswordregistertextBox.Text == "")
            { MessageBox.Show("Password can not be empty"); }

            else if (ConfirmpasswordregistertextBox.Text == "")
            { MessageBox.Show("Confrim Password can not be empty"); }

            else if (EmailregistertextBox.Text == "")
            { MessageBox.Show("Email can not be empty"); }

            else if (DateofbirthregisterdateTimePicker.Text == "")
            { MessageBox.Show("Date of Birth can not be empty"); }

            else if (MaleregisterradioButton.Text == "" && FemaleregisterradioButton.Text == "")
            { MessageBox.Show("Gender can not be empty"); }

            else if (CityregistercomboBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }

            else if (NidregistertextBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }

            else if (MobilenumberregistertextBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }

            else if (DivisionregistercomboBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }

            else if (AddressregistertextBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }

            else if (CategoryregistercomboBox.Text == "")
            { MessageBox.Show("Blood Group can not be empty"); }



            else
            {
                SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
                connect.Open();
                string Gender = "";
                if (MaleregisterradioButton.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                string sql1 = "INSERT INTO Registrations(userName, emailId, password, category, Address, City, Division, bloodGroup, mobileNumber, NID, fullName, dateofbirth, gender, Profession) VALUES('" + UsernameregistertextBox.Text + "','" + EmailregistertextBox.Text + "', '" + PasswordregistertextBox.Text + "','" + CategoryregistercomboBox.Text + "','" + AddressregistertextBox.Text + "','" + CityregistercomboBox.Text + "','" + DivisionregistercomboBox.Text + "','" + BloodgroupregistercomboBox.Text + "','" + MobilenumberregistertextBox.Text + "','" + NidregistertextBox.Text + "','" + NameregistertextBox.Text + "','" + DateofbirthregisterdateTimePicker.Text + "','" + Gender + "','" + ProfessionregistercomboBox.Text + "')";

                string ab="";
               if(CategoryregistercomboBox.Text=="Service Giver")
                {
                     ab = "GU";
                }
               else 
                { ab = "ST"; }

                
                
                SqlCommand command1 = new SqlCommand(sql1, connect);

                int result = command1.ExecuteNonQuery();
                if (result > 0)
                {
                    string sql2 = "INSERT INTO userpermissions(userName, uniqueCode, password, Designation) VALUES('" + UsernameregistertextBox.Text + "','" + ab + "', '" + PasswordregistertextBox.Text + "','" + "" + "')";
                    SqlCommand command2 = new SqlCommand(sql2, connect);
                    int result3 = command2.ExecuteNonQuery();


                    MessageBox.Show("Registration Sucessful....Please Login");
                    Login login = new Login();
                    this.Hide();
                    login.Show();

                    connect.Close();

                }
                else
                {
                    MessageBox.Show("Error");
                    connect.Close();

                }





                connect.Close();
            }



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
