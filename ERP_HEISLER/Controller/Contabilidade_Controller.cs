using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ERP_HEISLER.Controller
{
    internal class Contabilidade_Controller
    {

        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static int IncrementarId()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT MAX(id) From contabilidade_gastos";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader[0]));
                int myInt = reader.GetInt32(0);
                System.Diagnostics.Debug.WriteLine(myInt);
                return Interlocked.Increment(ref myInt);
            }

            return 0;



        }


        public static void adicionarcontasdb()
        {
            if (f1 == null)
            {

                throw new ArgumentNullException("não pode ser null");

            }

            string valor = f1.richTextBox1.Text;

            string produto = f1.richTextBox2.Text;

            string data_de_criaçao = f1.dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO contabilidade_gastos ( id , valor, gasto_aonde, data)" +
                " VALUES ( '" + IncrementarId() + "' ,'" + valor + "', '" + produto + "', '" + data_de_criaçao + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
