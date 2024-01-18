namespace ERP_HEISLER
{
    partial class Main 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contabilidadeToolStripMenuItem = new ToolStripMenuItem();
            recursosHumanosToolStripMenuItem = new ToolStripMenuItem();
            armazemToolStripMenuItem = new ToolStripMenuItem();
            contabilidade = new Panel();
            button3 = new Button();
            label1 = new Label();
            recursoshumanos = new Panel();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Nome = new Label();
            label2 = new Label();
            armazem = new Panel();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            contabilidade.SuspendLayout();
            recursoshumanos.SuspendLayout();
            armazem.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { contabilidadeToolStripMenuItem, recursosHumanosToolStripMenuItem, armazemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contabilidadeToolStripMenuItem
            // 
            contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            contabilidadeToolStripMenuItem.Size = new Size(117, 24);
            contabilidadeToolStripMenuItem.Text = "Contabilidade";
            contabilidadeToolStripMenuItem.Click += contabilidadeToolStripMenuItem_Click;
            // 
            // recursosHumanosToolStripMenuItem
            // 
            recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            recursosHumanosToolStripMenuItem.Size = new Size(148, 24);
            recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            recursosHumanosToolStripMenuItem.Click += recursosHumanosToolStripMenuItem_Click;
            // 
            // armazemToolStripMenuItem
            // 
            armazemToolStripMenuItem.Name = "armazemToolStripMenuItem";
            armazemToolStripMenuItem.Size = new Size(87, 24);
            armazemToolStripMenuItem.Text = "Armazem";
            armazemToolStripMenuItem.Click += armazemToolStripMenuItem_Click;
            // 
            // contabilidade
            // 
            contabilidade.BackColor = SystemColors.ActiveCaption;
            contabilidade.Controls.Add(button3);
            contabilidade.Controls.Add(label1);
            contabilidade.Location = new Point(26, 46);
            contabilidade.Name = "contabilidade";
            contabilidade.Size = new Size(746, 348);
            contabilidade.TabIndex = 1;
            contabilidade.Paint += contabilidade_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(406, 89);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Contabilidade";
            label1.Click += label1_Click;
            // 
            // recursoshumanos
            // 
            recursoshumanos.BackColor = SystemColors.ControlLight;
            recursoshumanos.Controls.Add(button2);
            recursoshumanos.Controls.Add(button1);
            recursoshumanos.Controls.Add(dateTimePicker2);
            recursoshumanos.Controls.Add(dateTimePicker1);
            recursoshumanos.Controls.Add(label8);
            recursoshumanos.Controls.Add(label7);
            recursoshumanos.Controls.Add(textBox2);
            recursoshumanos.Controls.Add(textBox1);
            recursoshumanos.Controls.Add(label6);
            recursoshumanos.Controls.Add(label5);
            recursoshumanos.Controls.Add(label4);
            recursoshumanos.Controls.Add(Nome);
            recursoshumanos.Controls.Add(label2);
            recursoshumanos.Location = new Point(23, 46);
            recursoshumanos.Name = "recursoshumanos";
            recursoshumanos.Size = new Size(749, 348);
            recursoshumanos.TabIndex = 2;
            recursoshumanos.Paint += recursoshumanos_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(422, 272);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Submeter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(43, 272);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Submeter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(422, 214);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(264, 27);
            dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(38, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 183);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 8;
            label8.Text = "Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 183);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 7;
            label7.Text = "Data";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 97);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 60);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 3;
            label5.Text = "Funcionario Removidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 60);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 2;
            label4.Text = "Adicionar Funcionarios ";
            label4.Click += label4_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(30, 97);
            Nome.Name = "Nome";
            Nome.Size = new Size(50, 20);
            Nome.TabIndex = 1;
            Nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 0;
            label2.Text = "Recursos Humanos";
            label2.Click += label2_Click;
            // 
            // armazem
            // 
            armazem.BackColor = SystemColors.HighlightText;
            armazem.Controls.Add(label3);
            armazem.ForeColor = SystemColors.ActiveCaptionText;
            armazem.Location = new Point(23, 46);
            armazem.Name = "armazem";
            armazem.Size = new Size(749, 348);
            armazem.TabIndex = 3;
            armazem.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 18);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Armazem";
            label3.Click += label3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(recursoshumanos);
            Controls.Add(contabilidade);
            Controls.Add(armazem);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "HEISLER ERP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contabilidade.ResumeLayout(false);
            contabilidade.PerformLayout();
            recursoshumanos.ResumeLayout(false);
            recursoshumanos.PerformLayout();
            armazem.ResumeLayout(false);
            armazem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contabilidadeToolStripMenuItem;
        private ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private ToolStripMenuItem armazemToolStripMenuItem;
        private Panel contabilidade;
        private Label label1;
        private Panel recursoshumanos;
        private Label label2;
        private Panel armazem;
        private Label label3;
        private Label label4;
        private Label Nome;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button button3;
        public TextBox textBox1;
    }
}
