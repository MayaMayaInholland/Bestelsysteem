using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Bestelling
    {
        protected int id;

        public int RekeningId { get; set; }

        public int Tijd { get; set; }
        public string Opmerkingen { get; set; }
        public string Status { get; set; }

        public Bestelling( Tafel tafel, Medewerker medewerker, int tijd, string status)
        {
            this.Tijd = tijd;
            this.Status = status;
        }

    }
}