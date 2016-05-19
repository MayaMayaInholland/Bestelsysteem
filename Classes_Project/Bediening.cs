using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Bediening : Medewerker
    {

        //Meer ?
        List<Tafel> tafels;

        public Bediening(int id, int pincode, string naam, string achternaam) : base(id, pincode, naam, achternaam)
        {
            tafels = new List<Tafel>();
        }
    }
}