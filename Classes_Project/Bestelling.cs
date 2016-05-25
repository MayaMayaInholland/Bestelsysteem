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
        public int ProductId { get; set; }
        public DateTime Tijd { get; set; }
        public string Opmerkingen { get; set; }
        public string Status { get; set; }

        public Bestelling(int id, int rekeningid, int productid, DateTime tijd)
        {
            this.id = id;
            this.RekeningId = rekeningid;
            this.ProductId = productid;
            this.Tijd = tijd;
        }

    }
}