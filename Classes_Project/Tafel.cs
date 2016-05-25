using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Project
{
    public class Tafel
    {
        private int Id;
        public int Nummer { get; set; }
        public TafelStatus Status { get; set; }

        public Tafel(int Id, int nummer, TafelStatus status)
        {
            this.Nummer = nummer;
            this.Status = status;
            this.Id = Id;
        }
    }
}