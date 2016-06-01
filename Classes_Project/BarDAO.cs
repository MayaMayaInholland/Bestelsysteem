using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Classes_Project
{
    class BarDAO
    {
        SqlConnection conn;

        public void BarBestellingKlaar(int tafelID)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Besteld_product SET status = 1 WHERE bestelling_id IN (SELECT id FROM Bestelling WHERE tafel_id = {0} AND product_id IN (SELECT id FROM Product WHERE categorie_id > 8))", tafelID), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }

        public void BarBestellinNIETKlaar(int tafelID)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Besteld_product SET status = 0 WHERE bestelling_id IN (SELECT id FROM Bestelling WHERE tafel_id = {0} AND product_id IN (SELECT id FROM Product WHERE categorie_id > 8))", tafelID), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }



    }
}
