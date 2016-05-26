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
        public KeukenOverzicht()
        {
            InitializeComponent();

            List<int> bestelling = new List<int>();

            int  test = 1;
            int teller = 0;


            for (int i = 0; i < 1; i++)
            {
                bestelling.Add(test);
            }

            int y = 41;
            int yToe = 40;

            foreach (int item in bestelling)
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
                Bestel_lbl.Location = new System.Drawing.Point(90, 51 + yToe);
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

                if (teller % 2 == 0)
                {
                    Klaar_btn.BackColor = System.Drawing.Color.DarkGray;
                    button.BackColor = System.Drawing.Color.DarkGray;
                }

                teller++;
                BarNu.Controls.Add(button);
                BarNu.Controls.Add(Bestel_lbl);
                BarNu.Controls.Add(Klaar_btn);
            }


        }
    }
}
