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

        public RekeningForm(Medewerker m)
        {
            InitializeComponent();

            ingelogdeMedewerker = m;
            lbl_IngelogdeMedewerker.Text = m.Voornaam;
            //init producten lijst

        }

        private void InitForm()
        {
            RekeningDAO rekeningdao = new RekeningDAO();
            rekening = rekeningdao.GetByTafelID(tafelID);
            lbl_Totaal.Text = rekening.Bereken_Totaal().ToString();
            foreach (Product product in rekening.Bestelling.Bestelde_producten)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Omschrijving);
                item.SubItems.Add(product.Prijs.ToString());
                item.SubItems.Add(product.Aantal.ToString());
            }
        }
    }
}
