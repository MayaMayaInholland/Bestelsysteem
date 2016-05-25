using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Rekening
    {
        public int Id { get; set; }
        public int TotaalBedrag { get; set; }
        public string Betaalwijze { get; set; }
        public int Fooi { get; set; }
        public Tafel Tafel { get; set; }
        public Medewerker Medewerker { get; set; }

        public Rekening(int totaalBedrag, string betaalwijze)
        {
            this.TotaalBedrag = totaalBedrag;
            this.Betaalwijze = betaalwijze;
        }
    }
}