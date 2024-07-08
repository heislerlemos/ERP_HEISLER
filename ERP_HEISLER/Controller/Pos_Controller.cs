using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP_HEISLER.Controller
{
    internal class Pos_Controller
    {




        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        private static int Total;

        public static void Incremet()
        {


            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }


            string item_1 = f1.comboxpos.Text;

            int valor_inicial = 50;
            int Total = valor_inicial *= 2;
            Total++;

            System.Diagnostics.Debug.WriteLine(Total.ToString());
            f1.textBox13.Text = Total.ToString();





        }

    }
}
