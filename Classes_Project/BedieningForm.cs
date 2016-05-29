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
    public partial class BedieningForm : Form
    {
      

        //constructor form
        public BedieningForm(Medewerker m)
        {
            InitializeComponent();
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

        public void Bestelling_bijTafel(int Tafelnr, Medewerker m)
        {
            //aanmaken bestellingDAO;
            BestellingDAO bestellingDAO = new BestellingDAO();

            //aanmaken tafelDAO 
            TafelDAO tafelDAO = new TafelDAO();

            //Verkrijgen tafel obj 
            Tafel tafel = tafelDAO.GetByTafelNummer(Tafelnr);

            if (tafel.Status == TafelStatus.VRIJ)
            {
                List<Product> besteld_productLijst = new List<Product>();
                Bestelling bestelling = new Bestelling(tafel, m.Id , DateTime.Now, BestellingStatus.Open, besteld_productLijst);
            }
            else if (tafel.Status == TafelStatus.BEZET)
            {
                bestellingDAO.GetByTafelId(Tafelnr);
            }
            tabB_volledig.SelectedTab = tabB_Bestellen1;
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
