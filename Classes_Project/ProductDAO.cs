using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes_Project
{
    class ProductDAO
    {
        SqlConnection conn;

        public ProductDAO()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
        }

        public List<Product> GetProducten()
        {
            List<Product> Lijst_Producten = new List<Product>();

            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(("SELECT * FROM Product"), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                int categorie_id = (int)reader["categorie_id"];
                string omschrijving = (string)reader["omschrijving"];
                //float prijs = (float)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];

                Product product = new Product(id, categorie_id, 10, voorraad, btw, omschrijving);

                Lijst_Producten.Add(product);
            }

            conn.Close();
            return Lijst_Producten;
        }
    }
}
