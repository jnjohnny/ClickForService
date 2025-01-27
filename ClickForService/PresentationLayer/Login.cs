﻿using System;
using System.Collections.Generic;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }


        public static string username;
        public static string UserName
        {
            set { username = value; }
            get { return username; }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM userpermissions WHERE userName='" + textBoxUsername.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string Permission = Convert.ToString(reader["uniqueCode"]);
                string passwordtext = Convert.ToString(reader["password"]);
                if (passwordtext == Convert.ToString(textBoxPassword.Text))
                {
                    username = Convert.ToString(textBoxUsername.Text);
                    if (Permission == "ST")
                    {
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                    else if(Permission=="GU")
                    {

                        AddServiceProviderDetails addServiceProviderDetails = new AddServiceProviderDetails(textBoxUsername.Text);
                        this.Hide();
                        addServiceProviderDetails.Show();
       

                    }

                    else
                    {
                        DashboardforAdmin dfa = new DashboardforAdmin();
                        this.Hide();
                        dfa.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password...!!");
                    connection.Close();
                }
            }

            else
            {
                MessageBox.Show("Wrong Username or Password...!!");
                connection.Close();
            }



        }

       /* private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }*/

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
