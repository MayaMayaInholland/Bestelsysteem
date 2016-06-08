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

        public void RekeningBetaald(Rekening rekening)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            int bestellingid = rekening.Bestelling.Id;

            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Bestelling SET status = 4, totaalbedrag = {1}, opmerking = {2}, fooi = {3}  WHERE id = {0}", rekening.Bestelling.Id, rekening.TotaalBedrag, rekening.Opmerkingen, rekening.Fooi), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }
    }
}
