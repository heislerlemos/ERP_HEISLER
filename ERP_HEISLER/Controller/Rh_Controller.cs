using System;
using System.Collections.Generic;
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
    }
}
