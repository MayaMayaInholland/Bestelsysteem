using System.Data.SqlClient;

namespace Classes_Project
{
    internal class RekeningDAO
    {
        private SqlConnection conn;

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
            int resultaat = cmd.ExecuteNonQuery();
        }
    }
}