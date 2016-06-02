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
        }

        public List<Product> GetGereedGemeldeProductenVoorBestelling(int bestellingID)
        {
            List<Product> producten = new List<Product>();
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format(("SELECT Product.id AS ID, Product.Omschrijving AS Omschrijving, Product.categorie_id AS cID, Product.prijs AS Prijs, Product.voorraad AS Voorraad, Product.btw AS BTW FROM Besteld_Product INNER JOIN Product ON Besteld_Product.product_id = Product.id WHERE Besteld_Product.bestelling_id = {0} AND Besteld_Product.status = 2"), bestellingID), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string omschrijving = (string)reader["Omschrijving"];
                int cID = (int)reader["cID"];
                int prijs = (int)reader["Prijs"];
                int voorraad = (int)reader["Voorraad"];
                int BTW = (int)reader["BTW"];

                Product product = new Product(id, cID, prijs, voorraad, BTW, omschrijving);

                producten.Add(product);
            }
            reader.Close();
            conn.Close();

            return producten;
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
                Product product;

                int id = (int)reader["id"];
                int categorie_id = (int)reader["categorie_id"];
                string omschrijving = (string)reader["omschrijving"];
                ProductStatus status;
                int prijs = (int)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];

                product = new Product(id,categorie_id,prijs,voorraad,btw,omschrijving);

                Lijst_Producten.Add(product);
            }

            conn.Close();
            return Lijst_Producten;
        }

        public Product GetProductByOmschrijving(string omschrijving)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            Product product;

            SqlCommand cmd = new SqlCommand(("SELECT * FROM Product"), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                int categorie_id = (int)reader["categorie_id"];
                string Omschrijving = (string)reader["omschrijving"];
                //float prijs = (float)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                int btw = (int)reader["btw"];

                if (omschrijving == Omschrijving)
                {
                    product = new Product(id, categorie_id, 10, voorraad, btw, Omschrijving);
                    return product;
                }

            }
            conn.Close();
            return null;
        }
    }
}
