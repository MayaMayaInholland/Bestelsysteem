using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Classes_Project
{
    class RekeningDAO
    {
        SqlConnection conn;

        public RekeningDAO()
        {

        }

        public Rekening GetByTafelID(int tafelID)
        {
            BestellingDAO bestellingdao = new BestellingDAO();

            Rekening rekening = new Rekening(bestellingdao.GetLopendeBestellingByTafelID(tafelID));

            return rekening;
        }

        public void RekeningBetaald(int tafelID)
        {
            //todo
        }
    }
}
