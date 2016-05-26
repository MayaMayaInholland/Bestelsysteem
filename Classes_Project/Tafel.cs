using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Tafel
    {
        public int Nummer { get; set; }
        public TafelStatus Status { get; set; }
        public Bestelling Bestelling { get; set; }

        public Tafel(int id, int nummer, TafelStatus status)
        {
            this.Nummer = nummer;
            this.Id = id;
            this.Status = status;
        }

        public Tafel(int Id, int nummer, TafelStatus status, Bestelling bestelling)
        {
            this.Nummer = nummer;
            this.Status = status;
            this.Id = Id;
            this.Bestelling = bestelling;
        }
    }
}