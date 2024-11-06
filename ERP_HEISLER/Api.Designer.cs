namespace ERP_HEISLER
{
	partial class Api
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
			label1 = new Label();
			dados = new RichTextBox();
			panel1 = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(73, 16);
			label1.Name = "label1";
			label1.Size = new Size(260, 89);
			label1.TabIndex = 0;
			label1.Text = "API RH";
			// 
			// dados
			// 
			dados.Location = new Point(21, 165);
			dados.Name = "dados";
			dados.Size = new Size(416, 489);
			dados.TabIndex = 1;
			dados.Text = "";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.BorderStyle = BorderStyle.Fixed3D;
			panel1.Controls.Add(label1);
			panel1.Location = new Point(21, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(409, 125);
			panel1.TabIndex = 2;
			// 
			// Api
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(462, 691);
			Controls.Add(dados);
			Controls.Add(panel1);
			Name = "Api";
			Text = "Api";
			Load += Api_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		public RichTextBox dados;
		private Panel panel1;
	}
}