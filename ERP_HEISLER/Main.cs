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

        private void contabilidade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rh_Controller.removerdb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rh_Controller.adicionardb();

        }

        private void recursoshumanos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Contabilidade_Controller.adicionarcontasdb();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void submeter_dados_Click(object sender, EventArgs e)
        {
            Armazem_Controller.adicionarproductodb();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

 

      

        private void crm_Paint(object sender, PaintEventArgs e)
        {

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


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        

          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/heisler-stlano-969624146/") { UseShellExecute = true });

        }

        public static implicit operator Main(string v)
        {
            throw new NotImplementedException();
        }
    }
}
