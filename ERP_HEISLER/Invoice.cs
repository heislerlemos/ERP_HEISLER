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

		Bitmap bmp;


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			e.Graphics.DrawString("Fatura", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(370, 10));
			e.Graphics.DrawString("-----------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 20));
			e.Graphics.DrawString("Heisler ERP, Lda", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 40));
			e.Graphics.DrawString("Rua Santa Catarina", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 60));
			e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 100));
			e.Graphics.DrawString("-----", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 120));
			e.Graphics.DrawString(faturalabel.Text + " MIL " + "KZ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 140));
		}
	}
}
