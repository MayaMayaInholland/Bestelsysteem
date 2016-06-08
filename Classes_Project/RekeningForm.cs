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
    public partial class RekeningForm : Form
    {
        private Medewerker ingelogdeMedewerker;
        private Rekening rekening;
        private List<Product> besteldeProducten = new List<Product>();
        private int tafelID;

        public RekeningForm(Medewerker m, int tafelid)
        {
            InitializeComponent();
            tafelID = tafelid;
            ingelogdeMedewerker = m;
            lbl_IngelogdeMedewerker.Text = m.Voornaam;
            InitForm();
        }

        public void InitForm()
        {
            RekeningDAO rekeningdao = new RekeningDAO();
            rekening = rekeningdao.GetByTafelID(tafelID);
            int totaalBedrag = 0;
            foreach (Product product in rekening.Bestelling.Bestelde_producten)
            {
                int totaalProduct = product.Prijs * product.Btw * product.Aantal;
                ListViewItem item = new ListViewItem(product.Omschrijving);
                item.SubItems.Add(product.Prijs.ToString());
                item.SubItems.Add(product.Btw.ToString());
                item.SubItems.Add(product.Aantal.ToString());
                item.SubItems.Add(totaalProduct.ToString());

                totaalBedrag += totaalProduct;

                listR_ViewRekening.Items.Add(item);
            }
            lbl_Totaal.Text = totaalBedrag.ToString();
        }

        private void btnR_Return_Click(object sender, EventArgs e)
        {
            BedieningForm bedieningform = new BedieningForm(ingelogdeMedewerker);
            bedieningform.Show();
            this.Hide();
        }
    }
}
