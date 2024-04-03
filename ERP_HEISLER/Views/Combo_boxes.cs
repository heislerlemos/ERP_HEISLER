using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ERP_HEISLER.Views
{
   internal class Combo_boxes
    {
        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static void display()
        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }

            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);

            string query = "SELECT nome_da_empresa from entrada_do_lead";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                f1.comboBox2.Items.Add(DR[0]);
                f1.comboBox8.Items.Add(DR[0]);
                f1.comboBox7.Items.Add(DR[0]);
                f1.comboBox3.Items.Add(DR[0]);


            }



        }

    }
}
