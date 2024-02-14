using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace ERP_HEISLER.Controller
{


    internal class Rh_Controller
    {

        public static int IncrementarId()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT MAX(id) From rh_adicionar";    
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
        public static void adicionardb()
        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }

            string genero = f1.checkedListBox1.Text;
            string localidade = f1.comboBox1.Text;
            string nome_do_funcionario = f1.textBox1.Text;
            string numero_de_serie = f1.textBox3.Text;
            string email = f1.textBox5.Text;
            string data_de_nascimento= f1.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string nacionalidade = f1.textBox6.Text;
            string telefone = f1.textBox7.Text;
            string estado_civil = f1.checkedListBox2.Text;


            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
        
                con.Open();

                string Query = "INSERT INTO rh_adicionar ( id, nome, nif, genero, localidade, email, data_de_nascimento, " +
                    " nacionalidade, telefone, estado_civil)" +
                    " VALUES ( '" + IncrementarId() + "','" + nome_do_funcionario + "', '" + numero_de_serie + "', '" + genero + "'," +
                    " '" + localidade + "', '" + email + "','" + data_de_nascimento + "', '" + nacionalidade + "', '" + telefone + "', '" + estado_civil + "' )";


                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            
        }

        public static void removerdb()
        {

            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser nulo");
            }
            string nome_do_funcionario = f1.textBox2.Text;
            string data_de_criacao = f1.dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string nif = f1.textBox4.Text;
            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM rh_remover WHERE ([nome] = @nome)", con);

            check_User_Name.Parameters.AddWithValue("@nome", nome_do_funcionario);

            int UserExist = (int)check_User_Name.ExecuteScalar();

            if (UserExist > 0)
            {                
                System.Diagnostics.Debug.WriteLine("nome ja existe");
                f1.label16.Visible = true;

                f1.label16.Text = "O nome ja existe por favor adiciona outro nome ";            
            }
            else
            
            
            {
                string Query = "INSERT INTO rh_remover ( nome, nif, apagado)" +
                    " VALUES ( '" + nome_do_funcionario + "', '" + nif + "', '" + data_de_criacao + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            }
            con.Close();
        }


    }
}
