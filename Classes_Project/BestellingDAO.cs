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
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Bestelling WHERE tafel_id = {0} ", tafel_id), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Besteld_product> bestellingen = new List<Besteld_product>();
            while (reader.Read())
            {
                int Id = (int)reader["id"];
                int Tafel_id = (int)reader["tafel_id"];
                int Medewerker_id = (int)reader["medewerker_id"];
                int tijd = (int)reader["tijd"];
                int totaalbedrag = (int)reader["totaalbedrag"];
                string opmerkingen = (string)reader["opmerkingen"];
                BestellingStatus status = (BestellingStatus)reader["status"];
                int fooi = (int)reader["fooi"];
                bestellingen = GetByBestellingId(Id);
            }

        }

        public List<Besteld_product> GetByBestellingId(int Bestelling_Id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Besteld_product INNER JOIN Product ON Besteld_product.product_id = Product.id WHERE Besteld_product.bestelling_id = {0}", Bestelling_Id), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Besteld_product> besteld_producten;
            int counter = 0;
            besteld_producten = new List<Besteld_product>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                int categorie_id = (int)reader["categorie_id"];
                string omschrijving = (string)reader["omschrijving"];
                int prijs = (int)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];

                Product product = new Product(id, categorie_id, prijs, voorraad, btw);

                Besteld_product besteld_product = new Besteld_product(product);

                besteld_producten.Add(besteld_product);
            }

            return besteld_producten;

        }

    }
}
