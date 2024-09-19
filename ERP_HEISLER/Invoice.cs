using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
			// Get the current date
			datelabel.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss", new CultureInfo("PT-pt"));

			//  Get the preview document and print 
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}

		}


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			// Get the image for the logo 
			Image imageFile = Image.FromFile("C:\\Users\\heisler.lemos\\source\\repos\\heislerlemos\\ERP_HEISLER\\ERP_HEISLER\\Resources\\logo_invoice.jpeg");
			Image image = (Bitmap)imageFile.Clone();



			// Call the Graphics function if is not null
			if (e.Graphics != null)
			{
				e.Graphics.DrawImage(imageFile, 370, 10, 55, 35);
				e.Graphics.DrawString("Fatura Cliente", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(330, 50));
				e.Graphics.DrawString("-------------------------------------------------------",
					new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, 70));
				e.Graphics.DrawString("Heisler ERP, Lda", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 90));
				e.Graphics.DrawString("Rua Santa Catarina", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 110));
				e.Graphics.DrawString("Data: " + datelabel.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 135));
				e.Graphics.DrawString("Valor Total:", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 160));
				e.Graphics.DrawString("--------------------------------------------------------",
					new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, 185));
				e.Graphics.DrawString(faturalabel.Text + "MIL KZ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 210));
				e.Graphics.DrawString( "Obrigado pela sua preferencia", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 250));

			}
		}
	}
}
