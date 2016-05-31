using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Classes_Project
{
    public static class Helper
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ReserveringenConnectionStringsSQL"].ConnectionString;
    }

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
        Gereed,
        Geserveerd,
        Betaald
    }
    
    public enum ProductStatus
    {
        Besteld = 1,
        Gereed,
        Geserveerd
    }

    public enum MenuCategorie
    {
        Lunch,
        Dinner
    }
}
