using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Bestelling
    {
        public int Id { get; set; }
        public Tafel Tafel { get; set; }
        public Medewerker Medewerker { get; set; }
        public int Tijd { get; set; }
        public int TotaalBedrag { get; set; }
        public string Opmerkingen { get; set; }
        public string Status { get; set; }
        public int Fooi { get; set; }

        public Bestelling( Tafel tafel, Medewerker medewerker, int tijd, string status)
        {
            this.Tafel = tafel;
            this.Medewerker = medewerker;
            this.Tijd = tijd;
            this.Status = status;
        }

    }
}