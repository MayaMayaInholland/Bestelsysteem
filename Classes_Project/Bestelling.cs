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
        public DateTime Tijd { get; set; }
        public List<Besteld_product> Bestelde_producten { get; set; }
        public BestellingStatus Status { get; set; }


        public Bestelling( Tafel tafel, Medewerker medewerker, DateTime tijd, BestellingStatus status, List<Besteld_product> bestelde_producten)
        {
            this.Bestelde_producten = bestelde_producten;
            this.Tafel = tafel;
            this.Medewerker = medewerker;
            this.Tijd = tijd;
            this.Status = status;          
        }



    }
}