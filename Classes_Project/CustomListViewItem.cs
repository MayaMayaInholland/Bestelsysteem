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
        public int Id { get; set; }
        public string Omschrijving { get; set; }
        public int Categorie_id { get; set; }
        public int Prijs { get; set; }
        public int Voorraad { get; set; }
        public int Btw { get; set; }

        public CustomListViewItem(string omschrijving, int id) : base(omschrijving)
        {
            this.Id = id;
        }

    }
}