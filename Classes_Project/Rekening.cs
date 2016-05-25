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

        public Rekening(int id, Tafel tafel, Medewerker medewerker)
        {
            this.Id = id;
            this.Tafel = tafel;
            this.Medewerker = medewerker;
        }
    }
}