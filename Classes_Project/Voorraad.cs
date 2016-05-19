using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Voorraad
    {
        List<Product> Producten;

        public Voorraad()
        {
            Producten = new List<Product>();
            // query databse voor producten...
        }

    }
}