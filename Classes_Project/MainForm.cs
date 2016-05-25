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

        //een lijst met de tabs die 'verstopt' zijn.
        private List<TabPage> hiddenPages = new List<TabPage>();

        //functie om een tab te tonen of te verstoppen
        private void EnablePage(TabPage page, bool enable)
        {
            if (enable)
            {
                tabControl.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tabControl.TabPages.Remove(page);
                hiddenPages.Add(page);
            }
        }

        //als het form gesloten word maken we de lijst ook leeg
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (var page in hiddenPages)
            {
                page.Dispose();
            }

            base.OnFormClosed(e);
        }


        public MainForm()
        {
            InitializeComponent();
        }

        //constructor die ook een medewerker wilt, deze krijgt hij via het inlogscherm
        public MainForm(Medewerker m)
        {
            InitializeComponent();

            TabControl.TabPageCollection tabs = tabControl.TabPages;
            foreach (TabPage tab in tabs)
            {
                EnablePage(tab, false);
            }

            ingelogdeMedewerker = m;

            //Kijk wat voor medewerker is ingelogd en zet de tabjes
            switch (m.Rol)
            {
                case MedewerkerRol.Bar:
                    EnablePage(tab_Bar, true);
                    break;
                case MedewerkerRol.Keuken:
                    EnablePage(tab_Keuken, true);
                    break;
                case MedewerkerRol.Manager:
                    EnablePage(tab_medewerkerOverzicht, true);
                    EnablePage(tab_TafelOverzicht, true);
                    EnablePage(tab_Keuken, true);
                    EnablePage(tab_Bar, true);
                    break;
                case MedewerkerRol.Bediening:
                    EnablePage(tab_TafelOverzicht, true);
                    break;
            }
            tabControl.TabPages.Remove(tab_Bestellen);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //tafel clicks.. 
        //dit moet nog afgemaakt worden.
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