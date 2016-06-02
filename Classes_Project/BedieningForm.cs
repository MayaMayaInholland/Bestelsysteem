﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes_Project.Properties;
using System.Text.RegularExpressions;

namespace Classes_Project
{
    public partial class BedieningForm : Form
    {
        BestellingDAO bestellingDAO = new BestellingDAO();
        private Medewerker ingelogdemedewerker;
        private Bestelling bestelling;
        private List<Product> besteldeProducten = new List<Product>();
        private List<Tafel> tafels;

        //constructor form
        public BedieningForm(Medewerker m)
        {
            InitializeComponent();
            tabB_volledig.SelectedTab = tabB_TafelOverzicht;

            ingelogdemedewerker = m;
            lbl_IngelogdeMedewerker.Text = m.Voornaam;
            TafelDAO tafelDao = new TafelDAO();
            tafels = tafelDao.GetAllTafels();
            SetTafelImages();
        }

        private void SetTafelImages()
        {
            for (int i = 1; i <= tafels.Count; i++)
            {
                Control.ControlCollection controls2 = tabB_TafelOverzicht.Controls;
                foreach (Control c in tabB_TafelOverzicht.Controls)
                {
                    if ((string)c.Tag == string.Format("tafel{0}", i))
                    {
                        Tafel huidigeTafel = tafels.Where(t => t.Nummer == i).FirstOrDefault();
                        if (huidigeTafel.Status == TafelStatus.VRIJ)
                        {
                            Image img = (Image)Resources.ResourceManager.GetObject("TafelVrij");
                            c.Text = i + "\n VRIJ";
                            c.BackgroundImage = img;
                        }
                        else if (huidigeTafel.Status == TafelStatus.BEZET)
                        {
                            BestellingDAO bDAO = new BestellingDAO();
                            ProductDAO pDAO = new ProductDAO();
                            Bestelling bestelling = bDAO.GetByTafelId(huidigeTafel.Id);
                            List<Product> gereedGemeldeProducten = new List<Product>();
                            Image img;
                            string text = "";
                            if (bestelling != null)
                            {
                                gereedGemeldeProducten = pDAO.GetGereedGemeldeProductenVoorBestelling(bestelling.Id);
                                if (gereedGemeldeProducten.Count > 0)
                                {
                                    img = (Image)Resources.ResourceManager.GetObject("Tafel");
                                    text = i + "\n BESTELLING \n GEREED";
                                }
                                else
                                {
                                    img = (Image)Resources.ResourceManager.GetObject("TafelBezet");
                                    text = i + "\n BEZET";
                                }
                            }
                            else
                            {
                                img = (Image)Resources.ResourceManager.GetObject("TafelBezet");
                                text = i + "\n BEZET";

                            }
                            c.Text = text;
                            c.BackgroundImage = img;
                        }
                    }



                }
            }
        }

        //tellen aantal van product??
        public void tel_AantalProducten(Bestelling bestelling)
        {
            for (int i = 0; i < bestelling.Bestelde_producten.Count(); i++)
            {
                for (int j = 0; j < bestelling.Bestelde_producten.Count(); i++)
                {
                    if (bestelling.Bestelde_producten[i].Id == bestelling.Bestelde_producten[j].Id)
                    {
                        bestelling.Bestelde_producten[i].Aantal++;
                    }

                }
            }
        }


        //Er moet een methode hiervan gemaakt kunnen worden, alleen de categorie_id vershilt per click.
        //tonen van alle lunch opties op listview
        private void lunchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<Product> producten = new List<Product>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 1 || product.Categorie_id == 2 || product.Categorie_id == 3)
                {
                    producten.Add(product);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }

