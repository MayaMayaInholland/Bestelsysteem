using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Product
    {
        protected int Id;
        protected int Categorie_id;
        protected int Prijs;
        protected int Voorraad;
        protected int Btw;

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