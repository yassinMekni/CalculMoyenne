using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculMoyenne
{
    internal class Etudiant
    {


        public int EtudiantID { get; set; }
        public string NomCom { get; set; }
        public string NoteDS { get; set; }
        public string NoteEx { get; set; }
        public string NoteTP { get; set; }
        public string Moyenne { get; set; }

        public Etudiant(string nomPrenom, string noteDs, string noteExaman, string noteTp)
        {
            this.NomCom = nomPrenom;
            this.NoteDS = noteDs;
            this.NoteEx = noteExaman;
            this.NoteTP = noteTp;
        }

        public Etudiant()
        {
           
        }

        static string myConnection = ConfigurationManager.ConnectionStrings["connexion"].ConnectionString;

        public double calculMoy()
        {
            double calculMoy = ( Double.Parse(this.NoteDS) * 0.3) + (Double.Parse(this.NoteTP) * 0.2) + (Double.Parse(this.NoteEx) * 0.5);
            return calculMoy;
        }


        public bool Insert(Etudiant etudiant)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnection);
            try
            {
                string sql = "INSERT INTO MoyET (NomCom,NoteDS,NoteEx,NoteTP,Moyenne) VALUES(@NomCom,@NoteDS,@NoteEx,@NoteTP,@Moyenne)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NomCom", etudiant.NomCom);
                cmd.Parameters.AddWithValue("@NoteDS", etudiant.NoteDS);
                cmd.Parameters.AddWithValue("@NoteEx", etudiant.NoteEx);
                cmd.Parameters.AddWithValue("@NoteTP", etudiant.NoteTP);
                cmd.Parameters.AddWithValue("@Moyenne", etudiant.Moyenne);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }



            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool Delete(Etudiant etudiant)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnection);
            try
            {
                string sql = "DELETE FROM MoyET WHERE NomCom= @NomCom ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NomCom", etudiant.NomCom);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }



            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

    }
}
