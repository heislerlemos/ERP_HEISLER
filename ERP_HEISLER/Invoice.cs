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
			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = printDocument;
			//Show Print Dialog
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				//Print the page
				printDocument.Print();
			}
		}


	}
}
