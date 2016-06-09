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
        private Tafel tafel;

        public RekeningForm(Medewerker m, Tafel tafel)
        {
            InitializeComponent();
            this.tafel = tafel;
            ingelogdeMedewerker = m;
            lbl_IngelogdeMedewerker.Text = m.Voornaam;
            InitForm();
        }

        public void InitForm()
        {
            RekeningDAO rekeningdao = new RekeningDAO();
            rekening = rekeningdao.GetByTafelID(tafel.Id);
            Decimal totaalBedrag = 0;
            foreach (Product product in rekening.Bestelling.Bestelde_producten)
            {
                int totaalProduct = product.Prijs * product.Btw * product.Aantal;
                Decimal subTotaal = product.Prijs * product.Aantal;
                Decimal totaal = (subTotaal / 100) * (1 + (product.Btw / 100));
                totaal = Math.Round(totaal, 2);
                ListViewItem item = new ListViewItem(product.Omschrijving);
                item.SubItems.Add("€ " + ((double)product.Prijs / 100).ToString("0.00"));
                item.SubItems.Add(product.Btw.ToString() + "%");
                item.SubItems.Add(product.Aantal.ToString());
                item.SubItems.Add("€ " + totaal.ToString("0.00"));

                totaalBedrag += totaal;

                listR_ViewRekening.Items.Add(item);
            }
            lbl_Totaal.Text = "€ " + totaalBedrag.ToString("0.00");
        }

        private void btnR_Return_Click(object sender, EventArgs e)
        {
            BedieningForm bedieningform = new BedieningForm(ingelogdeMedewerker);
            bedieningform.Show();
            this.Hide();
        }

        private void btn_ContantBetalen_Click(object sender, EventArgs e)
        {
            SubmitBestelling();
        }

        private void btn_PinnenBetalen_Click(object sender, EventArgs e)
        {
            SubmitBestelling();

        }

        private void btn_CreditcardBetalen_Click(object sender, EventArgs e)
        {
            SubmitBestelling();

        }

        private void SubmitBestelling()
        {
            if (MessageBox.Show("Wilt u deze bestelling afronden ?", "Bestelling afronden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RekeningDAO dao = new RekeningDAO();
                int fooi = 0;
                int.TryParse(txt_Fooi.Text, out fooi);
                rekening.Bestelling.Fooi = fooi;
                rekening.Bestelling.Status = BestellingStatus.Betaald;
                rekening.Bestelling.Opmerking = txt_Opmerkingen.Text;
                rekening.Bestelling.Totaalbedrag = rekening.Bereken_Totaal();
                dao.RekeningBetaald(rekening);
                TafelDAO tDao = new TafelDAO();
                tDao.SetTafelStatus(tafel, TafelStatus.VRIJ);
            }
        }
    }
}

