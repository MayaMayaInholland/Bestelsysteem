using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Bediening : Medewerker
    {       
        List<Tafel> tafels;

        public Bediening(int id, int pincode, string naam, string achternaam, MedewerkerRol rol) : base(id, pincode, naam, achternaam, rol)
        {
            tafels = new List<Tafel>();
        }
    }
}