        //tonen van alle dinner opties op listview
        private void dinnerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<Product> producten = new List<Product>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 4 || product.Categorie_id == 5 || product.Categorie_id == 6 || product.Categorie_id == 7)
                {
                    producten.Add(product);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }

        // tonen van alle dranken op Listview
        private void drankToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<Product> producten = new List<Product>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 8 || product.Categorie_id == 9 || product.Categorie_id == 10 || product.Categorie_id == 11 || product.Categorie_id == 12)
                {
                    producten.Add(product);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }


        //verwijderen product uit listview ( nog zonder aantal.... )
        private void listview_producten_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (CustomListViewItem eachItem in listview_producten.SelectedItems)
            {
                listview_producten.Items.Remove(eachItem);
                besteldeProducten.Remove(besteldeProducten.Where((p => p.Id == eachItem.id)).FirstOrDefault());
            }
        }

        // Hierbij wordt de geselecteerde producten overgezet naar de listview
        private void listB_producten_SelectedIndexChanged(object sender, EventArgs e)
        {

            Product product = listB_producten.SelectedItem as Product;
            if (product.Aantal == 0)
            {
                product.Aantal = 1;
            }
            besteldeProducten.Add(product);
            showBesteldeProducten();
        }

        private void showBesteldeProducten()
        {
            string omschrijving = listB_producten.SelectedItems[0].ToString();

            for (int i = 0; i < besteldeProducten.Count; i++)
            {
                for (int j = 0; j < besteldeProducten.Count; j++)
                {
                    if (besteldeProducten[i].Id == besteldeProducten[j].Id)
                    {
                        if (i != j)
                        {
                            besteldeProducten[i].Aantal += 1;
                            besteldeProducten.Remove(besteldeProducten[j]);
                        }
                    }
                }
            }

            foreach (ListViewItem item in listview_producten.Items)
            {
                item.Remove();
            }
            foreach (Product productInList in besteldeProducten)
            {
                productInList.Omschrijving = Regex.Replace(productInList.Omschrijving, @"[\d-]", string.Empty);
                productInList.Omschrijving += productInList.Aantal.ToString();
                CustomListViewItem item = new CustomListViewItem(productInList.Omschrijving, productInList.Id, productInList.Categorie_id, productInList.Prijs, productInList.Voorraad, productInList.Btw, productInList.Aantal);
                listview_producten.Items.Add(item);
            }
        }

        //Medewerker kan terug naar tafeloverzicht ( als er niks besteld is, is er niks veranderd.) 
        private void btn_returnOverzicht_Click(object sender, EventArgs e) => tabB_volledig.SelectedTab = tabB_TafelOverzicht;

        //Tafel 1 wordt geopend.
        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            bestelling = Bestelling_bijTafel(1);
            tafelClick(1);
        }

        public void tafelClick(int tafelnr)
        {
            tabB_volledig.SelectedTab = tabB_Bestellen1;
        }

        //Het terug halen van de bijhorende bestelling.
        public Bestelling Bestelling_bijTafel(int Tafelnr)
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            TafelDAO tafelDAO = new TafelDAO();
            Tafel tafel = tafelDAO.GetByTafelNummer(Tafelnr);
            Bestelling bestelling;
            tafel.Status = TafelStatus.VRIJ;

            if (tafel.Status == TafelStatus.VRIJ)
            {
                bestelling = new Bestelling(Tafelnr, ingelogdemedewerker.Id, DateTime.Now, 1, " ", 1, 0);
                return bestelling;
            }
            else if (tafel.Status == TafelStatus.BEZET)
            {
                bestelling = bestellingDAO.GetByTafelId(Tafelnr);
                return bestelling;
            }
            return null;
        }

        //Maak nieuwe bestelling aan.
        private void btn_bevestig_Bestelling_Click(object sender, EventArgs e)
        {

            bestelling.Tafel_id = 2;
            bestelling.Medewerker_id = ingelogdemedewerker.Id;
            bestelling.opmerking = " ";
            bestelling.Status = 1;
            bestelling.Tijd = DateTime.Now;
            bestelling.Totaalbedrag = 0;
            bestelling.fooi = 0;
            bestelling.Bestelde_producten = besteldeProducten;

            bestellingDAO.Nieuwe_bestelling(bestelling);
        }

        //loguit button
        private void btn_Loguit_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }


        private void btn_Tafel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_Tafel2_MouseEnter(object sender, EventArgs e)
        {
            // ShowTooltip(sender, 2);

        }

        private void ShowTooltip(object sender, int tafelNummer)
        {
            BestellingDAO bDAO = new BestellingDAO();
            Tafel huidigeTafel = tafels.Where(ht => ht.Nummer == tafelNummer).FirstOrDefault();
            Bestelling bestelling = bDAO.GetLopendeBestellingByTafelID(huidigeTafel.Id);
            ToolTip t = new ToolTip();

            if (bestelling != null)
            {
                StringBuilder sb = new StringBuilder();
                List<Product> producten = bestelling.Bestelde_producten;
                if (producten != null)
                {
                    sb.AppendLine("Bestellingnummer: " + bestelling.Id);
                    sb.AppendLine("Tijd: " + bestelling.Tijd.ToShortTimeString());
                    sb.AppendLine("Bestelde producten:");
                    foreach (Product p in producten)
                    {
                        sb.AppendLine(p.Omschrijving);
                    }
                }
                else
                {
                    if (producten.Count < 1)
                    {
                        //sb.AppendLine("Er is geen lopende bestelling bij deze tafel");
                    }
                }
                t.Show(sb.ToString(), (Button)sender);
            }
            else
            {
                t.Show("Er is geen lopende bestelling bij deze tafel", (Button)sender);
            }

        }

        private void btn_Tafel2_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 2);
        }

        private void btn_Tafel1_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 1);
        }

        private void btn_Tafel3_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 3);
        }

        private void btn_Tafel4_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 4);
        }

        private void btn_Tafel5_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 5);
        }

        private void btn_Tafel6_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 6);
        }

        private void btn_Tafel7_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 7);
        }

        private void btn_Tafel8_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 8);
        }

        private void btn_Tafel9_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 9);
        }

        private void btn_Tafel10_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, 10);
        }

    }
}
