using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    class BestellingDAO
    {
        private List<Bestelling> bestellingen;
        // dit is allemaal fake!!

        public BestellingDAO()
        {
            bestellingen = new List<Bestelling>();
            bestellingen.Add(new Bestelling(1, 1, 3, DateTime.Now));
            bestellingen.Add(new Bestelling(2, 1, 5, DateTime.Now));
            bestellingen.Add(new Bestelling(3, 1, 5, DateTime.Now));
            bestellingen.Add(new Bestelling(4, 2, 7, DateTime.Now));
            bestellingen.Add(new Bestelling(5, 2, 6, DateTime.Now));
            bestellingen.Add(new Bestelling(6, 2, 5, DateTime.Now));
        }

        public List<Bestelling> GetAll()
        {
            return bestellingen;
        }

        public List<Bestelling> GetAllForRekening(int Rekeningid)
        {
            List<Bestelling> selectie = new List<Bestelling>();
            foreach (Bestelling bestelling in bestellingen)
            {
                if (bestelling.RekeningId == Rekeningid)
                    selectie.Add(bestelling);
            }
            return selectie;
        }

        public void Create(Bestelling nieuweBestelling)
        {
            bestellingen.Add(nieuweBestelling);
        }

    }
}
