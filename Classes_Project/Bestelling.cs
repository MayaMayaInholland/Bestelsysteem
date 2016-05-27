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
        public int Medewerker_id { get; set; }
        public DateTime Tijd { get; set; }
        public List<Product> Bestelde_producten { get; set; }     
        public BestellingStatus Status { get; set; }
        public int Tafel_id { get; set; }
        public string opmerking { get; set; }


        public Bestelling( Tafel tafel, int medewerker, DateTime tijd, BestellingStatus status, List<Product> producten)
        {
            this.Bestelde_producten = producten;
            this.Tafel = tafel;
            this.Medewerker_id = medewerker;
            this.Tijd = tijd;
            this.Status = status;          
        }

        public Bestelling( List<Product> bestellingen, int medewerker_id, BestellingStatus status, DateTime tijd, string opmerking)
        {
            this.Medewerker_id = Medewerker_id;
            this.Bestelde_producten = bestellingen;
            this.Status = status;
            this.Tijd = tijd;
            this.opmerking = opmerking;
        }

        public void verwijderProducten()
        {
            Bestelde_producten.Clear();
        }

    }
}