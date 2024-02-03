using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_HEISLER.Controller
{
    internal class Crm_controller
    {

        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        public static void adicionar_clientes()
        {
            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }

                
        }

    }
}
