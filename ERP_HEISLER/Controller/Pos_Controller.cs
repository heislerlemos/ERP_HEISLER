﻿namespace ERP_HEISLER.Controller
{
    internal class Pos_Controller
    {




        public static Main? f1 = Application.OpenForms.OfType<Main>().FirstOrDefault();

        /**
        public static void Incremet()
        {


            if (f1 == null)
            {
                throw new ArgumentNullException("não pode ser null");
            }


            string item_1 = f1.comboxpos.Text;

            int valor_inicial = 50;
            int Total = valor_inicial *= 2;


           
            System.Diagnostics.Debug.WriteLine(Total.ToString());
            f1.textBox13.Text = Total.ToString();






        }
          Not using this function  
        */

    }
}
