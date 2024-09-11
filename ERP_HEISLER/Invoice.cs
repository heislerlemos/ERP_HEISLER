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
			//PrintDialog printDialog = new PrintDialog();
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog(panel1);
		/*
			printDialog.Document = printDocument;
			//Show Print Dialog
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				//Print the page
				printDocument.Print();
			}
		*/
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("Impressão de fatura visualização",new Font("Arial", 12 , FontStyle.Regular ),Brushes.Black, new Point(100,10));
		}
	}
}
