using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
            f1.comboBox2.Items.Add("Aparece");
        


        }

    }
}
