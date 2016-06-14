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


        //Update de status naar klaar of niet
        public void BestellingKlaar(int tafelnummer, int Niewstatus, int status, string meer)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Besteld_product SET status = {1} FROM Besteld_product, Product, Tafel, Bestelling WHERE Besteld_product.status = {2} AND product_id = Product.id AND tafel_id = Tafel.id AND Besteld_product.bestelling_id = Bestelling.id AND categorie_id {3} 8 AND nummer = {0} ", tafelnummer, Niewstatus, status, meer), conn);
            // SqlDataReader reader = cmd.ExecuteReader();
            int resultaat = cmd.ExecuteNonQuery();
        }




        public List<Besteld_product> GetActiveBesteldeProducten(int status, string meer)
        {
            conn = new SqlConnection(Helper.ConnectionString);
            conn.Open();

            //De aangeklikte tafel geeft de tafel_id mee.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT Besteld_product.id as Besteldproduct_id, bestelling_id, product_id, Besteld_product.status, aantal, Besteld_product.opmerking, categorie_id, omschrijving, nummer as Tafel_nummer FROM Besteld_product, Product, Tafel, Bestelling WHERE Besteld_product.status = {0} AND product_id = Product.id AND tafel_id = Tafel.id AND Besteld_product.bestelling_id = Bestelling.id AND categorie_id {1} 8 ORDER BY Tafel_nummer", status, meer), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List waarin de al bestelde producten in komen.
            List<Besteld_product> lijst_Activeroducten = new List<Besteld_product>();

            while (reader.Read())
            {
                int BesteldProduct_id = (int)reader["Besteldproduct_id"];
                int Bestelling_id = (int)reader["Bestelling_id"];
                int Product_id = (int)reader["product_id"];
                int Status = (int)reader["status"];
                int Aantal = (int)reader["aantal"];
                string Opmerking = "";
                if (reader["opmerking"] != DBNull.Value)
                {
                    Opmerking = (string)reader["opmerking"];
                }
                int Categorie_id = (int)reader["categorie_id"];
                string Omschrijving = (string)reader["omschrijving"];
                int Tafel_nummer = (int)reader["Tafel_nummer"];


                //Overload van class product voor al bestaande bestellingen.... ( opgezet zodat code runt )
                Besteld_product product = new Besteld_product(BesteldProduct_id, Bestelling_id, Product_id, Status, Aantal, Opmerking, Categorie_id, Omschrijving, Tafel_nummer);

                lijst_Activeroducten.Add(product);
            }
            reader.Close();
            conn.Close();
            return lijst_Activeroducten;
        }

    }
}
