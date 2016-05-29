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
        public BarOverzicht()
        {
            InitializeComponent();
            //Bestellingen
            List<int> bestelling = new List<int>();

            int test = 1;
            int teller = 1;

            for (int i = 0; i < 10; i++)
            {
                bestelling.Add(test);
                test++;
            }

            int y = 0;
            int yToe = 40;
            int YLBL = 10;

            foreach (int item in bestelling)
            {
                Maakknoppen(ref teller, ref y, yToe, ref YLBL, item);

            }

            //BestellingenKlaar
            List<int> bestellingklaar = new List<int>();

            test = 1;
            teller = 1;

            for (int i = 0; i < 4; i++)
            {
                bestellingklaar.Add(test);
                test++;
            }

            y = 0;
            yToe = 40;
            YLBL = 10;

            foreach (int item in bestellingklaar)
            {
                KlaarKnoppen(ref teller, ref y, yToe, ref YLBL, item);
            }
        }

        private void KlaarKnoppen(ref int teller, ref int y, int yToe, ref int YLBL, int item)
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
            BestelKlaar_lbl.Text = "label1";

            Button NietKlaar_btn = new System.Windows.Forms.Button();
            NietKlaar_btn.BackColor = System.Drawing.Color.Red;
            NietKlaar_btn.Location = new System.Drawing.Point(798, y);
            NietKlaar_btn.Name = "nietKlaar_btn" + teller;
            NietKlaar_btn.Size = new System.Drawing.Size(78, 34);
            NietKlaar_btn.TabIndex = 32;
            NietKlaar_btn.Text = "Niet Klaar";
            NietKlaar_btn.UseVisualStyleBackColor = true;

            BestelKlaar_lbl.Text = item.ToString();

            if (teller % 2 == 0)
            {

                buttonKlaar.BackColor = System.Drawing.Color.DarkGray;
            }

            teller++;
            Geschiedenis.Controls.Add(BestelKlaar_lbl);
            Geschiedenis.Controls.Add(NietKlaar_btn);
            Geschiedenis.Controls.Add(buttonKlaar);
        }

        private void Maakknoppen(ref int teller, ref int y, int yToe, ref int YLBL, int item)
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
            Bestel_lbl.Text = "label1";

            Button Klaar_btn = new System.Windows.Forms.Button();
            Klaar_btn.Location = new System.Drawing.Point(798, y);
            Klaar_btn.Name = "Klaar_btn" + teller;
            Klaar_btn.Size = new System.Drawing.Size(78, 34);
            Klaar_btn.TabIndex = 32;
            Klaar_btn.Text = "Klaar";
            Klaar_btn.UseVisualStyleBackColor = true;
            Klaar_btn.Click += new EventHandler(handleClick);
            Klaar_btn.Tag = item;

            Bestel_lbl.Text = item.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
