using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Menu
    {
        public string Naam { get; set; }
        public string Categorie_id { get; set; }

        public Menu(string naam, string categorie_id)
        {
            this.Naam = naam;
            this.Categorie_id = categorie_id;
        }
    }
}