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
        public BarOverzicht(Medewerker m)
        {
            InitializeComponent();



            lbl_IngelogdeMedewerker.Text = m.Voornaam;



            MaakAlleKnoppen();



        }

        private void MaakAlleKnoppen()
        {
            int teller = 1;

            int y = 0;
            int yToe = 40;
            int YLBL = 0;
            int NieuweTafel = 0;
            int Nieuwekleur = 1;

            List<Besteld_product> lijst_NietActiveroducten = new List<Besteld_product>();

            BarDAO keukenDAO2 = new BarDAO();
            lijst_NietActiveroducten = keukenDAO2.GetKLAARBesteldeProducten();

            y = 0;
            yToe = 40;
            YLBL = 10;
            Nieuwekleur = 1;

            foreach (Besteld_product p in lijst_NietActiveroducten)
            {
                KlaarKnoppen(ref Nieuwekleur, ref NieuweTafel, ref teller, ref y, yToe, ref YLBL, p);
            }


            teller = 1;
            y = 0;
            yToe = 40;
            YLBL = 10;
            NieuweTafel = 0;
            Nieuwekleur = 1;

            List<Besteld_product> Lijst_ActiveProducten = new List<Besteld_product>();

            BarDAO keukenDAO = new BarDAO();
            Lijst_ActiveProducten = keukenDAO.GetActiveBesteldeProducten();

            foreach (Besteld_product p in Lijst_ActiveProducten)
            {
                Maakknoppen(ref Nieuwekleur, ref NieuweTafel, ref teller, ref y, yToe, ref YLBL, p);
            }
        }


        private void KlaarKnoppen(ref int Nieuwekleur, ref int NieuweTafel, ref int teller, ref int y, int yToe, ref int YLBL, Besteld_product p)
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
                Geschiedenis.Controls.Add(Tafelnummer_lbl);
                Tafelnummer_lbl.BackColor = System.Drawing.Color.Gainsboro;

                Button Tafel_btn = new System.Windows.Forms.Button();
                Tafel_btn.Location = new System.Drawing.Point(70, y);
                Tafel_btn.Name = "button" + teller;
                Tafel_btn.Size = new System.Drawing.Size(40, 34);
                Tafel_btn.TabIndex = 101;
                Tafel_btn.UseVisualStyleBackColor = true;
                Geschiedenis.Controls.Add(Tafel_btn);
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
                Geschiedenis.Controls.Add(NietKlaar_btn);

                if (Nieuwekleur % 2 == 0)
                {
                    NietKlaar_btn.BackColor = System.Drawing.Color.DarkGray;
                    Tafel_btn.BackColor = System.Drawing.Color.DarkGray;
                    //opmerking.BackColor = System.Drawing.Color.Silver;
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
            Geschiedenis.Controls.Add(BestelKlaar_lbl);

            if (p.Opmerking != " ")
            {


                Geschiedenis.Controls.Add(Opmerking_lbl);
            }


            Geschiedenis.Controls.Add(buttonKlaar);
        }


        /////////////////////////////////////////////////////////////////////////////////// Afscheiding

        private void Maakknoppen(ref int Nieuwekleur, ref int NieuweTafel, ref int teller, ref int y, int yToe, ref int YLBL, Besteld_product p)
        {
            y += yToe;
            Button button = new System.Windows.Forms.Button();
            button.Location = new System.Drawing.Point(47 + 70, y);
            button.Name = "button" + teller;
            button.Size = new System.Drawing.Size(645 + 30, 34);
            button.TabIndex = 101;
            button.UseVisualStyleBackColor = true;

            Label Bestel_lbl = new System.Windows.Forms.Label();
            Bestel_lbl.AutoSize = true;
            Bestel_lbl.Location = new System.Drawing.Point(90 + 65, YLBL += yToe);
            Bestel_lbl.Name = "Bestel_lbl" + teller;
            Bestel_lbl.Size = new System.Drawing.Size(35, 13);
            Bestel_lbl.TabIndex = 22;
            Bestel_lbl.Text = p.Omschrijving.ToString();
            Bestel_lbl.BackColor = System.Drawing.Color.Gainsboro;

            Label Opmerking_lbl = new System.Windows.Forms.Label();
            Opmerking_lbl.AutoSize = true;
            Opmerking_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Opmerking_lbl.Location = new System.Drawing.Point(90 + 100, YLBL + 10);
            Opmerking_lbl.ForeColor = System.Drawing.Color.Red;
            Opmerking_lbl.Name = "Opmerking_lbl" + teller;
            Opmerking_lbl.Size = new System.Drawing.Size(35, 13);
            Opmerking_lbl.TabIndex = 22;
            Opmerking_lbl.Text = p.Opmerking.ToString();
            Opmerking_lbl.BackColor = System.Drawing.Color.Gainsboro;

            if (NieuweTafel != p.Tafel_nummer)
            {
                Label Tafelnummer_lbl = new System.Windows.Forms.Label();
                Tafelnummer_lbl.AutoSize = true;
                Tafelnummer_lbl.Location = new System.Drawing.Point(85, y + 10);
                Tafelnummer_lbl.Name = "Bestel_lbl" + teller;
                Tafelnummer_lbl.Size = new System.Drawing.Size(40, 34);
                Tafelnummer_lbl.TabIndex = 22;
                Tafelnummer_lbl.Text = p.Tafel_nummer.ToString();
                Tafelnummer_lbl.BackColor = System.Drawing.Color.Gainsboro;
                BarNu.Controls.Add(Tafelnummer_lbl);

                Button Tafel_btn = new System.Windows.Forms.Button();
                Tafel_btn.Location = new System.Drawing.Point(70, y);
                Tafel_btn.Name = "button" + teller;
                Tafel_btn.Size = new System.Drawing.Size(40, 34);
                Tafel_btn.TabIndex = 101;
                Tafel_btn.UseVisualStyleBackColor = true;
                BarNu.Controls.Add(Tafel_btn);


                Button Klaar_btn = new System.Windows.Forms.Button();
                Klaar_btn.Location = new System.Drawing.Point(798, y);
                Klaar_btn.Name = "Klaar_btn" + teller;
                Klaar_btn.Size = new System.Drawing.Size(78, 34);
                Klaar_btn.TabIndex = 32;
                Klaar_btn.Text = "Klaar";
                Klaar_btn.UseVisualStyleBackColor = true;
                Klaar_btn.Click += new EventHandler(KlaarClick);
                Klaar_btn.Tag = p;
                BarNu.Controls.Add(Klaar_btn);

                if (Nieuwekleur % 2 == 0)
                {
                    Klaar_btn.BackColor = System.Drawing.Color.DarkGray;
                    Tafel_btn.BackColor = System.Drawing.Color.DarkGray;
                    Tafelnummer_lbl.BackColor = System.Drawing.Color.DarkGray;
                    Opmerking_lbl.BackColor = System.Drawing.Color.DarkGray;
                }

                Nieuwekleur++;
            }



            NieuweTafel = p.Tafel_nummer;




            if (Nieuwekleur % 2 != 0)
            {
                Bestel_lbl.BackColor = System.Drawing.Color.DarkGray;
                button.BackColor = System.Drawing.Color.DarkGray;
            }




            teller++;


            BarNu.Controls.Add(Bestel_lbl);

            if (p.Opmerking != " ")
            {


                BarNu.Controls.Add(Opmerking_lbl);
            }


            BarNu.Controls.Add(button);



        }

        private void KlaarClick(object sender, EventArgs e)
        {
            BarDAO keukenDAO = new BarDAO();
            Button button = (Button)sender;
            Besteld_product product = (Besteld_product)button.Tag;
            keukenDAO.KeukenBestellingKlaar(product.Tafel_nummer);

            BarNu.Controls.Clear();
            Geschiedenis.Controls.Clear();

            MaakAlleKnoppen();

            ActiveForm.Refresh();
        }

        private void NietKlaarClick(object sender, EventArgs e)
        {
            BarDAO keukenDAO = new BarDAO();
            Button button = (Button)sender;
            Besteld_product product = (Besteld_product)button.Tag;
            keukenDAO.KeukenBestellingNIETKlaar(product.Tafel_nummer);

            Geschiedenis.Controls.Clear();
            BarNu.Controls.Clear();

            MaakAlleKnoppen();

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