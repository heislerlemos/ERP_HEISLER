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

        private void Main_Load(object sender, EventArgs e)
        {
            Combo_boxes.display();
            menuStrip1.Hide();
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

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel.Add(panelPOS);
            panelPOS.BringToFront();


            // ainda não vou mexer nesta parte for now..
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

        private void button4_Click(object sender, EventArgs e)
        {
            Crm_controller.adicionar_clientes();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            String username, password;

            username = textusername.Text;
            password = textpassword.Text;

            try
            {

                string ConnectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                // Fazendo trableshoot do problema de connexão 
                String query = "SELECT * FROM login_user WHERE username= '" + textusername.Text + "' AND password='" + textpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    username = textusername.Text;
                    password = textpassword.Text;

                    // pagina que vai abrir a seguir
                    listPanel.Add(recursoshumanos);
                    recursoshumanos.BringToFront();
                    menuStrip1.Show();
                }


                else
                {
                    MessageBox.Show("password ou username errado", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textpassword.Clear();
                    textusername.Clear();
                }
                con.Close();
            }
            catch

            {
                MessageBox.Show("Erro Interno");
            }

        }


        // POS button increment
        private int Total = 50;
        private void button7_Click(object sender, EventArgs e)
        {
            Total *= 2;
            textBox13.Text = Total.ToString();
        }

    }
}
