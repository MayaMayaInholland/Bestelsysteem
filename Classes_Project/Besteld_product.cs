using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    class Besteld_product
    {
        //veiligheid controleren ( properties correct toegepast ? )
        public int Id { get; set; }
        public int Bestelling_id { get; set; }
        public int Product_id { get; set; }
        public int Status { get; set; }
        public int Aantal { get; set; }
        public string Opmerking { get; set; }
        public string Omschrijving { get; set; }
        public int Categorie_id { get; set; }
        public int Tafel_nummer { get; set; }


        public Besteld_product(int id, int Bestelling_id, int Product_id, int Status, int Aantal, string Opmerking, int Categorie_id, string Omschrijving, int Tafel_nummer)
        {
            this.Id = id;
            this.Bestelling_id = Bestelling_id;
            this.Product_id = Product_id;
            this.Status = Status;
            this.Aantal = Aantal;
            this.Opmerking = Opmerking;
            this.Omschrijving = Omschrijving;
            this.Categorie_id = Categorie_id;
            this.Tafel_nummer = Tafel_nummer;
        }
    }
}
