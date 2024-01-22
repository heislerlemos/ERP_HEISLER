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
            visualizar_movimentos_contabilidade = new Button();
            richTextBox3 = new RichTextBox();
            label10 = new Label();
            dateTimePicker3 = new DateTimePicker();
            data_contabilidade = new Label();
            richTextBox2 = new RichTextBox();
            produto_contabilidade = new Label();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            Submeter_contabilidade = new Button();
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
            submeter_dados = new Button();
            data_de_criaçao = new DateTimePicker();
            data = new Label();
            richTextBox7 = new RichTextBox();
            label13 = new Label();
            richTextBox6 = new RichTextBox();
            label12 = new Label();
            richTextBox5 = new RichTextBox();
            marca_do_produto = new Label();
            richTextBox4 = new RichTextBox();
            label11 = new Label();
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
            menuStrip1.Size = new Size(1397, 28);
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
            contabilidade.BackColor = SystemColors.Control;
            contabilidade.Controls.Add(visualizar_movimentos_contabilidade);
            contabilidade.Controls.Add(richTextBox3);
            contabilidade.Controls.Add(label10);
            contabilidade.Controls.Add(dateTimePicker3);
            contabilidade.Controls.Add(data_contabilidade);
            contabilidade.Controls.Add(richTextBox2);
            contabilidade.Controls.Add(produto_contabilidade);
            contabilidade.Controls.Add(richTextBox1);
            contabilidade.Controls.Add(label9);
            contabilidade.Controls.Add(Submeter_contabilidade);
            contabilidade.Controls.Add(label1);
            contabilidade.Location = new Point(22, 57);
            contabilidade.Name = "contabilidade";
            contabilidade.Size = new Size(1343, 629);
            contabilidade.TabIndex = 1;
            contabilidade.Paint += contabilidade_Paint;
            // 
            // visualizar_movimentos_contabilidade
            // 
            visualizar_movimentos_contabilidade.Location = new Point(559, 16);
            visualizar_movimentos_contabilidade.Name = "visualizar_movimentos_contabilidade";
            visualizar_movimentos_contabilidade.Size = new Size(94, 29);
            visualizar_movimentos_contabilidade.TabIndex = 10;
            visualizar_movimentos_contabilidade.Text = "Visualizar";
            visualizar_movimentos_contabilidade.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(349, 60);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(351, 255);
            richTextBox3.TabIndex = 9;
            richTextBox3.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(349, 18);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 8;
            label10.Text = "Movimentos Contabilisticos";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(26, 250);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 7;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // data_contabilidade
            // 
            data_contabilidade.AutoSize = true;
            data_contabilidade.Location = new Point(27, 222);
            data_contabilidade.Name = "data_contabilidade";
            data_contabilidade.Size = new Size(41, 20);
            data_contabilidade.TabIndex = 6;
            data_contabilidade.Text = "Data";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(26, 162);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(148, 28);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // produto_contabilidade
            // 
            produto_contabilidade.AutoSize = true;
            produto_contabilidade.Location = new Point(26, 120);
            produto_contabilidade.Name = "produto_contabilidade";
            produto_contabilidade.Size = new Size(62, 20);
            produto_contabilidade.TabIndex = 4;
            produto_contabilidade.Text = "Produto";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(82, 30);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 43);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 2;
            label9.Text = "Valor";
            // 
            // Submeter_contabilidade
            // 
            Submeter_contabilidade.Location = new Point(26, 297);
            Submeter_contabilidade.Name = "Submeter_contabilidade";
            Submeter_contabilidade.Size = new Size(94, 29);
            Submeter_contabilidade.TabIndex = 1;
            Submeter_contabilidade.Text = "Submeter";
            Submeter_contabilidade.UseVisualStyleBackColor = true;
            Submeter_contabilidade.Click += button3_Click;
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
            recursoshumanos.BackColor = SystemColors.Control;
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
            recursoshumanos.Location = new Point(22, 57);
            recursoshumanos.Name = "recursoshumanos";
            recursoshumanos.Size = new Size(1346, 632);
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
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(38, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            armazem.BackColor = SystemColors.Control;
            armazem.Controls.Add(submeter_dados);
            armazem.Controls.Add(data_de_criaçao);
            armazem.Controls.Add(data);
            armazem.Controls.Add(richTextBox7);
            armazem.Controls.Add(label13);
            armazem.Controls.Add(richTextBox6);
            armazem.Controls.Add(label12);
            armazem.Controls.Add(richTextBox5);
            armazem.Controls.Add(marca_do_produto);
            armazem.Controls.Add(richTextBox4);
            armazem.Controls.Add(label11);
            armazem.Controls.Add(label3);
            armazem.ForeColor = SystemColors.ActiveCaptionText;
            armazem.Location = new Point(22, 57);
            armazem.Name = "armazem";
            armazem.Size = new Size(1363, 632);
            armazem.TabIndex = 3;
            armazem.Paint += panel1_Paint;
            // 
            // submeter_dados
            // 
            submeter_dados.Location = new Point(436, 286);
            submeter_dados.Name = "submeter_dados";
            submeter_dados.Size = new Size(94, 29);
            submeter_dados.TabIndex = 11;
            submeter_dados.Text = "submeter";
            submeter_dados.UseVisualStyleBackColor = true;
            submeter_dados.Click += submeter_dados_Click;
            // 
            // data_de_criaçao
            // 
            data_de_criaçao.Location = new Point(436, 205);
            data_de_criaçao.Name = "data_de_criaçao";
            data_de_criaçao.Size = new Size(250, 27);
            data_de_criaçao.TabIndex = 10;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Location = new Point(436, 167);
            data.Name = "data";
            data.Size = new Size(41, 20);
            data.TabIndex = 9;
            data.Text = "Data";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(436, 117);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(45, 34);
            richTextBox7.TabIndex = 8;
            richTextBox7.Text = "";
            richTextBox7.TextChanged += richTextBox7_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(422, 74);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 7;
            label13.Text = "Quantidade";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(18, 292);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(247, 31);
            richTextBox6.TabIndex = 6;
            richTextBox6.Text = "";
            richTextBox6.TextChanged += richTextBox6_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 254);
            label12.Name = "label12";
            label12.Size = new Size(121, 20);
            label12.TabIndex = 5;
            label12.Text = "Numero de Serie";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(20, 207);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(248, 30);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // marca_do_produto
            // 
            marca_do_produto.AutoSize = true;
            marca_do_produto.Location = new Point(20, 167);
            marca_do_produto.Name = "marca_do_produto";
            marca_do_produto.Size = new Size(50, 20);
            marca_do_produto.TabIndex = 3;
            marca_do_produto.Text = "Marca";
            marca_do_produto.Click += label12_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(20, 118);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(245, 34);
            richTextBox4.TabIndex = 2;
            richTextBox4.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 77);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 1;
            label11.Text = "Nome do Produto";
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
            ClientSize = new Size(1397, 747);
            Controls.Add(menuStrip1);
            Controls.Add(armazem);
            Controls.Add(recursoshumanos);
            Controls.Add(contabilidade);
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
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button Submeter_contabilidade;
        public TextBox textBox1;
        private Label label9;
        private Label produto_contabilidade;
        private Label data_contabilidade;
        private Button visualizar_movimentos_contabilidade;
        private RichTextBox richTextBox3;
        private Label label10;
        private Label marca_do_produto;
        private Label label11;
        private DateTimePicker dateTimePicker4;
        private Label data;
        private Label label13;
        private Label label12;
        private Button submeter_dados;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
        public RichTextBox richTextBox2;
        public RichTextBox richTextBox1;
        public DateTimePicker dateTimePicker3;
        public RichTextBox richTextBox4;
        public RichTextBox richTextBox5;
        public RichTextBox richTextBox6;
        public RichTextBox richTextBox7;
        public DateTimePicker data_de_criaçao;
        public TextBox textBox2;
    }
}
