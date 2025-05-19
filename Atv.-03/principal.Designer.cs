namespace Atv._03
{
    partial class CadastroLivros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripDataHora = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tspMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCrtlLista = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAutorLivro = new System.Windows.Forms.Label();
            this.dtpDataLanc = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.lblDataLanc = new System.Windows.Forms.Label();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCarregarCapa = new System.Windows.Forms.Button();
            this.btnLimparCapa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pctBoxCapa = new System.Windows.Forms.PictureBox();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioTerror = new System.Windows.Forms.RadioButton();
            this.radioFantasia = new System.Windows.Forms.RadioButton();
            this.radioRomance = new System.Windows.Forms.RadioButton();
            this.groupBoxGeneros = new System.Windows.Forms.GroupBox();
            this.radioMedieval = new System.Windows.Forms.RadioButton();
            this.radioBiografia = new System.Windows.Forms.RadioButton();
            this.radioPoesia = new System.Windows.Forms.RadioButton();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonMaior18 = new System.Windows.Forms.RadioButton();
            this.radioButtonLivre = new System.Windows.Forms.RadioButton();
            this.groupBoxClassificacao = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.statusStripDataHora.SuspendLayout();
            this.tabCrtlLista.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCapa)).BeginInit();
            this.groupBoxGeneros.SuspendLayout();
            this.groupBoxClassificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // statusStripDataHora
            // 
            this.statusStripDataHora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMensagem,
            this.tspData,
            this.tspHora});
            this.statusStripDataHora.Location = new System.Drawing.Point(0, 428);
            this.statusStripDataHora.Name = "statusStripDataHora";
            this.statusStripDataHora.Size = new System.Drawing.Size(800, 22);
            this.statusStripDataHora.TabIndex = 2;
            this.statusStripDataHora.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tspMensagem
            // 
            this.tspMensagem.Name = "tspMensagem";
            this.tspMensagem.Size = new System.Drawing.Size(189, 17);
            this.tspMensagem.Text = "Seja bem-vindo ao Menu Principal";
            // 
            // tspData
            // 
            this.tspData.Name = "tspData";
            this.tspData.Size = new System.Drawing.Size(31, 17);
            this.tspData.Text = "Data";
            // 
            // tspHora
            // 
            this.tspHora.Name = "tspHora";
            this.tspHora.Size = new System.Drawing.Size(33, 17);
            this.tspHora.Text = "Hora";
            // 
            // tabCrtlLista
            // 
            this.tabCrtlLista.Controls.Add(this.tabPageCadastrar);
            this.tabCrtlLista.Controls.Add(this.tabPageLista);
            this.tabCrtlLista.Location = new System.Drawing.Point(0, 51);
            this.tabCrtlLista.Name = "tabCrtlLista";
            this.tabCrtlLista.SelectedIndex = 0;
            this.tabCrtlLista.Size = new System.Drawing.Size(706, 374);
            this.tabCrtlLista.TabIndex = 3;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.groupBoxClassificacao);
            this.tabPageCadastrar.Controls.Add(this.groupBoxGeneros);
            this.tabPageCadastrar.Controls.Add(this.btnLimparCapa);
            this.tabPageCadastrar.Controls.Add(this.btnCarregarCapa);
            this.tabPageCadastrar.Controls.Add(this.pctBoxCapa);
            this.tabPageCadastrar.Controls.Add(this.btnLimpar);
            this.tabPageCadastrar.Controls.Add(this.btnCadastrar);
            this.tabPageCadastrar.Controls.Add(this.lblDataLanc);
            this.tabPageCadastrar.Controls.Add(this.txtBoxAutor);
            this.tabPageCadastrar.Controls.Add(this.txtBoxNome);
            this.tabPageCadastrar.Controls.Add(this.dtpDataLanc);
            this.tabPageCadastrar.Controls.Add(this.lblAutorLivro);
            this.tabPageCadastrar.Controls.Add(this.lblNomeLivro);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(698, 348);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            this.tabPageCadastrar.Click += new System.EventHandler(this.tabPageCadastrar_Click);
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.dataGridViewLista);
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(698, 348);
            this.tabPageLista.TabIndex = 1;
            this.tabPageLista.Text = "Lista de Cadastros";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Location = new System.Drawing.Point(21, 25);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeLivro.TabIndex = 0;
            this.lblNomeLivro.Text = "Nome:";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // lblAutorLivro
            // 
            this.lblAutorLivro.AutoSize = true;
            this.lblAutorLivro.Location = new System.Drawing.Point(25, 82);
            this.lblAutorLivro.Name = "lblAutorLivro";
            this.lblAutorLivro.Size = new System.Drawing.Size(35, 13);
            this.lblAutorLivro.TabIndex = 1;
            this.lblAutorLivro.Text = "Autor:";
            this.lblAutorLivro.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // dtpDataLanc
            // 
            this.dtpDataLanc.CustomFormat = "";
            this.dtpDataLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLanc.Location = new System.Drawing.Point(28, 159);
            this.dtpDataLanc.Name = "dtpDataLanc";
            this.dtpDataLanc.Size = new System.Drawing.Size(98, 20);
            this.dtpDataLanc.TabIndex = 2;
            this.dtpDataLanc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(24, 41);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(306, 20);
            this.txtBoxNome.TabIndex = 8;
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Location = new System.Drawing.Point(24, 98);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(306, 20);
            this.txtBoxAutor.TabIndex = 9;
            this.txtBoxAutor.TextChanged += new System.EventHandler(this.txtBoxCPF_TextChanged);
            // 
            // lblDataLanc
            // 
            this.lblDataLanc.AutoSize = true;
            this.lblDataLanc.Location = new System.Drawing.Point(25, 134);
            this.lblDataLanc.Name = "lblDataLanc";
            this.lblDataLanc.Size = new System.Drawing.Size(106, 13);
            this.lblDataLanc.TabIndex = 10;
            this.lblDataLanc.Text = "Data de lançamento:";
            this.lblDataLanc.Click += new System.EventHandler(this.lblDataNasc_Click_1);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.colunaAutor,
            this.colunaDataLanc,
            this.colunaGenero,
            this.colunaClass});
            this.dataGridViewLista.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(688, 336);
            this.dataGridViewLista.TabIndex = 0;
            this.dataGridViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(524, 310);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(605, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCarregarCapa
            // 
            this.btnCarregarCapa.Location = new System.Drawing.Point(389, 195);
            this.btnCarregarCapa.Name = "btnCarregarCapa";
            this.btnCarregarCapa.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarCapa.TabIndex = 14;
            this.btnCarregarCapa.Text = "Carregar";
            this.btnCarregarCapa.UseVisualStyleBackColor = true;
            this.btnCarregarCapa.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnLimparCapa
            // 
            this.btnLimparCapa.Location = new System.Drawing.Point(470, 195);
            this.btnLimparCapa.Name = "btnLimparCapa";
            this.btnLimparCapa.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCapa.TabIndex = 15;
            this.btnLimparCapa.Text = "Limpar";
            this.btnLimparCapa.UseVisualStyleBackColor = true;
            this.btnLimparCapa.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pctBoxCapa
            // 
            this.pctBoxCapa.BackgroundImage = global::Atv._03.Properties.Resources.livroIcon;
            this.pctBoxCapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCapa.Location = new System.Drawing.Point(401, 25);
            this.pctBoxCapa.Name = "pctBoxCapa";
            this.pctBoxCapa.Size = new System.Drawing.Size(134, 164);
            this.pctBoxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxCapa.TabIndex = 13;
            this.pctBoxCapa.TabStop = false;
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = global::Atv._03.Properties.Resources.calculadoraIcon;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Image = global::Atv._03.Properties.Resources.notasIcon;
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // radioTerror
            // 
            this.radioTerror.AutoSize = true;
            this.radioTerror.Location = new System.Drawing.Point(25, 53);
            this.radioTerror.Name = "radioTerror";
            this.radioTerror.Size = new System.Drawing.Size(53, 17);
            this.radioTerror.TabIndex = 6;
            this.radioTerror.TabStop = true;
            this.radioTerror.Text = "Terror";
            this.radioTerror.UseVisualStyleBackColor = true;
            // 
            // radioFantasia
            // 
            this.radioFantasia.AutoSize = true;
            this.radioFantasia.Location = new System.Drawing.Point(25, 30);
            this.radioFantasia.Name = "radioFantasia";
            this.radioFantasia.Size = new System.Drawing.Size(65, 17);
            this.radioFantasia.TabIndex = 5;
            this.radioFantasia.TabStop = true;
            this.radioFantasia.Text = "Fantasia";
            this.radioFantasia.UseVisualStyleBackColor = true;
            // 
            // radioRomance
            // 
            this.radioRomance.AutoSize = true;
            this.radioRomance.Location = new System.Drawing.Point(25, 76);
            this.radioRomance.Name = "radioRomance";
            this.radioRomance.Size = new System.Drawing.Size(71, 17);
            this.radioRomance.TabIndex = 16;
            this.radioRomance.TabStop = true;
            this.radioRomance.Text = "Romance";
            this.radioRomance.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneros
            // 
            this.groupBoxGeneros.Controls.Add(this.radioPoesia);
            this.groupBoxGeneros.Controls.Add(this.radioBiografia);
            this.groupBoxGeneros.Controls.Add(this.radioMedieval);
            this.groupBoxGeneros.Controls.Add(this.radioFantasia);
            this.groupBoxGeneros.Controls.Add(this.radioRomance);
            this.groupBoxGeneros.Controls.Add(this.radioTerror);
            this.groupBoxGeneros.Location = new System.Drawing.Point(24, 195);
            this.groupBoxGeneros.Name = "groupBoxGeneros";
            this.groupBoxGeneros.Size = new System.Drawing.Size(237, 112);
            this.groupBoxGeneros.TabIndex = 17;
            this.groupBoxGeneros.TabStop = false;
            this.groupBoxGeneros.Text = "Gênero";
            // 
            // radioMedieval
            // 
            this.radioMedieval.AutoSize = true;
            this.radioMedieval.Location = new System.Drawing.Point(128, 30);
            this.radioMedieval.Name = "radioMedieval";
            this.radioMedieval.Size = new System.Drawing.Size(68, 17);
            this.radioMedieval.TabIndex = 17;
            this.radioMedieval.TabStop = true;
            this.radioMedieval.Text = "Medieval";
            this.radioMedieval.UseVisualStyleBackColor = true;
            // 
            // radioBiografia
            // 
            this.radioBiografia.AutoSize = true;
            this.radioBiografia.Location = new System.Drawing.Point(128, 53);
            this.radioBiografia.Name = "radioBiografia";
            this.radioBiografia.Size = new System.Drawing.Size(66, 17);
            this.radioBiografia.TabIndex = 18;
            this.radioBiografia.TabStop = true;
            this.radioBiografia.Text = "Biografia";
            this.radioBiografia.UseVisualStyleBackColor = true;
            // 
            // radioPoesia
            // 
            this.radioPoesia.AutoSize = true;
            this.radioPoesia.Location = new System.Drawing.Point(128, 76);
            this.radioPoesia.Name = "radioPoesia";
            this.radioPoesia.Size = new System.Drawing.Size(57, 17);
            this.radioPoesia.TabIndex = 19;
            this.radioPoesia.TabStop = true;
            this.radioPoesia.Text = "Poesia";
            this.radioPoesia.UseVisualStyleBackColor = true;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            // 
            // colunaAutor
            // 
            this.colunaAutor.HeaderText = "Autor";
            this.colunaAutor.Name = "colunaAutor";
            this.colunaAutor.ReadOnly = true;
            // 
            // colunaDataLanc
            // 
            this.colunaDataLanc.HeaderText = "Data de lançamento";
            this.colunaDataLanc.Name = "colunaDataLanc";
            this.colunaDataLanc.ReadOnly = true;
            // 
            // colunaGenero
            // 
            this.colunaGenero.HeaderText = "Gênero";
            this.colunaGenero.Name = "colunaGenero";
            this.colunaGenero.ReadOnly = true;
            // 
            // colunaClass
            // 
            this.colunaClass.HeaderText = "Classificação";
            this.colunaClass.Name = "colunaClass";
            this.colunaClass.ReadOnly = true;
            // 
            // radioButtonMaior18
            // 
            this.radioButtonMaior18.AutoSize = true;
            this.radioButtonMaior18.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMaior18.Name = "radioButtonMaior18";
            this.radioButtonMaior18.Size = new System.Drawing.Size(43, 17);
            this.radioButtonMaior18.TabIndex = 20;
            this.radioButtonMaior18.TabStop = true;
            this.radioButtonMaior18.Text = "+18";
            this.radioButtonMaior18.UseVisualStyleBackColor = true;
            // 
            // radioButtonLivre
            // 
            this.radioButtonLivre.AutoSize = true;
            this.radioButtonLivre.Location = new System.Drawing.Point(55, 19);
            this.radioButtonLivre.Name = "radioButtonLivre";
            this.radioButtonLivre.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLivre.TabIndex = 21;
            this.radioButtonLivre.TabStop = true;
            this.radioButtonLivre.Text = "Livre";
            this.radioButtonLivre.UseVisualStyleBackColor = true;
            // 
            // groupBoxClassificacao
            // 
            this.groupBoxClassificacao.Controls.Add(this.radioButtonLivre);
            this.groupBoxClassificacao.Controls.Add(this.radioButtonMaior18);
            this.groupBoxClassificacao.Location = new System.Drawing.Point(152, 134);
            this.groupBoxClassificacao.Name = "groupBoxClassificacao";
            this.groupBoxClassificacao.Size = new System.Drawing.Size(109, 45);
            this.groupBoxClassificacao.TabIndex = 22;
            this.groupBoxClassificacao.TabStop = false;
            this.groupBoxClassificacao.Text = "Classificação";
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCrtlLista);
            this.Controls.Add(this.statusStripDataHora);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroLivros";
            this.Text = "&Aplicativos";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStripDataHora.ResumeLayout(false);
            this.statusStripDataHora.PerformLayout();
            this.tabCrtlLista.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCapa)).EndInit();
            this.groupBoxGeneros.ResumeLayout(false);
            this.groupBoxGeneros.PerformLayout();
            this.groupBoxClassificacao.ResumeLayout(false);
            this.groupBoxClassificacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tspMensagem;
        private System.Windows.Forms.ToolStripStatusLabel tspData;
        private System.Windows.Forms.ToolStripStatusLabel tspHora;
        private System.Windows.Forms.TabControl tabCrtlLista;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDataLanc;
        private System.Windows.Forms.Label lblAutorLivro;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblDataLanc;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.PictureBox pctBoxCapa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimparCapa;
        private System.Windows.Forms.Button btnCarregarCapa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioTerror;
        private System.Windows.Forms.RadioButton radioFantasia;
        private System.Windows.Forms.RadioButton radioRomance;
        private System.Windows.Forms.GroupBox groupBoxGeneros;
        private System.Windows.Forms.RadioButton radioPoesia;
        private System.Windows.Forms.RadioButton radioBiografia;
        private System.Windows.Forms.RadioButton radioMedieval;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataLanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaClass;
        private System.Windows.Forms.RadioButton radioButtonLivre;
        private System.Windows.Forms.RadioButton radioButtonMaior18;
        private System.Windows.Forms.GroupBox groupBoxClassificacao;
    }
}

