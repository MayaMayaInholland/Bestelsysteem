using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes_Project
{
    class BestellingDAO
    {
        SqlConnection conn;

        public BestellingDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        public Bestelling GetByTafelId(int tafel_id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select * FROM Producten_bij_bestelling WHERE bestelling_id IN( SELECT id FROM Bestelling WHERE tafel_id = {0} ", tafel_id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

            }
        }
    
    }
}
