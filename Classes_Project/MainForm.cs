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
                    EnablePage(tab_Bestellen, true);
                    break;
                case MedewerkerRol.Bediening:
                    EnablePage(tab_TafelOverzicht, true);
                    EnablePage(tab_Bestellen, true);
                    break;
            }
        }


        //tafel clicks.. 
        //dit moet nog afgemaakt worden.
        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Bestelling_bijTafel(1);
        }


        //Geeft lunch, avond maaltijd weer
        private void cmb_menuCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Bestelling_bijTafel(int Tafelnr)
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            TafelDAO tafelDAO = new TafelDAO();
            Tafel tafel = tafelDAO.GetByTafelNummer(Tafelnr);

            if (tafel.Status == TafelStatus.VRIJ)
            {
                List<Product> besteld_productLijst = new List<Product>();
                Bestelling bestelling = new Bestelling(tafel, ingelogdeMedewerker.Id, DateTime.Now, BestellingStatus.Open, besteld_productLijst);
            }
            else if (tafel.Status == TafelStatus.BEZET)
            {
                bestellingDAO.GetByTafelId(Tafelnr);
            }
            tabControl.SelectedTab = tab_Bestellen;
        }


        //Er moet een methode hiervan gemaakt kunnen worden, alleen de categorie_id vershilt per click.
        //tonen van alle lunch opties op listview
        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<string> producten = new List<string>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 1 || product.Categorie_id == 2 || product.Categorie_id == 3)
                {
                    producten.Add(product.Omschrijving);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }

        //tonen van alle dinner opties op listview
        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<string> producten = new List<string>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 4 || product.Categorie_id == 5 || product.Categorie_id == 6 || product.Categorie_id == 7)
                {
                    producten.Add(product.Omschrijving);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }

        // tonen van alle dranken op Listview
        private void drankToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            ProductDAO productDAO = new ProductDAO();
            List<Product> lijst_producten = new List<Product>(productDAO.GetProducten());
            List<string> producten = new List<string>();

            foreach (Product product in lijst_producten)
            {
                if (product.Categorie_id == 8 || product.Categorie_id == 9 || product.Categorie_id == 10 || product.Categorie_id == 11 || product.Categorie_id == 12)
                {
                    producten.Add(product.Omschrijving);
                }
            }
            listB_producten.SelectedIndexChanged -= listB_producten_SelectedIndexChanged;
            listB_producten.DataSource = producten;
            listB_producten.SelectedIndex = -1;
            listB_producten.SelectedIndexChanged += listB_producten_SelectedIndexChanged;
        }

        //doorgeven van geslecteerde producten naar listview....
        private void listB_producten_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string omschrijving = listB_producten.SelectedItems[0].ToString();

            // hoe het aantal aan te passen...
           
            ListViewItem item = new ListViewItem(omschrijving);
            listview_producten.Items.Add(item);
        }

        //verwijderen product uit listview ( nog zonder aantal.... )
        private void listview_producten_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listview_producten.SelectedItems)
            {
                listview_producten.Items.Remove(eachItem);
            }
        }
    }
}
