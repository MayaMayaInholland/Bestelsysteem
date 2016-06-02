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
        public int Totaalbedrag { get; set; }
        public int Status { get; set; }
        public int Tafel_id { get; set; }
        public string opmerking { get; set; }
        public int fooi { get; set; }
        public BestellingStatus status { get; set; }


        public Bestelling( Tafel tafel, int medewerker, DateTime tijd, BestellingStatus status, List<Product> producten)
        {
            this.Bestelde_producten = producten;
            this.Tafel = tafel;
            this.Medewerker_id = medewerker;
            this.Tijd = tijd;
            this.status = status;          
        }

        public Bestelling(int id, int medewerker, DateTime tijd, int status, List<Product> producten, string opmerkingen)
        {
            this.opmerking = opmerkingen;
            this.Id = id;
            this.Bestelde_producten = producten;
            this.Medewerker_id = medewerker;
            this.Tijd = tijd;
            this.Status = status;
        }

        public Bestelling( List<Product> bestellingen, int medewerker_id, int status, DateTime tijd, string opmerking)
        {
            this.Medewerker_id = Medewerker_id;
            this.Bestelde_producten = bestellingen;
            this.Status = status;
            this.Tijd = tijd;
            this.opmerking = opmerking;
        }

        //Aanmaken van een bestelling dat bast in de database.
        public Bestelling(int tafel_id, int medewerker_id, DateTime tijd, int totaalbedrag, string opmerkingen, int status, int fooi)
        {
            this.Tafel_id = tafel_id;
            this.Medewerker_id = medewerker_id;
            this.Tijd = tijd;
            this.Totaalbedrag = totaalbedrag;
            this.opmerking = opmerking;
            this.Status = status;
            this.fooi = fooi;
        }

        public void verwijderProducten()
        {
            Bestelde_producten.Clear();
        }

    }
}