using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Inlog
{
    public partial class Form1 : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["ReserveringenConnectionStringsSQL"].ConnectionString;
        SqlConnection conn; 
        private string password;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
            conn.Open();
            if (conn.State != ConnectionState.Open)
            {
                lbl_Info.Text = "Kon niet verbinden met server";
            }
            else
            {
               // lbl_Info.Text = "Verbonden!";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            password += 1;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            password += 2;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            password += 3;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            password += 4;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            password += 5;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            password += 6;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            password += 7;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            password += 8;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            password += 9;
            txt_Password.Text += "*";
            VerifyPassword();
        }

        private void VerifyPassword()
        {
            if(password.Length == 4)
            {
                lbl_Info.Text = "Bezig met inloggen..."; 
                //query DB
            }
        }
    }
}
