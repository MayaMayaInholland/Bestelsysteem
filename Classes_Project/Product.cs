using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Product
    {
        //veiligheid controleren ( properties correct toegepast ? )
        public int Id { get; set; }
        public int Categorie_id { get; set; }
        public int Prijs { get; set; }
        public int Btw { get; set; }
        public int Voorraad { get; set; }
        public string Omschrijving { get; set; }
        public int Aantal { get; set; }
        public string Opmerking { get; set; }
        public ProductStatus status { get; set; }


        public Product(int id, int categorie_id, int prijs, int voorraad, int btw, string omschrijving)
        {
            this.Btw = btw;
            this.Categorie_id = categorie_id;
            this.Id = id;
            this.Prijs = prijs;
            this.Voorraad = voorraad;
            this.Omschrijving = omschrijving;
        }

        public Product(int id, int categorie_id, int prijs, int voorraad, int btw, string omschrijving, ProductStatus status, string opmerking)
        {
            this.Btw = btw;
            this.Categorie_id = categorie_id;
            this.Id = id;
            this.Prijs = prijs;
            this.Voorraad = voorraad;
            this.Omschrijving = omschrijving;
            this.status = status;
        }

        public override string ToString()
        {
            return Omschrijving;
        }
    }
}