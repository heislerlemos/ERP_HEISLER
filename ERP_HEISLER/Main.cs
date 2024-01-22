using ERP_HEISLER.Controller;

namespace ERP_HEISLER
{

    public partial class Main : Form
    {



        List<Panel> listPanel = new List<Panel>();

        public Main()
        {
            InitializeComponent();

        }


        public string TextBox1Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
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
            Rh_Controller.remover();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rh_Controller.adicionar();
        }

        private void recursoshumanos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Contabilidade_Controller.adicionarcontas();
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
    }
}
