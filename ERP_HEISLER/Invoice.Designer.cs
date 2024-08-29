namespace ERP_HEISLER
{
	partial class Invoice
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			faturalabel = new Label();
			label1 = new Label();
			label3 = new Label();
			panel1 = new Panel();
			label4 = new Label();
			label2 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// faturalabel
			// 
			faturalabel.AutoSize = true;
			faturalabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			faturalabel.Location = new Point(179, 508);
			faturalabel.Name = "faturalabel";
			faturalabel.Size = new Size(87, 20);
			faturalabel.TabIndex = 0;
			faturalabel.Text = "Fatura Valor";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 508);
			label1.Name = "label1";
			label1.Size = new Size(42, 20);
			label1.TabIndex = 1;
			label1.Text = "Total";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 545);
			label3.Name = "label3";
			label3.Size = new Size(247, 20);
			label3.TabIndex = 3;
			label3.Text = "Thanks for suporting local business !";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Window;
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(faturalabel);
			panel1.Location = new Point(12, 26);
			panel1.Name = "panel1";
			panel1.Size = new Size(312, 596);
			panel1.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(133, 509);
			label4.Name = "label4";
			label4.Size = new Size(41, 20);
			label4.TabIndex = 6;
			label4.Text = "KWZ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(19, 471);
			label2.Name = "label2";
			label2.Size = new Size(279, 20);
			label2.TabIndex = 5;
			label2.Text = "---------------------------------------------\r\n";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(82, 16);
			label5.Name = "label5";
			label5.Size = new Size(135, 20);
			label5.TabIndex = 7;
			label5.Text = "Heisler ERP Invoice";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(92, 45);
			label6.Name = "label6";
			label6.Size = new Size(109, 20);
			label6.TabIndex = 8;
			label6.Text = "Luanda Angola";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(92, 94);
			label7.Name = "label7";
			label7.Size = new Size(109, 20);
			label7.TabIndex = 9;
			label7.Text = "FRI 04/07/2024";
			// 
			// Invoice
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(336, 648);
			Controls.Add(panel1);
			Name = "Invoice";
			Text = "Invoice";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		public Label faturalabel;
		private Label label1;
		private Label label3;
		private Panel panel1;
		private Label label4;
		private Label label2;
		private Label label6;
		private Label label5;
		private Label label7;
	}
}