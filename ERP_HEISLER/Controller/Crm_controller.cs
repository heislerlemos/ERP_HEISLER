using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace ERP_HEISLER.Controller
{
    internal class Crm_controller
    {

        public static int IncrementarId()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT MAX(id) From entrada_do_lead";
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



        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static void adicionar_clientes()
        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }

            // input fields when user types the data
            string nome_da_empresa = f1.textBox8.Text;
            string site = f1.textBox9.Text;
            string telefone_da_empresa = f1.textBox10.Text;
            string nome_do_decisor = f1.textBox11.Text;
            string email_do_decisor = f1.textBox12.Text;

            // storing information into the database
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO entrada_do_lead ( id , nome_da_empresa, site, telefone_da_empresa, nome_do_decisor, email_do_decisor)" +
                " VALUES ( '" + IncrementarId() + "' ,'" + nome_da_empresa + "', '" + site + "', '" + telefone_da_empresa + "', " +
                "'" + nome_do_decisor + "', '" + email_do_decisor + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
			//f1.label35.Visible = true; metendo notificação
			System.Windows.Forms.MessageBox.Show("Dados crm adicionados com sucesso" + " " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss", new CultureInfo("PT-pt")));


			con.Close();



        }





    }
}
