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

        private Medewerker ingelogdemedewerker;
        private List<Product> besteldeProducten = new List<Product>();


        //constructor form
        public BedieningForm(Medewerker m)
        {
            InitializeComponent();
            tabB_volledig.SelectedTab = tabB_TafelOverzicht;

            ingelogdemedewerker = m;

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
            string omschrijving = listB_producten.SelectedItems[0].ToString();
            Product product = listB_producten.SelectedItem as Product;      

            CustomListViewItem item = new CustomListViewItem(product.Omschrijving, product.Id);
            besteldeProducten.Add(product);

            listview_producten.Items.Add(item);
        }

        //Medewerker kan terug naar tafeloverzicht ( als er niks besteld is, is er niks veranderd.) 
        private void btn_returnOverzicht_Click(object sender, EventArgs e) => tabB_volledig.SelectedTab = tabB_TafelOverzicht;

        //Tafel 1 wordt geopend.
        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Bestelling bestelling = Bestelling_bijTafel(1);
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

            if (tafel.Status == TafelStatus.VRIJ)
            {
                List<Product> nieuw_productLijst = new List<Product>();
                bestelling = new Bestelling(tafel, ingelogdemedewerker.Id, DateTime.Now, BestellingStatus.Open, nieuw_productLijst);
                return bestelling;
            }
            else if (tafel.Status == TafelStatus.BEZET)
            {
                bestelling = bestellingDAO.GetByTafelId(Tafelnr);
                return bestelling;
            }
            return null;
        }

        private void btn_Loguit_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }
    }
}
