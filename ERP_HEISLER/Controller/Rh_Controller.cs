using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_HEISLER.Controller
{


    internal class Rh_Controller 
    {
        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();
        public static void adicionar()
        {

            try
            {

                if (f1 == null)
                {
                    throw new ArgumentNullException("não pode ser null");
                }

                string nome_do_funcionario = f1.textBox1.Text;
                System.Diagnostics.Debug.WriteLine(nome_do_funcionario);

                string data_de_criacao = f1.dateTimePicker1.Value.ToString("yyyy-MM-dd");
                System.Diagnostics.Debug.WriteLine(data_de_criacao);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }   
        


        public static void adicionardb()
        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }


            string nome_do_funcionario = f1.textBox1.Text;
            string numero_de_serie = f1.textBox3.Text;
            string data_de_criacao = f1.dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string ConnectionString = "Data Source=0191-L1\\SQLEXPRESS;Initial Catalog=ERP;Persist Security Info=True;User ID=dev;Password=Reh6quo0;";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO rh_adicionar (  nome, nif, criado)" +
                " VALUES ( '" + nome_do_funcionario + "', '" + numero_de_serie + "', '" + data_de_criacao+ "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

           
            con.Close();


        }

        public static void remover()
        {

            try
            {

                if (f1 == null)
                {
                    throw new ArgumentNullException("não pode ser null");
                }

                string nome_do_funcionario = f1.textBox2.Text;
                System.Diagnostics.Debug.WriteLine(nome_do_funcionario);

                string data_de_criacao = f1.dateTimePicker2.Value.ToString("yyy-MM-dd");
                System.Diagnostics.Debug.WriteLine(data_de_criacao);


            } catch (Exception e)
            
            
            {
                MessageBox.Show(e.Message);
            }            

        }
        public static void removerdb()
        {

           if (f1 == null) {
                throw new ArgumentNullException("não pode ser nulo");
           }



            string nome_do_funcionario = f1.textBox2.Text;
            string data_de_criacao = f1.dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string nif = f1.textBox4.Text;
            string ConnectionString = "Data Source=0191-L1\\SQLEXPRESS;Initial Catalog=ERP;Persist Security Info=True;User ID=dev;Password=Reh6quo0;";




        SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO rh_remover ( id ,nome, nif, apagado)" +
                " VALUES ( '"+ generateId() +"' ,  '" + nome_do_funcionario + "', '" + nif + "', '" + data_de_criacao + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private static int id = 1;
        static int generateId()
        {
            return id++;
        }

    }
}
