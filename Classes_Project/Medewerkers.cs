using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public abstract class Medewerker
    {     
         
        protected int Id;     
        protected int Pincode;
        protected string Naam { get; set; }
        protected string Achternaam { get; set; }

        public Medewerker( int id, int pincode, string naam, string achternaam )
        {
            this.Id = id;
            this.Pincode = pincode;
            this.Naam = naam;
            this.Achternaam = achternaam;
        }

    }
}