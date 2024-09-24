using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;

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
			string Query = "SELECT MAX(contabilidade_id) From Contabilidade";
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

			string data = f1.dateTimePicker3.Value.ToString("yyyy-MM-dd");

			string descricao = f1.richTextBox1.Text;
			string gastos_string = f1.richTextBox2.Text;
			string credito_string = f1.richTextBox3.Text;
			int saldo_da_conta = 0;


			int credito = int.Parse(credito_string);
			int gastos = int.Parse(gastos_string);


			string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
			SqlConnection con = new SqlConnection(ConnectionString);


			var cmd = new SqlCommand("SELECT TOP 1 saldo_da_conta FROM Contabilidade ORDER BY contabilidade_id DESC", con);
			con.Open();

			SqlDataReader reader = cmd.ExecuteReader();


			while (reader.Read())
			{
				int totalbalanco = reader.GetInt32(0);

				if (gastos > 0)
				{
					saldo_da_conta = totalbalanco - gastos;

				}
				else
				{
					saldo_da_conta = totalbalanco + credito;
				}
				cmd.CommandText = "INSERT INTO Contabilidade ( contabilidade_id, data, descricao, gastos, creditos, saldo_da_conta)" +
		" VALUES ( '" + IncrementarId() + "' ,'" + data + "', '" + descricao + "', '" + gastos + "', '" + credito + "',  '" + saldo_da_conta + "')";


			}

			con.Close();
			con.Open();


			cmd.ExecuteNonQuery();
			con.Close();


			System.Windows.Forms.MessageBox.Show("Registo de contabilidade adicionado" + " " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss", new CultureInfo("PT-pt")));


		}

		public static void visualizarbalanço()
		{
			if (f1 == null)
			{
				throw new ArgumentNullException("não pode ser null");

			}


			string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;

			SqlConnection cnn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Contabilidade;", cnn);

			DataTable data = new DataTable();
			sda.Fill(data);

			f1.contabilidade_grid.DataSource = data;
		}


	}
}
