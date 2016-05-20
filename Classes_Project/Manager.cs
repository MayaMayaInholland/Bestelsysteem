using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Manager : Medewerker
    {
        //Meer ?

        public Manager(int id, int pincode, string naam, string achternaam, MedewerkerRol rol) : base(id, pincode, naam, achternaam, rol)
        {

        }

    }
}