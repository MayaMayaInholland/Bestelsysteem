using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Project
{
    public partial class KeukenOverzicht : Form
    {
        public KeukenOverzicht(Medewerker m)
        {
            InitializeComponent();

            List<Product> Lijst_ActiveProducten = new List<Product>();

            KeukenDAO keukenDAO = new KeukenDAO();
            Lijst_ActiveProducten = keukenDAO.GetActiveBesteldeProducten();
            

            lbl_IngelogdeMedewerker.Text = m.Voornaam;


            int teller = 1;


            int y = 0;
            int yToe = 40;
            int YLBL = 10;


            List<Product> lijst_NietActiveroducten = new List<Product>();
            lijst_NietActiveroducten = keukenDAO.GetKLAARBesteldeProducten();

            y = 0;
            yToe = 40;
            YLBL = 10;

            foreach (Product p in lijst_NietActiveroducten)
            {
                KlaarKnoppen(ref teller, ref y, yToe, ref YLBL, p);
            }

            foreach (Product p in Lijst_ActiveProducten)
            {
                Maakknoppen(ref teller, ref y, yToe, ref YLBL, p);
            }

        }

       

        private void KlaarKnoppen(ref int teller, ref int y, int yToe, ref int YLBL, Product p)
        {
            y += yToe;
            Button buttonKlaar = new System.Windows.Forms.Button();
            buttonKlaar.Location = new System.Drawing.Point(47, y);
            buttonKlaar.Name = "buttonklaar" + teller;
            buttonKlaar.Size = new System.Drawing.Size(745, 34);
            buttonKlaar.TabIndex = 101;
            buttonKlaar.UseVisualStyleBackColor = true;

            Label BestelKlaar_lbl = new System.Windows.Forms.Label();
            BestelKlaar_lbl.AutoSize = true;
            BestelKlaar_lbl.Location = new System.Drawing.Point(90, YLBL += yToe);
            BestelKlaar_lbl.Name = "Bestelklaar_lbl" + teller;
            BestelKlaar_lbl.Size = new System.Drawing.Size(35, 13);
            BestelKlaar_lbl.TabIndex = 22;
            BestelKlaar_lbl.Text = p.ToString();

            Button NietKlaar_btn = new System.Windows.Forms.Button();
            NietKlaar_btn.BackColor = System.Drawing.Color.Red;
            NietKlaar_btn.Location = new System.Drawing.Point(798, y);
            NietKlaar_btn.Name = "nietKlaar_btn" + teller;
            NietKlaar_btn.Size = new System.Drawing.Size(78, 34);
            NietKlaar_btn.TabIndex = 32;
            NietKlaar_btn.Text = "Niet Klaar";
            NietKlaar_btn.UseVisualStyleBackColor = true;

            

            if (teller % 2 == 0)
            {

                buttonKlaar.BackColor = System.Drawing.Color.DarkGray;
            }

            teller++;
            Geschiedenis.Controls.Add(BestelKlaar_lbl);
            Geschiedenis.Controls.Add(NietKlaar_btn);
            Geschiedenis.Controls.Add(buttonKlaar);
        }

        public void Maakknoppen(ref int teller, ref int y, int yToe, ref int YLBL, Product p)
        {
            y += yToe;
            Button button = new System.Windows.Forms.Button();
            button.Location = new System.Drawing.Point(47, y);
            button.Name = "button" + teller;
            button.Size = new System.Drawing.Size(745, 34);
            button.TabIndex = 101;
            button.UseVisualStyleBackColor = true;

            Label Bestel_lbl = new System.Windows.Forms.Label();
            Bestel_lbl.AutoSize = true;
            Bestel_lbl.Location = new System.Drawing.Point(90, YLBL += yToe);
            Bestel_lbl.Name = "Bestel_lbl" + teller;
            Bestel_lbl.Size = new System.Drawing.Size(35, 13);
            Bestel_lbl.TabIndex = 22;
            Bestel_lbl.Text = p.ToString();

            Button Klaar_btn = new System.Windows.Forms.Button();
            Klaar_btn.Location = new System.Drawing.Point(798, y);
            Klaar_btn.Name = "Klaar_btn" + teller;
            Klaar_btn.Size = new System.Drawing.Size(78, 34);
            Klaar_btn.TabIndex = 32;
            Klaar_btn.Text = "Klaar";
            Klaar_btn.UseVisualStyleBackColor = true;
            Klaar_btn.Click += new EventHandler(handleClick);
            Klaar_btn.Tag = p;

            

            if (teller % 2 == 0)
            {
                Klaar_btn.BackColor = System.Drawing.Color.DarkGray;
                button.BackColor = System.Drawing.Color.DarkGray;
            }

            teller++;
            BarNu.Controls.Add(Bestel_lbl);
            BarNu.Controls.Add(Klaar_btn);
            BarNu.Controls.Add(button);
        }

        private void handleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            Button button = (Button)sender;
            int bestellingID = (int)button.Tag;
        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void btn_Loguit_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }

        private void KeukenOverzicht_Load(object sender, EventArgs e)
        {

        }
    }
}
