﻿using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ERP_HEISLER.Controller
{
    internal class Armazem_Controller
    {

        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();



        public static void debug(string nome)
        {
            System.Diagnostics.Debug.WriteLine(nome + "debuging");

        }
        // Apagar esta funçao ja não esta a ser utilizada

        public static void adicionarproduto()
        {
            try
            {

                if (f1 == null)
                {
                    throw new ArgumentNullException("não pode ser null");
                }


                string nome_do_producto = f1.richTextBox4.Text;
                System.Diagnostics.Debug.WriteLine(nome_do_producto);

                string marca_do_producto = f1.richTextBox5.Text;
                System.Diagnostics.Debug.WriteLine(marca_do_producto);

                string numero_de_serie = f1.richTextBox6.Text;
                System.Diagnostics.Debug.WriteLine(numero_de_serie);

                string quantidade_do_produto = f1.richTextBox7.Text;
                System.Diagnostics.Debug.WriteLine(quantidade_do_produto);

                string data_de_criacao = f1.data_de_criaçao.Value.ToString("yyyy-MM-dd");
                System.Diagnostics.Debug.WriteLine(data_de_criacao);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void adicionarproductodb()



        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null .");

            }
            string nome_do_producto = f1.richTextBox4.Text;

            string marca_do_producto = f1.richTextBox5.Text;

            string numero_de_serie = f1.richTextBox6.Text;

            string quantidade_do_produto = f1.richTextBox7.Text;

            string data_de_criacao = f1.data_de_criaçao.Value.ToString("yyyy-MM-dd");

            string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO armazem_adicionar ( nome_do_produto, marca, sn, quantidade, criado)" +
                " VALUES ('" + nome_do_producto + "', '" + marca_do_producto + "', '" + numero_de_serie + "'," +
                " '" + quantidade_do_produto + "','" + data_de_criacao + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        // Visualizar os items 

        public static void VisualizarStockdb ()
        {

			if (f1 == null)
			{
				throw new ArgumentNullException("não pode ser null");

			}


			string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;

			SqlConnection cnn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM armazem_adicionar;", cnn);

			DataTable data = new DataTable();
			sda.Fill(data);

			f1.warehouse_grid.DataSource = data;

			

		}



    }
}
