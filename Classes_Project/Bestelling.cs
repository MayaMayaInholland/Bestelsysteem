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
        public int StatusInt { get; set; } // status als int naar de database
        public int Tafel_id { get; set; }
        public string Opmerking { get; set; }
        public int Fooi { get; set; }
        public int Totaalbedrag { get; set; }

        // Algemene constructor.
        public Bestelling( int tafel_id, int medewerker_id, DateTime tijd, int totaalbedrag, string opmerking, int status, int fooi, List<Product> besteld_producten)
        {
            this.Tafel_id = tafel_id;
            this.Medewerker_id = medewerker_id;
            this.Tijd = tijd;
            this.Totaalbedrag = totaalbedrag;
            this.Opmerking = opmerking;
            this.StatusInt = status;
            this.Fooi = fooi;
            this.Bestelde_producten = besteld_producten;
        }

        //BestellingDAO : Lopende_bestelling ophalen.
        public Bestelling(int id, int tafel_id, int medewerker_id, DateTime tijd, BestellingStatus status, string opmerking, List<Product> producten)
        {
            this.Id = id;
            this.Tafel_id = tafel_id;
            this.Medewerker_id = medewerker_id;
            this.Tijd = tijd;
            this.Status = status;
            this.Opmerking = opmerking;
            this.Bestelde_producten = producten;
        }

    }
}