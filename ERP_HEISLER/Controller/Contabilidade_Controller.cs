using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_HEISLER.Controller
{
    internal class Contabilidade_Controller
    {

        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static void adicionarcontas()  
        {
            try
            {
                if (f1 == null)
                {
                    throw new ArgumentNullException("não pode ser null");


                }

                string valor = f1.richTextBox1.Text;
                System.Diagnostics.Debug.WriteLine(valor);

                string produto = f1.richTextBox2.Text;
                System.Diagnostics.Debug.WriteLine(produto);


                string data_de_criaçao = f1.dateTimePicker3.Value.ToString("yyyy-MM-dd");
                System.Diagnostics.Debug.WriteLine(data_de_criaçao);


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


    }
}
