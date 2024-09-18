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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			button1 = new Button();
			printPreviewDialog1 = new PrintPreviewDialog();
			faturalabel = new Label();
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			label19 = new Label();
			label20 = new Label();
			label21 = new Label();
			label22 = new Label();
			label23 = new Label();
			panel1 = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// button1
			// 
			button1.Location = new Point(119, 17);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 5;
			button1.Text = "Imprimir";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog1.ClientSize = new Size(400, 300);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.Enabled = true;
			printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
			printPreviewDialog1.Name = "printPreviewDialog1";
			printPreviewDialog1.Visible = false;
			// 
			// faturalabel
			// 
			faturalabel.AutoSize = true;
			faturalabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			faturalabel.Location = new Point(189, 424);
			faturalabel.Name = "faturalabel";
			faturalabel.Size = new Size(87, 20);
			faturalabel.TabIndex = 0;
			faturalabel.Text = "Fatura Valor";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(44, 502);
			label3.Name = "label3";
			label3.Size = new Size(189, 20);
			label3.TabIndex = 3;
			label3.Text = "Obrigado pela prefêrencia!";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 423);
			label1.Name = "label1";
			label1.Size = new Size(42, 20);
			label1.TabIndex = 1;
			label1.Text = "Total";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 386);
			label2.Name = "label2";
			label2.Size = new Size(279, 20);
			label2.TabIndex = 5;
			label2.Text = "---------------------------------------------\r\n";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(132, 424);
			label4.Name = "label4";
			label4.Size = new Size(41, 20);
			label4.TabIndex = 6;
			label4.Text = "KWZ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(92, 10);
			label5.Name = "label5";
			label5.Size = new Size(115, 20);
			label5.TabIndex = 7;
			label5.Text = "Heisler ERP, Lda";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(83, 30);
			label6.Name = "label6";
			label6.Size = new Size(134, 20);
			label6.TabIndex = 8;
			label6.Text = "Rua Santa Catarina";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(178, 130);
			label7.Name = "label7";
			label7.Size = new Size(124, 20);
			label7.TabIndex = 9;
			label7.Text = "04/07/2024 12:43";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(79, 50);
			label8.Name = "label8";
			label8.Size = new Size(138, 20);
			label8.TabIndex = 10;
			label8.Text = " 5400-200 Barreiros";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(28, 90);
			label9.Name = "label9";
			label9.Size = new Size(136, 20);
			label9.TabIndex = 11;
			label9.Text = "Fatura Simplificada";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(18, 70);
			label10.Name = "label10";
			label10.Size = new Size(279, 20);
			label10.TabIndex = 12;
			label10.Text = "---------------------------------------------\r\n";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(18, 110);
			label11.Name = "label11";
			label11.Size = new Size(279, 20);
			label11.TabIndex = 13;
			label11.Text = "---------------------------------------------\r\n";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(178, 90);
			label12.Name = "label12";
			label12.Size = new Size(98, 20);
			label12.TabIndex = 14;
			label12.Text = "FS 09P2024/1";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(28, 157);
			label13.Name = "label13";
			label13.Size = new Size(86, 20);
			label13.TabIndex = 15;
			label13.Text = "NIF: 299389";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(79, 177);
			label14.Name = "label14";
			label14.Size = new Size(124, 20);
			label14.TabIndex = 16;
			label14.Text = "Consumidor Final";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(29, 177);
			label15.Name = "label15";
			label15.Size = new Size(53, 20);
			label15.TabIndex = 17;
			label15.Text = "Nome:";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(18, 197);
			label16.Name = "label16";
			label16.Size = new Size(279, 20);
			label16.TabIndex = 18;
			label16.Text = "---------------------------------------------\r\n";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(18, 232);
			label17.Name = "label17";
			label17.Size = new Size(279, 20);
			label17.TabIndex = 19;
			label17.Text = "---------------------------------------------\r\n";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(29, 217);
			label18.Name = "label18";
			label18.Size = new Size(91, 20);
			label18.TabIndex = 20;
			label18.Text = "Qtd. X Preço";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(230, 217);
			label19.Name = "label19";
			label19.Size = new Size(42, 20);
			label19.TabIndex = 21;
			label19.Text = "Total";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(18, 298);
			label20.Name = "label20";
			label20.Size = new Size(279, 20);
			label20.TabIndex = 22;
			label20.Text = "---------------------------------------------\r\n";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(24, 252);
			label21.Name = "label21";
			label21.Size = new Size(102, 20);
			label21.TabIndex = 23;
			label21.Text = "Produtos Saas";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(29, 278);
			label22.Name = "label22";
			label22.Size = new Size(30, 20);
			label22.TabIndex = 24;
			label22.Text = "4 X";
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(18, 444);
			label23.Name = "label23";
			label23.Size = new Size(279, 20);
			label23.TabIndex = 25;
			label23.Text = "---------------------------------------------\r\n";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Window;
			panel1.Controls.Add(label23);
			panel1.Controls.Add(label22);
			panel1.Controls.Add(label21);
			panel1.Controls.Add(label20);
			panel1.Controls.Add(label19);
			panel1.Controls.Add(label18);
			panel1.Controls.Add(label17);
			panel1.Controls.Add(label16);
			panel1.Controls.Add(label15);
			panel1.Controls.Add(label14);
			panel1.Controls.Add(label13);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(faturalabel);
			panel1.Location = new Point(12, 52);
			panel1.Name = "panel1";
			panel1.Size = new Size(312, 570);
			panel1.TabIndex = 4;
			// 
			// Invoice
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(336, 648);
			Controls.Add(button1);
			Controls.Add(panel1);
			Name = "Invoice";
			Text = "Invoice";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Drawing.Printing.PrintDocument printDocument1;
		private Button button1;
		private PrintPreviewDialog printPreviewDialog1;
		public Label faturalabel;
		private Label label3;
		private Label label1;
		private Label label2;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label21;
		private Label label22;
		private Label label23;
		public Panel panel1;
	}
}