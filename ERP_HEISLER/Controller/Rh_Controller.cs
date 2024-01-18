using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_HEISLER.Controller
{


    internal class Rh_Controller 
    {
        public static Main f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static void debug(string nome)
        {
            System.Diagnostics.Debug.WriteLine(nome + "debuging from rh");
            string value = f1.textBox1.Text;
            System.Diagnostics.Debug.WriteLine(value);



        }


    


    }
}
