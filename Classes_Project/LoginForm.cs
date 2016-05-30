using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Classes_Project
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        private string password;

        public LoginForm()
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
            GetalClick(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            GetalClick(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            GetalClick(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            GetalClick(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            GetalClick(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            GetalClick(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            GetalClick(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            GetalClick(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            GetalClick(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            GetalClick(0);
        }

        private void GetalClick(int getal)
        {
            password += getal;
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
                        if (m.Rol == MedewerkerRol.Manager)
                        {
                            MainForm mayamaya = new MainForm(m);
                            mayamaya.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else if (m.Rol == MedewerkerRol.Bediening)
                        {
                            BedieningForm bediening = new BedieningForm(m);
                            bediening.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else if (m.Rol == MedewerkerRol.Keuken)
                        {
                            KeukenOverzicht Keuken = new KeukenOverzicht();
                            Keuken.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else if (m.Rol == MedewerkerRol.Bar)
                        {
                            BarOverzicht Bar = new BarOverzicht();
                            Bar.Show();
                            this.Hide();
                            conn.Close();
                        }
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



        private void Shake()
        {
            Point original = txt_Password.Location;
            Random rnd = new Random(5);
            int shakeAmplitude = 20;
            for (int i = 0; i < 10; i++)
            {
                txt_Password.Location = new Point(original.X + rnd.Next(-shakeAmplitude, shakeAmplitude), original.Y);
                System.Threading.Thread.Sleep(30);
            }
            txt_Password.Location = original;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (password.Length > 0)
            {
                password = password.Remove(password.Length - 1);
                txt_Password.Text = txt_Password.Text.Remove(txt_Password.TextLength - 1);
            }
        }
    }
}
