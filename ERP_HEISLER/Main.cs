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
    }
}
