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

        //een lijst met de tabs die 'verstopt' zijn.
        private List<TabPage> hiddenPages = new List<TabPage>();

        //functie om een tab te tonen of te verstoppen
        private void EnablePage(TabPage page, bool enable)
        {
            if (enable)
            {
                tab_BestellingSelecteren.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tab_BestellingSelecteren.TabPages.Remove(page);
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

        private void cmb_MenuCategorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
