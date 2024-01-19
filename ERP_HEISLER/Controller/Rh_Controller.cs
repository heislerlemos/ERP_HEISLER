using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ERP_HEISLER.Controller
{


    internal class Rh_Controller 
    {


        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();
    
        public static void debug(string nome)
        {

            try {
                System.Diagnostics.Debug.WriteLine(nome + "debuging from rh");
                if (f1 == null)
                {
                    throw new ArgumentNullException("arg");
                }
                string value = f1.textBox1.Text;
                System.Diagnostics.Debug.WriteLine(value);


            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            



        }


    


    }
}
