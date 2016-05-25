﻿using System;
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
    public partial class MainForm : Form
    {
        private Medewerker ingelogdeMedewerker;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Medewerker m)
        {
            InitializeComponent();

            ingelogdeMedewerker = m;
            // bepalen welke tabs de medewerker krijgt te zien.
            switch (m.Rol)
            {
                case MedewerkerRol.Bar:
                    tabControl.TabPages.Remove(tab_TafelOverzicht);
                    tabControl.TabPages.Remove(tab_Bestellen);
                    tabControl.TabPages.Remove(tab_Keuken);
                    tabControl.TabPages.Remove(tab_medewerkerOverzicht);
                    tabControl.TabPages.Remove(tab_Rekening);
                    break;
                case MedewerkerRol.Keuken:
                    tabControl.TabPages.Remove(tab_TafelOverzicht);
                    tabControl.TabPages.Remove(tab_Bestellen);
                    tabControl.TabPages.Remove(tab_Bar);
                    tabControl.TabPages.Remove(tab_medewerkerOverzicht);
                    tabControl.TabPages.Remove(tab_Rekening);
                    break;
                case MedewerkerRol.Manager:
                    break;
                case MedewerkerRol.Bediening:
                    tabControl.TabPages.Remove(tab_Bar);
                    tabControl.TabPages.Remove(tab_Keuken);
                    tabControl.TabPages.Remove(tab_medewerkerOverzicht);
                    tabControl.TabPages.Remove(tab_Rekening);
                    break;
            }      
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            TafelDAO tafelDAO = new TafelDAO();
            Tafel tafel = tafelDAO.GetByTafelNummer(1);
            if (tafel.Status == TafelStatus.VRIJ)
            {
                Bestelling bestelling = new Bestelling(tafel, ingelogdeMedewerker, DateTime.Now, BestellingStatus.Gereed);
            }
            else if (tafel.Status == TafelStatus.BEZET)
            {

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
