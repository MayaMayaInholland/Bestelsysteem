using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Project
{
    class CustomListViewItem : ListViewItem
    {
        public int id { get; set; }
        public int categorie_id { get; set; }
        public int prijs { get; set; }
        public int voorraad { get; set; }
        public int btw { get; set; }

        public CustomListViewItem(string omschrijving, int id, int categorie_id, int prijs, int voorraad, int btw) : base(omschrijving)
        {
            this.id = id;
            this.categorie_id = categorie_id;
            this.prijs = prijs;
            this.voorraad = voorraad;
            this.btw = btw;
        }

    }
}