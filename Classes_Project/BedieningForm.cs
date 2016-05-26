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

        public BedieningForm()
        {
            InitializeComponent();
        }

        private void cmb_MenuCategorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
