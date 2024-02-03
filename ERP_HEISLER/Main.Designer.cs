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
            crm = new Panel();
            recursoshumanos = new Panel();
            label23 = new Label();
            checkedListBox2 = new CheckedListBox();
            label22 = new Label();
            textBox7 = new TextBox();
            label21 = new Label();
            textBox6 = new TextBox();
            label20 = new Label();
            textBox5 = new TextBox();
            label19 = new Label();
            comboBox1 = new ComboBox();
            label18 = new Label();
            checkedListBox1 = new CheckedListBox();
            label17 = new Label();
            label16 = new Label();
            textBox4 = new TextBox();
            label15 = new Label();
            textBox3 = new TextBox();
            label14 = new Label();
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
            button3 = new Button();
            Stock = new Label();
            richTextBox8 = new RichTextBox();
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
            crm.SuspendLayout();
            recursoshumanos.SuspendLayout();
            armazem.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DimGray;
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
            contabilidadeToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            contabilidadeToolStripMenuItem.Size = new Size(117, 24);
            contabilidadeToolStripMenuItem.Text = "Contabilidade";
            contabilidadeToolStripMenuItem.Click += contabilidadeToolStripMenuItem_Click;
            // 
            // recursosHumanosToolStripMenuItem
            // 
            recursosHumanosToolStripMenuItem.BackColor = Color.DimGray;
            recursosHumanosToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            recursosHumanosToolStripMenuItem.Size = new Size(148, 24);
            recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            recursosHumanosToolStripMenuItem.Click += recursosHumanosToolStripMenuItem_Click;
            // 
            // armazemToolStripMenuItem
            // 
            armazemToolStripMenuItem.BackColor = Color.DimGray;
            armazemToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
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
            contabilidade.Controls.Add(dateTimePicker3);
            contabilidade.Controls.Add(data_contabilidade);
            contabilidade.Controls.Add(richTextBox2);
            contabilidade.Controls.Add(produto_contabilidade);
            contabilidade.Controls.Add(richTextBox1);
            contabilidade.Controls.Add(label9);
            contabilidade.Controls.Add(Submeter_contabilidade);
            contabilidade.Controls.Add(label1);
            contabilidade.Controls.Add(crm);
            contabilidade.Dock = DockStyle.Fill;
            contabilidade.Location = new Point(0, 0);
            contabilidade.Name = "contabilidade";
            contabilidade.Size = new Size(1397, 747);
            contabilidade.TabIndex = 1;
            contabilidade.Paint += contabilidade_Paint;
            // 
            // visualizar_movimentos_contabilidade
            // 
            visualizar_movimentos_contabilidade.Location = new Point(568, 62);
            visualizar_movimentos_contabilidade.Name = "visualizar_movimentos_contabilidade";
            visualizar_movimentos_contabilidade.Size = new Size(94, 29);
            visualizar_movimentos_contabilidade.TabIndex = 10;
            visualizar_movimentos_contabilidade.Text = "Visualizar";
            visualizar_movimentos_contabilidade.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(356, 125);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(958, 478);
            richTextBox3.TabIndex = 9;
            richTextBox3.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(338, 68);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 8;
            label10.Text = "Movimentos Contabilisticos";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(39, 429);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 7;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // data_contabilidade
            // 
            data_contabilidade.AutoSize = true;
            data_contabilidade.Location = new Point(40, 401);
            data_contabilidade.Name = "data_contabilidade";
            data_contabilidade.Size = new Size(41, 20);
            data_contabilidade.TabIndex = 6;
            data_contabilidade.Text = "Data";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(39, 341);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(148, 28);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // produto_contabilidade
            // 
            produto_contabilidade.AutoSize = true;
            produto_contabilidade.Location = new Point(39, 299);
            produto_contabilidade.Name = "produto_contabilidade";
            produto_contabilidade.Size = new Size(62, 20);
            produto_contabilidade.TabIndex = 4;
            produto_contabilidade.Text = "Produto";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 246);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(82, 30);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 222);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 2;
            label9.Text = "Valor";
            // 
            // Submeter_contabilidade
            // 
            Submeter_contabilidade.Location = new Point(39, 476);
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
            label1.Location = new Point(27, 89);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Contabilidade";
            label1.Click += label1_Click;
            // 
            // crm
            // 
            crm.Controls.Add(label10);
            crm.Dock = DockStyle.Fill;
            crm.Location = new Point(0, 0);
            crm.Name = "crm";
            crm.Size = new Size(1397, 747);
            crm.TabIndex = 11;
            crm.Paint += crm_Paint;
            // 
            // recursoshumanos
            // 
            recursoshumanos.BackColor = SystemColors.Control;
            recursoshumanos.Controls.Add(label23);
            recursoshumanos.Controls.Add(checkedListBox2);
            recursoshumanos.Controls.Add(label22);
            recursoshumanos.Controls.Add(textBox7);
            recursoshumanos.Controls.Add(label21);
            recursoshumanos.Controls.Add(textBox6);
            recursoshumanos.Controls.Add(label20);
            recursoshumanos.Controls.Add(textBox5);
            recursoshumanos.Controls.Add(label19);
            recursoshumanos.Controls.Add(comboBox1);
            recursoshumanos.Controls.Add(label18);
            recursoshumanos.Controls.Add(checkedListBox1);
            recursoshumanos.Controls.Add(label17);
            recursoshumanos.Controls.Add(label16);
            recursoshumanos.Controls.Add(textBox4);
            recursoshumanos.Controls.Add(label15);
            recursoshumanos.Controls.Add(textBox3);
            recursoshumanos.Controls.Add(label14);
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
            recursoshumanos.Dock = DockStyle.Fill;
            recursoshumanos.Location = new Point(0, 0);
            recursoshumanos.Name = "recursoshumanos";
            recursoshumanos.Size = new Size(1397, 747);
            recursoshumanos.TabIndex = 2;
            recursoshumanos.Paint += recursoshumanos_Paint;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(388, 408);
            label23.Name = "label23";
            label23.Size = new Size(58, 20);
            label23.TabIndex = 30;
            label23.Text = "label23";
            label23.Click += label23_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = SystemColors.Menu;
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Casado", "Solteiro", "Divorciado" });
            checkedListBox2.Location = new Point(512, 263);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 66);
            checkedListBox2.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(397, 289);
            label22.Name = "label22";
            label22.Size = new Size(86, 20);
            label22.TabIndex = 28;
            label22.Text = "Estado Civil";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(395, 194);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(234, 27);
            textBox7.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(395, 165);
            label21.Name = "label21";
            label21.Size = new Size(66, 20);
            label21.TabIndex = 26;
            label21.Text = "Telefone";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(395, 117);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 27);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(395, 89);
            label20.Name = "label20";
            label20.Size = new Size(106, 20);
            label20.TabIndex = 24;
            label20.Text = "Nacionalidade";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(20, 351);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 27);
            textBox5.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(24, 329);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 22;
            label19.Text = "Email";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Luanda", "Huambo", "Lobito", "Cabinda", "Benguela", "Namibe", "Bie" });
            comboBox1.Location = new Point(27, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Provincias";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 237);
            label18.Name = "label18";
            label18.Size = new Size(82, 20);
            label18.TabIndex = 20;
            label18.Text = "Localidade";
            // 
            // checkedListBox1
            // 
            checkedListBox1.AllowDrop = true;
            checkedListBox1.BackColor = SystemColors.Menu;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Masculino", "Feminino" });
            checkedListBox1.Location = new Point(108, 170);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(113, 44);
            checkedListBox1.TabIndex = 19;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(26, 187);
            label17.Name = "label17";
            label17.Size = new Size(57, 20);
            label17.TabIndex = 18;
            label17.Text = "Genero";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(993, 477);
            label16.Name = "label16";
            label16.Size = new Size(178, 20);
            label16.TabIndex = 17;
            label16.Text = "ERRO NOME DUPLICADO";
            label16.Visible = false;
            label16.Click += label16_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(955, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 27);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(956, 202);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 15;
            label15.Text = "NIF";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 449);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 426);
            label14.Name = "label14";
            label14.Size = new Size(31, 20);
            label14.TabIndex = 13;
            label14.Text = "NIF";
            // 
            // button2
            // 
            button2.Location = new Point(956, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Submeter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 583);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Submeter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(956, 351);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(264, 27);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 531);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(956, 320);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 8;
            label8.Text = "Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 500);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 7;
            label7.Text = "Data de  Nascimento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(956, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(956, 97);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(956, 60);
            label5.Name = "label5";
            label5.Size = new Size(251, 31);
            label5.TabIndex = 3;
            label5.Text = "Funcionario Removidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(224, 49);
            label4.Name = "label4";
            label4.Size = new Size(253, 31);
            label4.TabIndex = 2;
            label4.Text = "Adicionar Funcionarios ";
            label4.Click += label4_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(20, 77);
            Nome.Name = "Nome";
            Nome.Size = new Size(120, 20);
            Nome.TabIndex = 1;
            Nome.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 28);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 0;
            label2.Text = "Recursos Humanos";
            label2.Click += label2_Click;
            // 
            // armazem
            // 
            armazem.BackColor = SystemColors.Control;
            armazem.Controls.Add(button3);
            armazem.Controls.Add(Stock);
            armazem.Controls.Add(richTextBox8);
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
            armazem.Dock = DockStyle.Fill;
            armazem.ForeColor = SystemColors.ActiveCaptionText;
            armazem.Location = new Point(0, 0);
            armazem.Name = "armazem";
            armazem.Size = new Size(1397, 747);
            armazem.TabIndex = 3;
            armazem.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(883, 54);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Visualizar stock ";
            button3.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(719, 10);
            Stock.Name = "Stock";
            Stock.Size = new Size(110, 20);
            Stock.TabIndex = 13;
            Stock.Text = "visualizar_stock";
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(692, 93);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(635, 545);
            richTextBox8.TabIndex = 12;
            richTextBox8.Text = "";
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
            label3.Location = new Point(26, 40);
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
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1397, 747);
            Controls.Add(menuStrip1);
            Controls.Add(contabilidade);
            Controls.Add(armazem);
            Controls.Add(recursoshumanos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main";
            Text = "HEISLER ERP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contabilidade.ResumeLayout(false);
            contabilidade.PerformLayout();
            crm.ResumeLayout(false);
            crm.PerformLayout();
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
        private Label Stock;
        private RichTextBox richTextBox8;
        private Button button3;
        private Label label14;
        public TextBox textBox3;
        public TextBox textBox4;
        private Label label15;
        public Label label16;
        private Label label17;
        public CheckedListBox checkedListBox1;
        private Label label18;
        public ComboBox comboBox1;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        public TextBox textBox6;
        public TextBox textBox5;
        public TextBox textBox7;
        public CheckedListBox checkedListBox2;
        public Label label23;
        private Button button1;
        private Panel crm;
    }
}
