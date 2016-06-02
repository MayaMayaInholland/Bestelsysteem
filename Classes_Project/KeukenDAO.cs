using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Classes_Project
{
    class KeukenDAO
    {
        SqlConnection conn;

        public void KeukenBestellingKlaar(int tafelID)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Besteld_product SET status = 1 WHERE bestelling_id IN (SELECT id FROM Bestelling WHERE tafel_id = {0} AND product_id IN (SELECT id FROM Product WHERE categorie_id < 8))", tafelID), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }


        public void KeukenBestellingNIETKlaar(int tafelID)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Besteld_product SET status = 2 WHERE bestelling_id IN (SELECT id FROM Bestelling WHERE tafel_id = {0} AND product_id IN (SELECT id FROM Product WHERE categorie_id < 8))", tafelID), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }

        public List<Product> GetActiveBesteldeProducten()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Besteld_product INNER JOIN Product ON Besteld_product.product_id = Product.id WHERE Besteld_product.status = 1"), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Product> lijst_Activeroducten = new List<Product>();

            while (reader.Read())
            {
                int BesteldProduct_id = (int)reader["id"];
                int Bestelling_id = (int)reader["bestelling_id"];
                int Product_id = (int)reader["product_id"];
                int Status = (int)reader["status"];
                int Aantal = (int)reader["aantal"];
               // string Opmerkingen = "";
                //if (reader["opmerkingen"] != DBNull.Value)
                //{
                //    Opmerkingen = (string)reader["opmerkingen"];
                //}
                int ProductId = (int)reader["id"];
                int Categorie_id = (int)reader["categorie_id"];
                string Omschrijving = (string)reader["omschrijving"];
                int Prijs = (int)reader["prijs"];
                int Voorraad = (int)reader["voorraad"];
                int Btw = (int)reader["btw"];


                //Overload van class product voor al bestaande bestellingen.... ( opgezet zodat code runt )
                Product product = new Product(BesteldProduct_id, Categorie_id, Prijs, Voorraad, Btw, Omschrijving );

                lijst_Activeroducten.Add(product);

                reader.Close();
                conn.Close();
                
            }
            reader.Close();
            conn.Close();
            return lijst_Activeroducten;
        }

        public List<Product> GetKLAARBesteldeProducten()
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Besteld_product INNER JOIN Product ON Besteld_product.product_id = Product.id WHERE Besteld_product.status = 0"), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Product> lijst_NietActiveroducten = new List<Product>();

            while (reader.Read())
            {
                int BesteldProduct_id = (int)reader["Besteld_product.id"];
                int Bestelling_id = (int)reader["bestelling_id"];
                int Product_id = (int)reader["product_id"];
                int Status = (int)reader["status"];
                int Aantal = (int)reader["aantal"];
                string Opmerkingen = "";
                if (reader["opmerkingen"] != DBNull.Value)
                {
                    Opmerkingen = (string)reader["opmerkingen"];
                }
                int ProductId = (int)reader["Product.id"];
                int Categorie_id = (int)reader["categorie_id"];
                string Omschrijving = (string)reader["omschrijving"];
                int Prijs = (int)reader["prijs"];
                int Voorraad = (int)reader["voorraad"];
                int Btw = (int)reader["btw"];


                //Overload van class product voor al bestaande bestellingen.... ( opgezet zodat code runt )
                Product product = new Product(BesteldProduct_id, Categorie_id, Prijs, Voorraad, Btw, Omschrijving);

                lijst_NietActiveroducten.Add(product);

                reader.Close();
                conn.Close();

            }
            reader.Close();
            conn.Close();
            return lijst_NietActiveroducten;
        }
    }
}
