using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Classes_Project;
using System.Drawing;

namespace Inlog
{
    public partial class Inlogscherm : Form
    {
        SqlConnection conn;
        private string password;

        public Inlogscherm()
        {
            InitializeComponent();
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
            if (conn.State != ConnectionState.Open)
            {
                lbl_Info.Text = "Kon niet verbinden met de server";
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
            if (password.Length == 4)
            {
                if (conn.State == ConnectionState.Open)
                {
                    lbl_Info.Text = "Bezig met inloggen...";

                    MedewerkerDAO mDAO = new MedewerkerDAO();
                    Medewerker m = mDAO.GetByPincode(password);

                    if (m != null)
                    {

                        MayaMaya mayamaya = new MayaMaya(m);
                        mayamaya.Show();
                        this.Hide();
                        conn.Close();
                    }
                    else
                    {
                        Shake();
                        lbl_Info.Text = "Inloggen niet geslaagd. Probeer het nog een keer.";
                        password = "";
                        txt_Password.Text = "";
                    }
                }
                else
                {
                    lbl_Info.Text = "Kon niet verbinden met de server";
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (password.Length > 0)
            {
                password = password.Remove(password.Length - 1);
                txt_Password.Text = txt_Password.Text.Remove(txt_Password.TextLength - 1);
            }
        }

        private void Shake()
        {
            Point original = txt_Password.Location;
            Random rnd = new Random(5);
            const int shake_amplitude = 20;
            for (int i = 0; i < 10; i++)
            {
                txt_Password.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y);
                System.Threading.Thread.Sleep(30);
            }
            txt_Password.Location = original;
        }
    }
}
