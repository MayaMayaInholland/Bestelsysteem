using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    class TafelDAO
    {
        private List<Tafel> tafels;
        // faked

        public TafelDAO()
        {
            tafels = new List<Tafel>();
            tafels.Add(new Tafel(1, TafelStatus.VRIJ));
            tafels.Add(new Tafel(2, TafelStatus.BEZET));
            tafels.Add(new Tafel(3, TafelStatus.VRIJ));
            tafels.Add(new Tafel(4, TafelStatus.VRIJ));
            tafels.Add(new Tafel(5, TafelStatus.VRIJ));
            tafels.Add(new Tafel(6, TafelStatus.VRIJ));
            tafels.Add(new Tafel(7, TafelStatus.VRIJ));
            tafels.Add(new Tafel(8, TafelStatus.VRIJ));
        }

        public List<Tafel> GetAll()
        {
            return tafels;
        }

        public Tafel GetForId(int id)
        {
            Tafel select = tafels[1];
            foreach (Tafel tafel in tafels)
            {
                if (tafel.Nummer == id)
                    select = tafel ;
            }

            return select;
        }
    }
}
