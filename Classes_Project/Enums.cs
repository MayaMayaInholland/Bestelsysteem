using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Project
{
    public enum MedewerkerRol
    {
        Keuken,
        Bediening,
        Manager,
        Bar
    }

    public enum BestellingStatus
    {
        Open = 1,
        Gereed = 2,
        Geserveerd = 3,
        Betaald = 4
    }

    public enum ProductStatus
    {
        Besteld = 1,
        Gereed = 2,
        Geserveerd = 3
    }
}
