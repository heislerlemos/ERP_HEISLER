using ERP_HEISLER.Controller;
using ERP_HEISLER.Views;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Policy;

namespace ERP_HEISLER
{

    public partial class Main : Form
    {

        List<Panel> listPanel = new List<Panel>();

        public Main()
        {
            InitializeComponent();
        }


        private void armazemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel.Add(armazem);
            armazem.BringToFront();
        }


        private void contabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel.Add(contabilidade);
            contabilidade.BringToFront();
        }

        private void recursosHumanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel.Add(recursoshumanos);
            recursoshumanos.BringToFront();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Rh_Controller.removerdb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rh_Controller.adicionardb();

        }


        private void button3_Click(object sender, EventArgs e)
        {

            Contabilidade_Controller.adicionarcontasdb();
        }


        private void submeter_dados_Click(object sender, EventArgs e)
        {
            Armazem_Controller.adicionarproductodb();

        }


        private void Main_Load(object sender, EventArgs e)
        {
            Combo_boxes.display();
        }


        private void crmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel.Add(crmpanel);
            crmpanel.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Crm_controller.adicionar_clientes();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/heisler-stlano-969624146/") { UseShellExecute = true });
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Main(string v)
        {
            throw new NotImplementedException();
        }
    }
}
