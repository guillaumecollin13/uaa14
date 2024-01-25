using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BDD_immo_GuillaumeC
{
    internal class methodesDuProjet
    {
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=immo;port=3306;User Id=guillaume;password=root";
        }

        public bool chercheUser(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos, "infoUser");

                if (infos.Tables[0].Rows.Count > 1) 
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }
        public bool ajouteUser(string[] donnees)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();
                MySqlCommand insertCommand = new MySqlCommand(query, maConnection);

                insertCommand.Parameters.AddWithValue("@nomUser", donnees[0]);
                insertCommand.Parameters.AddWithValue("@prenomUser", donnees[1]);
                insertCommand.Parameters.AddWithValue("@loginUser", donnees[2]);
                insertCommand.Parameters.AddWithValue("@passwordUser", donnees[3]);
                insertCommand.Parameters.AddWithValue("@role", donnees[4]);

                if (insertCommand.ExecuteReader)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }

        public string AfficheUser(DataSet donees)
        {
            string infos = "";
            for (int i = 0; i < donees.Tables[0].Rows.Count; i++)
            {
                infos += donees.Tables[0].Rows[i]["nomUser"].ToString+" | "+ 
                         donees.Tables[0].Rows[i]["prenomUser"].ToString + " | " +
                         donees.Tables[0].Rows[i]["loginUser"].ToString + " | " +
                         donees.Tables[0].Rows[i]["passordUser"].ToString + " | " +"\n";
            }
            return infos;
            
        }
    }
}
