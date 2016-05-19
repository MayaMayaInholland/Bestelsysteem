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
        public string Status { get; set; }

        public Tafel(int nummer, string status)
        {
            this.Nummer = nummer;
            this.Status = status;
        }
    }
}