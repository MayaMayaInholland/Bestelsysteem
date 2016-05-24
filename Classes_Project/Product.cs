using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Product
    {
        private int Id;
        public int Categorie_id { get; set; }
        public int Prijs { get; set; }
        public int Voorraad { get; set; }
        public int Btw { get; set; }

        public Product(int id, int categorie_id, int prijs, int voorraad, int btw)
        {
            this.Btw = btw;
            this.Categorie_id = categorie_id;
            this.Id = id;
            this.Prijs = prijs;
            this.Voorraad = voorraad;
        }

    }
}