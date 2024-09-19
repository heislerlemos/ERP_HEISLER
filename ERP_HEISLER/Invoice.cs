using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_HEISLER
{
	public partial class Invoice : Form
	{
		public Invoice()
		{
			InitializeComponent();
		}

		private System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();


		private void button1_Click(object sender, EventArgs e)
		{
		
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}
		
		}


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Image imageFile = Image.FromFile("C:\\Users\\heisler.lemos\\source\\repos\\heislerlemos\\ERP_HEISLER\\ERP_HEISLER\\Resources\\logo_invoice.jpeg");
			Image image = (Bitmap)imageFile.Clone();

			e.Graphics.DrawImage(imageFile, 370,10,55,35);

			e.Graphics.DrawString("Fatura Cliente", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(330, 50));
			e.Graphics.DrawString("-----------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 70));
			e.Graphics.DrawString("Heisler ERP, Lda", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 90));
			e.Graphics.DrawString("Rua Santa Catarina", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 110));
			e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 140));
			e.Graphics.DrawString("-----------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 160));
			e.Graphics.DrawString(faturalabel.Text + " MIL " + "KZ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 180));
		}
	}
}
