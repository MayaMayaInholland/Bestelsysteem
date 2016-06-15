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
    public partial class BarOverzicht : Form
    {
        private Medewerker medewerker;
        public BarOverzicht(Medewerker m, string meer, string rol)
        {
            InitializeComponent();

            kop.Text = rol;

            lbl_IngelogdeMedewerker.Text = m.Voornaam;

            MaakAlleKnoppen(meer);

        }

        private void MaakAlleKnoppen(string meer)
        {
            int teller = 1;
            int y = 0;
            int yToe = 40;
            int YLBL = 0;
            int NieuweTafel = 0;
            int Nieuwekleur = 1;

            List<Besteld_product> lijst_NietActiveroducten = new List<Besteld_product>();

            int status = 2;

            BarDAO keukenDAO2 = new BarDAO();
            lijst_NietActiveroducten = keukenDAO2.GetActiveBesteldeProducten(status, meer);

            y = 0;
            yToe = 40;
            YLBL = 10;
            Nieuwekleur = 1;

            Control tap = Geschiedenis;

            foreach (Besteld_product p in lijst_NietActiveroducten)
            {
                KlaarKnoppen(ref Nieuwekleur, ref NieuweTafel, ref teller, ref y, yToe, ref YLBL, p, tap);
            }


            teller = 1;
            y = 0;
            yToe = 40;
            YLBL = 10;
            NieuweTafel = 0;
            Nieuwekleur = 1;

            tap = BarNu;

            List<Besteld_product> Lijst_ActiveProducten = new List<Besteld_product>();

            status = 1;

            BarDAO barDAO = new BarDAO();
            Lijst_ActiveProducten = barDAO.GetActiveBesteldeProducten(status, meer);

            foreach (Besteld_product p in Lijst_ActiveProducten)
            {
                KlaarKnoppen(ref Nieuwekleur, ref NieuweTafel, ref teller, ref y, yToe, ref YLBL, p, tap);
            }
        }


        private void KlaarKnoppen(ref int Nieuwekleur, ref int NieuweTafel, ref int teller, ref int y, int yToe, ref int YLBL, Besteld_product p, Control tap)
        {


            Label BestelKlaar_lbl = new System.Windows.Forms.Label();
            BestelKlaar_lbl.AutoSize = true;
            BestelKlaar_lbl.Location = new System.Drawing.Point(90 + 70, YLBL += yToe);
            BestelKlaar_lbl.Name = "Bestelklaar_lbl" + teller;
            BestelKlaar_lbl.Size = new System.Drawing.Size(35, 13);
            BestelKlaar_lbl.TabIndex = 22;
            BestelKlaar_lbl.Text = (p.Omschrijving).ToString();
            BestelKlaar_lbl.BackColor = System.Drawing.Color.Gainsboro;


            y += yToe;
            Button buttonKlaar = new System.Windows.Forms.Button();
            buttonKlaar.Location = new System.Drawing.Point(47 + 70, y);
            buttonKlaar.Name = "buttonklaar" + teller;
            buttonKlaar.Size = new System.Drawing.Size(645 + 30, 34);
            buttonKlaar.TabIndex = 101;
            buttonKlaar.UseVisualStyleBackColor = true;

            Label Opmerking_lbl = new System.Windows.Forms.Label();
            Opmerking_lbl.AutoSize = true;
            Opmerking_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Opmerking_lbl.Location = new System.Drawing.Point(90 + 100, YLBL + 10);
            Opmerking_lbl.ForeColor = System.Drawing.Color.Red;
            Opmerking_lbl.Name = "Opmerking_lbl" + teller;
            Opmerking_lbl.Size = new System.Drawing.Size(35, 13);
            Opmerking_lbl.TabIndex = 22;
            Opmerking_lbl.Text = p.Opmerking.ToString();



            if (NieuweTafel != p.Tafel_nummer)
            {
                Label Tafelnummer_lbl = new System.Windows.Forms.Label();
                Tafelnummer_lbl.AutoSize = true;
                Tafelnummer_lbl.Location = new System.Drawing.Point(85, y + 10);
                Tafelnummer_lbl.Name = "Bestel_lbl" + teller;
                Tafelnummer_lbl.Size = new System.Drawing.Size(40, 34);
                Tafelnummer_lbl.TabIndex = 22;
                Tafelnummer_lbl.Text = p.Tafel_nummer.ToString();
                tap.Controls.Add(Tafelnummer_lbl);
                Tafelnummer_lbl.BackColor = System.Drawing.Color.Gainsboro;

                Button Tafel_btn = new System.Windows.Forms.Button();
                Tafel_btn.Location = new System.Drawing.Point(70, y);
                Tafel_btn.Name = "button" + teller;
                Tafel_btn.Size = new System.Drawing.Size(40, 34);
                Tafel_btn.TabIndex = 101;
                Tafel_btn.UseVisualStyleBackColor = true;
                tap.Controls.Add(Tafel_btn);
                Opmerking_lbl.BackColor = System.Drawing.Color.Gainsboro;


                Button NietKlaar_btn = new System.Windows.Forms.Button();
                NietKlaar_btn.BackColor = System.Drawing.Color.Red;
                NietKlaar_btn.Location = new System.Drawing.Point(798, y);
                NietKlaar_btn.Name = "nietKlaar_btn" + teller;
                NietKlaar_btn.Size = new System.Drawing.Size(78, 34);
                NietKlaar_btn.TabIndex = 32;
                NietKlaar_btn.Text = "Niet Klaar";
                NietKlaar_btn.UseVisualStyleBackColor = true;



                NietKlaar_btn.Click += new EventHandler(NietKlaarClick);
                NietKlaar_btn.Tag = p;
                tap.Controls.Add(NietKlaar_btn);

                if (Nieuwekleur % 2 == 0)
                {
                    NietKlaar_btn.BackColor = System.Drawing.Color.DarkGray;
                    Tafel_btn.BackColor = System.Drawing.Color.DarkGray;
                    Tafelnummer_lbl.BackColor = System.Drawing.Color.DarkGray;
                    Opmerking_lbl.BackColor = System.Drawing.Color.DarkGray;
                }

                Nieuwekleur++;
            }

            NieuweTafel = p.Tafel_nummer;

            if (Nieuwekleur % 2 != 0)
            {
                BestelKlaar_lbl.BackColor = System.Drawing.Color.DarkGray;
                buttonKlaar.BackColor = System.Drawing.Color.DarkGray;
            }

            teller++;
            tap.Controls.Add(BestelKlaar_lbl);

            if (p.Opmerking != " ")
            {
                tap.Controls.Add(Opmerking_lbl);
            }

            tap.Controls.Add(buttonKlaar);
        }

        private void NietKlaarClick(object sender, EventArgs e)
        {
            BarDAO keukenDAO = new BarDAO();
            Button button = (Button)sender;
            Besteld_product product = (Besteld_product)button.Tag;

            string meer = ">";

            if (product.Categorie_id < 8)
            {
                meer = "<";
            }

            int Nieuwestatus = 2;
            int status = 1;

            if (product.Status == 1)
            {
                Nieuwestatus = 2;
                status = 1;
            }
            else
            {
                Nieuwestatus = 1;
                status = 2;
            }

            keukenDAO.BestellingKlaar(product.Tafel_nummer, Nieuwestatus, status, meer);

            Geschiedenis.Controls.Clear();
            BarNu.Controls.Clear();

            MaakAlleKnoppen(meer);

            ActiveForm.Refresh();
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

        private void opmerking_Click(object sender, EventArgs e)
        {

        }
    }
}