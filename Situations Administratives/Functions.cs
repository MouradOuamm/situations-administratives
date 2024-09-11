using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situations_Administratives
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd; 
        private SqlDataAdapter sda;
        private DataTable dt;
        private string constr;
            
        public Functions()
        {
   constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\GestionDR.mdf;Integrated Security=True";         
            // constr = @"Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True";
            con = new SqlConnection(constr);
        }

        // Méthode pour récupérer des données
// Méthode pour récupérer des données avec des paramètres
public DataTable GetData(string query, SqlParameter[] parameters = null)
{
    dt = new DataTable();
    try
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            // Ajouter les paramètres s'ils existent
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }

            // Remplir le DataTable
            using (sda = new SqlDataAdapter(cmd))
            {
                sda.Fill(dt);
            }
        }
    }
    catch (Exception ex)
    {
        // Gestion des erreurs
        MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
    }
    return dt;
}


        // Méthode pour insérer/mettre à jour/supprimer des données
        public int SetData(string query, SqlParameter[] parameters = null)
        {
            int cnt = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    cnt = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return cnt;
        }

    }
}
