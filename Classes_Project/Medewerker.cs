using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public abstract class Medewerker
    {

        public int Id
        {
            get; set;
        }

        public int Pincode { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public MedewerkerRol Rol {get;set;}

        public Medewerker(int id, int pincode, string naam, string achternaam, MedewerkerRol rol)
        {
            this.Id = id;
            this.Pincode = pincode;
            this.Voornaam = naam;
            this.Achternaam = achternaam;
        }

    }
}