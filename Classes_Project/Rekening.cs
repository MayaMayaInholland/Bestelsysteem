using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Rekening
    {
        public int TotaalBedrag { get; set; } //incl. fooi
        public string Betaalwijze { get; set; }
        public int Fooi { get; set; }
        public Bestelling Bestelling { get; set; }
        public string Opmerkingen { get; set; }

        public Rekening(Bestelling bestelling)
        {
            this.Bestelling = bestelling;
        }

        public int Bereken_Totaal()
        {
            int totaal = 0;

            for (int i = 0; i < Bestelling.Bestelde_producten.Count(); i++)
            {
                totaal = totaal + Bestelling.Bestelde_producten[i].Prijs;
            }

            return totaal;
        }

    }
}