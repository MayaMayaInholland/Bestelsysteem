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

        public CustomListViewItem(string omschrijving, int id) : base(omschrijving)
        {
            this.id = id;
        }

    }
}
