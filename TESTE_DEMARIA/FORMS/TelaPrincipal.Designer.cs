namespace TESTE_DEMARIA.FORMS
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage CONEXÃO_BD;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btn_salvarconfig = new MaterialSkin.Controls.MaterialButton();
            this.campo_database = new MaterialSkin.Controls.MaterialTextBox2();
            this.campo_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.campo_username = new MaterialSkin.Controls.MaterialTextBox2();
            this.campo_port = new MaterialSkin.Controls.MaterialTextBox2();
            this.campo_host = new MaterialSkin.Controls.MaterialTextBox2();
            this.Btn_testar_conexao = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.HOME = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.Label_QuantidadeDeVendidos = new System.Windows.Forms.Label();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.Label_TotalDeClientesAtivos = new System.Windows.Forms.Label();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.Label_TotalDeItensEmEstoque = new System.Windows.Forms.Label();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Totaldevendas = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CLIENTES = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_ExcluirCliente = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.BTN_SalvarCliente = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.BTN_NovoCliente = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.BTN_BuscaClientes = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard16 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard17 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard18 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard19 = new MaterialSkin.Controls.MaterialCard();
            this.Text_buscaCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.ComboUF = new MaterialSkin.Controls.MaterialComboBox();
            this.TextLocalidade = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextBairro = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextComplemento = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextNomeCompleto = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelStatusCliente = new MaterialSkin.Controls.MaterialLabel();
            this.TextNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextTelefone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextCEP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextLogradouro = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.PRODUTOS = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_deletarProduto = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btn_SalvarProduto = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btn_NovoProduto = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btn_BuscaProduto = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard15 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.TextBuscaProduto = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.TextValor = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextProduto = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.LabelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.TextQuatidade = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.VENDAS = new System.Windows.Forms.TabPage();
            this.materialCard30 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listViewVendas = new System.Windows.Forms.ListView();
            this.materialCard22 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listViewPedidosEmAndamento = new System.Windows.Forms.ListView();
            this.materialCard21 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Finalizarpedido = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btn_novopedido = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard23 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard25 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard20 = new MaterialSkin.Controls.MaterialCard();
            this.textProdutoVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_RetirarSelecionados = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard33 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.textCPFVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.textValorVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard29 = new MaterialSkin.Controls.MaterialCard();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.btn_adicionarPedido = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard28 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.textNomeClienteVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.textQuantidadeVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_buscaClienteVenda = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard27 = new MaterialSkin.Controls.MaterialCard();
            this.TextBucarClienteVendas = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NumericoQuantidadeDesejada = new System.Windows.Forms.NumericUpDown();
            this.btn_buscaProdutoVenda = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard26 = new MaterialSkin.Controls.MaterialCard();
            this.TextBucarProdutoVendas = new MaterialSkin.Controls.MaterialTextBox2();
            this.RELATÓRIOS = new System.Windows.Forms.TabPage();
            this.materialCard32 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard31 = new MaterialSkin.Controls.MaterialCard();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.listViewOpcoesRelatorios = new System.Windows.Forms.ListView();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.Btn_GerarRelatorio = new MaterialSkin.Controls.MaterialButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            CONEXÃO_BD = new System.Windows.Forms.TabPage();
            CONEXÃO_BD.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.HOME.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.CLIENTES.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.materialCard16.SuspendLayout();
            this.materialCard17.SuspendLayout();
            this.materialCard18.SuspendLayout();
            this.materialCard19.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PRODUTOS.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.materialCard15.SuspendLayout();
            this.materialCard14.SuspendLayout();
            this.materialCard13.SuspendLayout();
            this.materialCard12.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.VENDAS.SuspendLayout();
            this.materialCard30.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.materialCard22.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.materialCard21.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.materialCard23.SuspendLayout();
            this.materialCard25.SuspendLayout();
            this.materialCard20.SuspendLayout();
            this.materialCard33.SuspendLayout();
            this.materialCard29.SuspendLayout();
            this.materialCard28.SuspendLayout();
            this.materialCard27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoQuantidadeDesejada)).BeginInit();
            this.materialCard26.SuspendLayout();
            this.RELATÓRIOS.SuspendLayout();
            this.materialCard31.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONEXÃO_BD
            // 
            CONEXÃO_BD.Controls.Add(this.btn_salvarconfig);
            CONEXÃO_BD.Controls.Add(this.campo_database);
            CONEXÃO_BD.Controls.Add(this.campo_password);
            CONEXÃO_BD.Controls.Add(this.campo_username);
            CONEXÃO_BD.Controls.Add(this.campo_port);
            CONEXÃO_BD.Controls.Add(this.campo_host);
            CONEXÃO_BD.Controls.Add(this.Btn_testar_conexao);
            CONEXÃO_BD.ImageKey = "CONFIG.png";
            CONEXÃO_BD.Location = new System.Drawing.Point(4, 39);
            CONEXÃO_BD.Name = "CONEXÃO_BD";
            CONEXÃO_BD.Size = new System.Drawing.Size(1587, 727);
            CONEXÃO_BD.TabIndex = 5;
            CONEXÃO_BD.Text = "CONEXÃO BD";
            CONEXÃO_BD.UseVisualStyleBackColor = true;
            // 
            // btn_salvarconfig
            // 
            this.btn_salvarconfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salvarconfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_salvarconfig.Depth = 0;
            this.btn_salvarconfig.HighEmphasis = true;
            this.btn_salvarconfig.Icon = null;
            this.btn_salvarconfig.Location = new System.Drawing.Point(660, 489);
            this.btn_salvarconfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_salvarconfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_salvarconfig.Name = "btn_salvarconfig";
            this.btn_salvarconfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_salvarconfig.Size = new System.Drawing.Size(133, 36);
            this.btn_salvarconfig.TabIndex = 6;
            this.btn_salvarconfig.Text = "Salvar Config";
            this.btn_salvarconfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_salvarconfig.UseAccentColor = false;
            this.btn_salvarconfig.UseVisualStyleBackColor = true;
            this.btn_salvarconfig.Click += new System.EventHandler(this.btn_salvarconfig_Click);
            // 
            // campo_database
            // 
            this.campo_database.AnimateReadOnly = false;
            this.campo_database.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campo_database.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campo_database.Depth = 0;
            this.campo_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campo_database.HideSelection = true;
            this.campo_database.Hint = "DATA BASE";
            this.campo_database.LeadingIcon = null;
            this.campo_database.Location = new System.Drawing.Point(690, 409);
            this.campo_database.MaxLength = 32767;
            this.campo_database.MouseState = MaterialSkin.MouseState.OUT;
            this.campo_database.Name = "campo_database";
            this.campo_database.PasswordChar = '\0';
            this.campo_database.PrefixSuffixText = null;
            this.campo_database.ReadOnly = false;
            this.campo_database.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campo_database.SelectedText = "";
            this.campo_database.SelectionLength = 0;
            this.campo_database.SelectionStart = 0;
            this.campo_database.ShortcutsEnabled = true;
            this.campo_database.Size = new System.Drawing.Size(250, 48);
            this.campo_database.TabIndex = 5;
            this.campo_database.TabStop = false;
            this.campo_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campo_database.TrailingIcon = null;
            this.campo_database.UseSystemPasswordChar = false;
            // 
            // campo_password
            // 
            this.campo_password.AnimateReadOnly = false;
            this.campo_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campo_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campo_password.Depth = 0;
            this.campo_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campo_password.HideSelection = true;
            this.campo_password.Hint = "PASSWORD";
            this.campo_password.LeadingIcon = null;
            this.campo_password.Location = new System.Drawing.Point(690, 322);
            this.campo_password.MaxLength = 32767;
            this.campo_password.MouseState = MaterialSkin.MouseState.OUT;
            this.campo_password.Name = "campo_password";
            this.campo_password.PasswordChar = '●';
            this.campo_password.PrefixSuffixText = null;
            this.campo_password.ReadOnly = false;
            this.campo_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campo_password.SelectedText = "";
            this.campo_password.SelectionLength = 0;
            this.campo_password.SelectionStart = 0;
            this.campo_password.ShortcutsEnabled = true;
            this.campo_password.Size = new System.Drawing.Size(250, 48);
            this.campo_password.TabIndex = 4;
            this.campo_password.TabStop = false;
            this.campo_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campo_password.TrailingIcon = null;
            this.campo_password.UseSystemPasswordChar = true;
            // 
            // campo_username
            // 
            this.campo_username.AnimateReadOnly = false;
            this.campo_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campo_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campo_username.Depth = 0;
            this.campo_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campo_username.HideSelection = true;
            this.campo_username.Hint = "USER NAME";
            this.campo_username.LeadingIcon = null;
            this.campo_username.Location = new System.Drawing.Point(690, 241);
            this.campo_username.MaxLength = 32767;
            this.campo_username.MouseState = MaterialSkin.MouseState.OUT;
            this.campo_username.Name = "campo_username";
            this.campo_username.PasswordChar = '\0';
            this.campo_username.PrefixSuffixText = null;
            this.campo_username.ReadOnly = false;
            this.campo_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campo_username.SelectedText = "";
            this.campo_username.SelectionLength = 0;
            this.campo_username.SelectionStart = 0;
            this.campo_username.ShortcutsEnabled = true;
            this.campo_username.Size = new System.Drawing.Size(250, 48);
            this.campo_username.TabIndex = 3;
            this.campo_username.TabStop = false;
            this.campo_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campo_username.TrailingIcon = null;
            this.campo_username.UseSystemPasswordChar = false;
            // 
            // campo_port
            // 
            this.campo_port.AnimateReadOnly = false;
            this.campo_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campo_port.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campo_port.Depth = 0;
            this.campo_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campo_port.HideSelection = true;
            this.campo_port.Hint = "PORT";
            this.campo_port.LeadingIcon = null;
            this.campo_port.Location = new System.Drawing.Point(690, 162);
            this.campo_port.MaxLength = 32767;
            this.campo_port.MouseState = MaterialSkin.MouseState.OUT;
            this.campo_port.Name = "campo_port";
            this.campo_port.PasswordChar = '\0';
            this.campo_port.PrefixSuffixText = null;
            this.campo_port.ReadOnly = false;
            this.campo_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campo_port.SelectedText = "";
            this.campo_port.SelectionLength = 0;
            this.campo_port.SelectionStart = 0;
            this.campo_port.ShortcutsEnabled = true;
            this.campo_port.Size = new System.Drawing.Size(250, 48);
            this.campo_port.TabIndex = 2;
            this.campo_port.TabStop = false;
            this.campo_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campo_port.TrailingIcon = null;
            this.campo_port.UseSystemPasswordChar = false;
            // 
            // campo_host
            // 
            this.campo_host.AnimateReadOnly = false;
            this.campo_host.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campo_host.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campo_host.Depth = 0;
            this.campo_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campo_host.HideSelection = true;
            this.campo_host.Hint = "HOST";
            this.campo_host.LeadingIcon = null;
            this.campo_host.Location = new System.Drawing.Point(690, 89);
            this.campo_host.MaxLength = 32767;
            this.campo_host.MouseState = MaterialSkin.MouseState.OUT;
            this.campo_host.Name = "campo_host";
            this.campo_host.PasswordChar = '\0';
            this.campo_host.PrefixSuffixText = null;
            this.campo_host.ReadOnly = false;
            this.campo_host.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campo_host.SelectedText = "";
            this.campo_host.SelectionLength = 0;
            this.campo_host.SelectionStart = 0;
            this.campo_host.ShortcutsEnabled = true;
            this.campo_host.Size = new System.Drawing.Size(250, 48);
            this.campo_host.TabIndex = 1;
            this.campo_host.TabStop = false;
            this.campo_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campo_host.TrailingIcon = null;
            this.campo_host.UseSystemPasswordChar = false;
            // 
            // Btn_testar_conexao
            // 
            this.Btn_testar_conexao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_testar_conexao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_testar_conexao.Depth = 0;
            this.Btn_testar_conexao.HighEmphasis = true;
            this.Btn_testar_conexao.Icon = null;
            this.Btn_testar_conexao.Location = new System.Drawing.Point(838, 489);
            this.Btn_testar_conexao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_testar_conexao.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_testar_conexao.Name = "Btn_testar_conexao";
            this.Btn_testar_conexao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_testar_conexao.Size = new System.Drawing.Size(147, 36);
            this.Btn_testar_conexao.TabIndex = 0;
            this.Btn_testar_conexao.Text = "Testar conexão";
            this.Btn_testar_conexao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_testar_conexao.UseAccentColor = false;
            this.Btn_testar_conexao.UseVisualStyleBackColor = true;
            this.Btn_testar_conexao.Click += new System.EventHandler(this.Btn_testar_conexao_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HOME);
            this.materialTabControl1.Controls.Add(this.CLIENTES);
            this.materialTabControl1.Controls.Add(this.PRODUTOS);
            this.materialTabControl1.Controls.Add(this.VENDAS);
            this.materialTabControl1.Controls.Add(this.RELATÓRIOS);
            this.materialTabControl1.Controls.Add(CONEXÃO_BD);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1595, 770);
            this.materialTabControl1.TabIndex = 0;
            // 
            // HOME
            // 
            this.HOME.Controls.Add(this.materialCard1);
            this.HOME.ImageKey = "HOME.png";
            this.HOME.Location = new System.Drawing.Point(4, 39);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(1587, 727);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "   HOME";
            this.HOME.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialFloatingActionButton1);
            this.materialCard1.Controls.Add(this.materialCard11);
            this.materialCard1.Controls.Add(this.materialCard10);
            this.materialCard1.Controls.Add(this.materialCard9);
            this.materialCard1.Controls.Add(this.materialCard8);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 153);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1553, 430);
            this.materialCard1.TabIndex = 0;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Icon")));
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(1431, 357);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 4;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.materialLabel16);
            this.materialCard11.Controls.Add(this.Label_QuantidadeDeVendidos);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(1156, 100);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(331, 224);
            this.materialCard11.TabIndex = 3;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(56, 34);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(219, 19);
            this.materialLabel16.TabIndex = 4;
            this.materialLabel16.Text = "TOTAL PRODUTOS VENDIDOS";
            // 
            // Label_QuantidadeDeVendidos
            // 
            this.Label_QuantidadeDeVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_QuantidadeDeVendidos.Location = new System.Drawing.Point(0, 49);
            this.Label_QuantidadeDeVendidos.Name = "Label_QuantidadeDeVendidos";
            this.Label_QuantidadeDeVendidos.Size = new System.Drawing.Size(331, 111);
            this.Label_QuantidadeDeVendidos.TabIndex = 3;
            this.Label_QuantidadeDeVendidos.Text = "...";
            this.Label_QuantidadeDeVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.materialLabel15);
            this.materialCard10.Controls.Add(this.Label_TotalDeClientesAtivos);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(784, 100);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(331, 224);
            this.materialCard10.TabIndex = 2;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(34, 34);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(257, 19);
            this.materialLabel15.TabIndex = 3;
            this.materialLabel15.Text = "QUANTIDADE DE CLIENTES ATIVOS";
            // 
            // Label_TotalDeClientesAtivos
            // 
            this.Label_TotalDeClientesAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDeClientesAtivos.Location = new System.Drawing.Point(0, 49);
            this.Label_TotalDeClientesAtivos.Name = "Label_TotalDeClientesAtivos";
            this.Label_TotalDeClientesAtivos.Size = new System.Drawing.Size(331, 111);
            this.Label_TotalDeClientesAtivos.TabIndex = 2;
            this.Label_TotalDeClientesAtivos.Text = "...";
            this.Label_TotalDeClientesAtivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.materialLabel14);
            this.materialCard9.Controls.Add(this.Label_TotalDeItensEmEstoque);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(414, 100);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(331, 224);
            this.materialCard9.TabIndex = 2;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(28, 34);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(271, 19);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "QUANTIDADE DE ITENS EM ESTOQUE";
            // 
            // Label_TotalDeItensEmEstoque
            // 
            this.Label_TotalDeItensEmEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDeItensEmEstoque.Location = new System.Drawing.Point(0, 49);
            this.Label_TotalDeItensEmEstoque.Name = "Label_TotalDeItensEmEstoque";
            this.Label_TotalDeItensEmEstoque.Size = new System.Drawing.Size(331, 111);
            this.Label_TotalDeItensEmEstoque.TabIndex = 1;
            this.Label_TotalDeItensEmEstoque.Text = "...";
            this.Label_TotalDeItensEmEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialLabel9);
            this.materialCard8.Controls.Add(this.Label_Totaldevendas);
            this.materialCard8.Depth = 0;
            this.materialCard8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(46, 100);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(331, 224);
            this.materialCard8.TabIndex = 1;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(73, 34);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(194, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "VALOR TOTAL DE VENDAS";
            // 
            // Label_Totaldevendas
            // 
            this.Label_Totaldevendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Totaldevendas.Location = new System.Drawing.Point(0, 49);
            this.Label_Totaldevendas.Name = "Label_Totaldevendas";
            this.Label_Totaldevendas.Size = new System.Drawing.Size(331, 111);
            this.Label_Totaldevendas.TabIndex = 0;
            this.Label_Totaldevendas.Text = "...";
            this.Label_Totaldevendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(698, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "NUMEROS IMPORTANTES";
            // 
            // CLIENTES
            // 
            this.CLIENTES.Controls.Add(this.materialCard4);
            this.CLIENTES.Controls.Add(this.materialCard3);
            this.CLIENTES.Controls.Add(this.materialCard2);
            this.CLIENTES.ImageKey = "CLIENTES.png";
            this.CLIENTES.Location = new System.Drawing.Point(4, 39);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Padding = new System.Windows.Forms.Padding(3);
            this.CLIENTES.Size = new System.Drawing.Size(1587, 727);
            this.CLIENTES.TabIndex = 1;
            this.CLIENTES.Text = "   CLIENTES";
            this.CLIENTES.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.groupBox9);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(29, 548);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(1541, 194);
            this.materialCard4.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listViewClientes);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(17, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1507, 166);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "CLIENTES CADASTRADOS";
            // 
            // listViewClientes
            // 
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(16, 19);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(1476, 137);
            this.listViewClientes.TabIndex = 18;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.groupBox2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(1022, 33);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(548, 490);
            this.materialCard3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_ExcluirCliente);
            this.groupBox2.Controls.Add(this.BTN_SalvarCliente);
            this.groupBox2.Controls.Add(this.BTN_NovoCliente);
            this.groupBox2.Controls.Add(this.BTN_BuscaClientes);
            this.groupBox2.Controls.Add(this.materialCard16);
            this.groupBox2.Controls.Add(this.materialCard17);
            this.groupBox2.Controls.Add(this.materialCard18);
            this.groupBox2.Controls.Add(this.materialCard19);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AÇÕES";
            // 
            // BTN_ExcluirCliente
            // 
            this.BTN_ExcluirCliente.Depth = 0;
            this.BTN_ExcluirCliente.Icon = ((System.Drawing.Image)(resources.GetObject("BTN_ExcluirCliente.Icon")));
            this.BTN_ExcluirCliente.Location = new System.Drawing.Point(420, 324);
            this.BTN_ExcluirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_ExcluirCliente.Name = "BTN_ExcluirCliente";
            this.BTN_ExcluirCliente.Size = new System.Drawing.Size(56, 56);
            this.BTN_ExcluirCliente.TabIndex = 14;
            this.BTN_ExcluirCliente.Text = "materialFloatingActionButton5";
            this.BTN_ExcluirCliente.UseVisualStyleBackColor = true;
            this.BTN_ExcluirCliente.Click += new System.EventHandler(this.BTN_ExcluirCliente_Click);
            // 
            // BTN_SalvarCliente
            // 
            this.BTN_SalvarCliente.Depth = 0;
            this.BTN_SalvarCliente.Icon = ((System.Drawing.Image)(resources.GetObject("BTN_SalvarCliente.Icon")));
            this.BTN_SalvarCliente.Location = new System.Drawing.Point(421, 240);
            this.BTN_SalvarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_SalvarCliente.Name = "BTN_SalvarCliente";
            this.BTN_SalvarCliente.Size = new System.Drawing.Size(56, 56);
            this.BTN_SalvarCliente.TabIndex = 13;
            this.BTN_SalvarCliente.Text = "materialFloatingActionButton6";
            this.BTN_SalvarCliente.UseVisualStyleBackColor = true;
            this.BTN_SalvarCliente.Click += new System.EventHandler(this.BTN_SalvarCliente_Click);
            // 
            // BTN_NovoCliente
            // 
            this.BTN_NovoCliente.Depth = 0;
            this.BTN_NovoCliente.Icon = ((System.Drawing.Image)(resources.GetObject("BTN_NovoCliente.Icon")));
            this.BTN_NovoCliente.Location = new System.Drawing.Point(421, 159);
            this.BTN_NovoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_NovoCliente.Name = "BTN_NovoCliente";
            this.BTN_NovoCliente.Size = new System.Drawing.Size(56, 56);
            this.BTN_NovoCliente.TabIndex = 12;
            this.BTN_NovoCliente.Text = "materialFloatingActionButton7";
            this.BTN_NovoCliente.UseVisualStyleBackColor = true;
            this.BTN_NovoCliente.Click += new System.EventHandler(this.BTN_NovoCliente_Click);
            // 
            // BTN_BuscaClientes
            // 
            this.BTN_BuscaClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_BuscaClientes.BackgroundImage")));
            this.BTN_BuscaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_BuscaClientes.Depth = 0;
            this.BTN_BuscaClientes.Icon = ((System.Drawing.Image)(resources.GetObject("BTN_BuscaClientes.Icon")));
            this.BTN_BuscaClientes.ImageIndex = 0;
            this.BTN_BuscaClientes.Location = new System.Drawing.Point(420, 77);
            this.BTN_BuscaClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_BuscaClientes.Name = "BTN_BuscaClientes";
            this.BTN_BuscaClientes.Size = new System.Drawing.Size(56, 56);
            this.BTN_BuscaClientes.TabIndex = 11;
            this.BTN_BuscaClientes.Text = "materialFloatingActionButton8";
            this.BTN_BuscaClientes.UseVisualStyleBackColor = true;
            this.BTN_BuscaClientes.Click += new System.EventHandler(this.BTN_BuscaClientes_Click);
            // 
            // materialCard16
            // 
            this.materialCard16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard16.Controls.Add(this.materialLabel5);
            this.materialCard16.Depth = 0;
            this.materialCard16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard16.Location = new System.Drawing.Point(48, 316);
            this.materialCard16.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard16.Name = "materialCard16";
            this.materialCard16.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard16.Size = new System.Drawing.Size(403, 72);
            this.materialCard16.TabIndex = 9;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(175, 28);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "EXCLUIR";
            // 
            // materialCard17
            // 
            this.materialCard17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard17.Controls.Add(this.materialLabel6);
            this.materialCard17.Depth = 0;
            this.materialCard17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard17.Location = new System.Drawing.Point(48, 233);
            this.materialCard17.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard17.Name = "materialCard17";
            this.materialCard17.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard17.Size = new System.Drawing.Size(403, 72);
            this.materialCard17.TabIndex = 10;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(175, 27);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(60, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "SALVAR";
            // 
            // materialCard18
            // 
            this.materialCard18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard18.Controls.Add(this.materialLabel7);
            this.materialCard18.Depth = 0;
            this.materialCard18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard18.Location = new System.Drawing.Point(48, 151);
            this.materialCard18.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard18.Name = "materialCard18";
            this.materialCard18.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard18.Size = new System.Drawing.Size(403, 72);
            this.materialCard18.TabIndex = 8;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(181, 28);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(44, 19);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "NOVO";
            // 
            // materialCard19
            // 
            this.materialCard19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard19.Controls.Add(this.Text_buscaCliente);
            this.materialCard19.Depth = 0;
            this.materialCard19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard19.Location = new System.Drawing.Point(48, 69);
            this.materialCard19.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard19.Name = "materialCard19";
            this.materialCard19.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard19.Size = new System.Drawing.Size(403, 72);
            this.materialCard19.TabIndex = 7;
            // 
            // Text_buscaCliente
            // 
            this.Text_buscaCliente.AllowPromptAsInput = true;
            this.Text_buscaCliente.AnimateReadOnly = false;
            this.Text_buscaCliente.AsciiOnly = false;
            this.Text_buscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Text_buscaCliente.BeepOnError = false;
            this.Text_buscaCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Text_buscaCliente.Depth = 0;
            this.Text_buscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Text_buscaCliente.HidePromptOnLeave = false;
            this.Text_buscaCliente.HideSelection = true;
            this.Text_buscaCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Text_buscaCliente.LeadingIcon = null;
            this.Text_buscaCliente.Location = new System.Drawing.Point(18, 12);
            this.Text_buscaCliente.Mask = "";
            this.Text_buscaCliente.MaxLength = 32767;
            this.Text_buscaCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.Text_buscaCliente.Name = "Text_buscaCliente";
            this.Text_buscaCliente.PasswordChar = '\0';
            this.Text_buscaCliente.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.Text_buscaCliente.PrefixSuffixText = "BUSCAR CPF:";
            this.Text_buscaCliente.PromptChar = '_';
            this.Text_buscaCliente.ReadOnly = false;
            this.Text_buscaCliente.RejectInputOnFirstFailure = false;
            this.Text_buscaCliente.ResetOnPrompt = true;
            this.Text_buscaCliente.ResetOnSpace = true;
            this.Text_buscaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_buscaCliente.SelectedText = "";
            this.Text_buscaCliente.SelectionLength = 0;
            this.Text_buscaCliente.SelectionStart = 0;
            this.Text_buscaCliente.ShortcutsEnabled = true;
            this.Text_buscaCliente.Size = new System.Drawing.Size(348, 48);
            this.Text_buscaCliente.SkipLiterals = true;
            this.Text_buscaCliente.TabIndex = 11;
            this.Text_buscaCliente.TabStop = false;
            this.Text_buscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Text_buscaCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Text_buscaCliente.TrailingIcon = null;
            this.Text_buscaCliente.UseSystemPasswordChar = false;
            this.Text_buscaCliente.ValidatingType = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.ComboUF);
            this.materialCard2.Controls.Add(this.TextLocalidade);
            this.materialCard2.Controls.Add(this.TextBairro);
            this.materialCard2.Controls.Add(this.TextComplemento);
            this.materialCard2.Controls.Add(this.TextNomeCompleto);
            this.materialCard2.Controls.Add(this.groupBox1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(29, 33);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(965, 490);
            this.materialCard2.TabIndex = 0;
            // 
            // ComboUF
            // 
            this.ComboUF.AutoResize = false;
            this.ComboUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboUF.Depth = 0;
            this.ComboUF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboUF.DropDownHeight = 174;
            this.ComboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboUF.DropDownWidth = 121;
            this.ComboUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboUF.FormattingEnabled = true;
            this.ComboUF.IntegralHeight = false;
            this.ComboUF.ItemHeight = 43;
            this.ComboUF.Location = new System.Drawing.Point(734, 356);
            this.ComboUF.MaxDropDownItems = 4;
            this.ComboUF.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboUF.Name = "ComboUF";
            this.ComboUF.Size = new System.Drawing.Size(120, 49);
            this.ComboUF.StartIndex = 0;
            this.ComboUF.TabIndex = 10;
            this.ComboUF.Tag = "UF";
            // 
            // TextLocalidade
            // 
            this.TextLocalidade.AnimateReadOnly = false;
            this.TextLocalidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextLocalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextLocalidade.Depth = 0;
            this.TextLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextLocalidade.HideSelection = true;
            this.TextLocalidade.Hint = "LOCALIDADE";
            this.TextLocalidade.LeadingIcon = null;
            this.TextLocalidade.Location = new System.Drawing.Point(409, 356);
            this.TextLocalidade.MaxLength = 32767;
            this.TextLocalidade.MouseState = MaterialSkin.MouseState.OUT;
            this.TextLocalidade.Name = "TextLocalidade";
            this.TextLocalidade.PasswordChar = '\0';
            this.TextLocalidade.PrefixSuffixText = null;
            this.TextLocalidade.ReadOnly = false;
            this.TextLocalidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextLocalidade.SelectedText = "";
            this.TextLocalidade.SelectionLength = 0;
            this.TextLocalidade.SelectionStart = 0;
            this.TextLocalidade.ShortcutsEnabled = true;
            this.TextLocalidade.Size = new System.Drawing.Size(303, 48);
            this.TextLocalidade.TabIndex = 9;
            this.TextLocalidade.TabStop = false;
            this.TextLocalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextLocalidade.TrailingIcon = null;
            this.TextLocalidade.UseSystemPasswordChar = false;
            // 
            // TextBairro
            // 
            this.TextBairro.AnimateReadOnly = false;
            this.TextBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBairro.Depth = 0;
            this.TextBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBairro.HideSelection = true;
            this.TextBairro.Hint = "BAIRRO";
            this.TextBairro.LeadingIcon = null;
            this.TextBairro.Location = new System.Drawing.Point(108, 356);
            this.TextBairro.MaxLength = 32767;
            this.TextBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBairro.Name = "TextBairro";
            this.TextBairro.PasswordChar = '\0';
            this.TextBairro.PrefixSuffixText = null;
            this.TextBairro.ReadOnly = false;
            this.TextBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBairro.SelectedText = "";
            this.TextBairro.SelectionLength = 0;
            this.TextBairro.SelectionStart = 0;
            this.TextBairro.ShortcutsEnabled = true;
            this.TextBairro.Size = new System.Drawing.Size(279, 48);
            this.TextBairro.TabIndex = 8;
            this.TextBairro.TabStop = false;
            this.TextBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBairro.TrailingIcon = null;
            this.TextBairro.UseSystemPasswordChar = false;
            // 
            // TextComplemento
            // 
            this.TextComplemento.AnimateReadOnly = false;
            this.TextComplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextComplemento.Depth = 0;
            this.TextComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextComplemento.HideSelection = true;
            this.TextComplemento.Hint = "COMPLEMENTO";
            this.TextComplemento.LeadingIcon = null;
            this.TextComplemento.Location = new System.Drawing.Point(540, 265);
            this.TextComplemento.MaxLength = 32767;
            this.TextComplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.TextComplemento.Name = "TextComplemento";
            this.TextComplemento.PasswordChar = '\0';
            this.TextComplemento.PrefixSuffixText = null;
            this.TextComplemento.ReadOnly = false;
            this.TextComplemento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextComplemento.SelectedText = "";
            this.TextComplemento.SelectionLength = 0;
            this.TextComplemento.SelectionStart = 0;
            this.TextComplemento.ShortcutsEnabled = true;
            this.TextComplemento.Size = new System.Drawing.Size(315, 48);
            this.TextComplemento.TabIndex = 7;
            this.TextComplemento.TabStop = false;
            this.TextComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextComplemento.TrailingIcon = null;
            this.TextComplemento.UseSystemPasswordChar = false;
            // 
            // TextNomeCompleto
            // 
            this.TextNomeCompleto.AnimateReadOnly = false;
            this.TextNomeCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextNomeCompleto.Depth = 0;
            this.TextNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextNomeCompleto.HideSelection = true;
            this.TextNomeCompleto.Hint = "NOME COMPLETO";
            this.TextNomeCompleto.LeadingIcon = null;
            this.TextNomeCompleto.Location = new System.Drawing.Point(109, 77);
            this.TextNomeCompleto.MaxLength = 32767;
            this.TextNomeCompleto.MouseState = MaterialSkin.MouseState.OUT;
            this.TextNomeCompleto.Name = "TextNomeCompleto";
            this.TextNomeCompleto.PasswordChar = '\0';
            this.TextNomeCompleto.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.TextNomeCompleto.PrefixSuffixText = null;
            this.TextNomeCompleto.ReadOnly = false;
            this.TextNomeCompleto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextNomeCompleto.SelectedText = "";
            this.TextNomeCompleto.SelectionLength = 0;
            this.TextNomeCompleto.SelectionStart = 0;
            this.TextNomeCompleto.ShortcutsEnabled = true;
            this.TextNomeCompleto.Size = new System.Drawing.Size(507, 48);
            this.TextNomeCompleto.TabIndex = 0;
            this.TextNomeCompleto.TabStop = false;
            this.TextNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextNomeCompleto.TrailingIcon = null;
            this.TextNomeCompleto.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelStatusCliente);
            this.groupBox1.Controls.Add(this.TextNum);
            this.groupBox1.Controls.Add(this.TextTelefone);
            this.groupBox1.Controls.Add(this.TextCEP);
            this.groupBox1.Controls.Add(this.TextLogradouro);
            this.groupBox1.Controls.Add(this.TextCPF);
            this.groupBox1.Controls.Add(this.TextEmail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO CLIENTES";
            // 
            // LabelStatusCliente
            // 
            this.LabelStatusCliente.AutoSize = true;
            this.LabelStatusCliente.Depth = 0;
            this.LabelStatusCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusCliente.Location = new System.Drawing.Point(82, 413);
            this.LabelStatusCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusCliente.Name = "LabelStatusCliente";
            this.LabelStatusCliente.Size = new System.Drawing.Size(157, 19);
            this.LabelStatusCliente.TabIndex = 6;
            this.LabelStatusCliente.Text = "STATUS DO CLIENTE:";
            // 
            // TextNum
            // 
            this.TextNum.AllowPromptAsInput = true;
            this.TextNum.AnimateReadOnly = false;
            this.TextNum.AsciiOnly = false;
            this.TextNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextNum.BeepOnError = false;
            this.TextNum.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextNum.Depth = 0;
            this.TextNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextNum.HidePromptOnLeave = false;
            this.TextNum.HideSelection = true;
            this.TextNum.Hint = "N°";
            this.TextNum.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextNum.LeadingIcon = null;
            this.TextNum.Location = new System.Drawing.Point(385, 248);
            this.TextNum.Mask = "";
            this.TextNum.MaxLength = 32767;
            this.TextNum.MouseState = MaterialSkin.MouseState.OUT;
            this.TextNum.Name = "TextNum";
            this.TextNum.PasswordChar = '\0';
            this.TextNum.PrefixSuffixText = null;
            this.TextNum.PromptChar = '_';
            this.TextNum.ReadOnly = false;
            this.TextNum.RejectInputOnFirstFailure = false;
            this.TextNum.ResetOnPrompt = true;
            this.TextNum.ResetOnSpace = true;
            this.TextNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextNum.SelectedText = "";
            this.TextNum.SelectionLength = 0;
            this.TextNum.SelectionStart = 0;
            this.TextNum.ShortcutsEnabled = true;
            this.TextNum.Size = new System.Drawing.Size(110, 48);
            this.TextNum.SkipLiterals = true;
            this.TextNum.TabIndex = 6;
            this.TextNum.TabStop = false;
            this.TextNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextNum.TrailingIcon = null;
            this.TextNum.UseSystemPasswordChar = false;
            this.TextNum.ValidatingType = null;
            // 
            // TextTelefone
            // 
            this.TextTelefone.AllowPromptAsInput = true;
            this.TextTelefone.AnimateReadOnly = false;
            this.TextTelefone.AsciiOnly = false;
            this.TextTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextTelefone.BeepOnError = false;
            this.TextTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextTelefone.Depth = 0;
            this.TextTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextTelefone.HidePromptOnLeave = false;
            this.TextTelefone.HideSelection = true;
            this.TextTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextTelefone.LeadingIcon = null;
            this.TextTelefone.Location = new System.Drawing.Point(385, 150);
            this.TextTelefone.Mask = "";
            this.TextTelefone.MaxLength = 32767;
            this.TextTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.TextTelefone.Name = "TextTelefone";
            this.TextTelefone.PasswordChar = '\0';
            this.TextTelefone.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.TextTelefone.PrefixSuffixText = "CEL:";
            this.TextTelefone.PromptChar = '_';
            this.TextTelefone.ReadOnly = false;
            this.TextTelefone.RejectInputOnFirstFailure = false;
            this.TextTelefone.ResetOnPrompt = true;
            this.TextTelefone.ResetOnSpace = true;
            this.TextTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextTelefone.SelectedText = "";
            this.TextTelefone.SelectionLength = 0;
            this.TextTelefone.SelectionStart = 0;
            this.TextTelefone.ShortcutsEnabled = true;
            this.TextTelefone.Size = new System.Drawing.Size(207, 48);
            this.TextTelefone.SkipLiterals = true;
            this.TextTelefone.TabIndex = 2;
            this.TextTelefone.TabStop = false;
            this.TextTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextTelefone.TrailingIcon = null;
            this.TextTelefone.UseSystemPasswordChar = false;
            this.TextTelefone.ValidatingType = null;
            // 
            // TextCEP
            // 
            this.TextCEP.AllowPromptAsInput = true;
            this.TextCEP.AnimateReadOnly = false;
            this.TextCEP.AsciiOnly = false;
            this.TextCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextCEP.BeepOnError = false;
            this.TextCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextCEP.Depth = 0;
            this.TextCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextCEP.HidePromptOnLeave = false;
            this.TextCEP.HideSelection = true;
            this.TextCEP.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextCEP.LeadingIcon = null;
            this.TextCEP.Location = new System.Drawing.Point(625, 150);
            this.TextCEP.Mask = "";
            this.TextCEP.MaxLength = 32767;
            this.TextCEP.MouseState = MaterialSkin.MouseState.OUT;
            this.TextCEP.Name = "TextCEP";
            this.TextCEP.PasswordChar = '\0';
            this.TextCEP.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.TextCEP.PrefixSuffixText = "CEP:";
            this.TextCEP.PromptChar = '_';
            this.TextCEP.ReadOnly = false;
            this.TextCEP.RejectInputOnFirstFailure = false;
            this.TextCEP.ResetOnPrompt = true;
            this.TextCEP.ResetOnSpace = true;
            this.TextCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextCEP.SelectedText = "";
            this.TextCEP.SelectionLength = 0;
            this.TextCEP.SelectionStart = 0;
            this.TextCEP.ShortcutsEnabled = true;
            this.TextCEP.Size = new System.Drawing.Size(206, 48);
            this.TextCEP.SkipLiterals = true;
            this.TextCEP.TabIndex = 4;
            this.TextCEP.TabStop = false;
            this.TextCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextCEP.TrailingIcon = null;
            this.TextCEP.UseSystemPasswordChar = false;
            this.TextCEP.ValidatingType = null;
            this.TextCEP.Leave += new System.EventHandler(this.TextCEP_Leave);
            // 
            // TextLogradouro
            // 
            this.TextLogradouro.AnimateReadOnly = false;
            this.TextLogradouro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextLogradouro.Depth = 0;
            this.TextLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextLogradouro.HideSelection = true;
            this.TextLogradouro.Hint = "LOGRADOURO";
            this.TextLogradouro.LeadingIcon = null;
            this.TextLogradouro.Location = new System.Drawing.Point(84, 248);
            this.TextLogradouro.MaxLength = 32767;
            this.TextLogradouro.MouseState = MaterialSkin.MouseState.OUT;
            this.TextLogradouro.Name = "TextLogradouro";
            this.TextLogradouro.PasswordChar = '\0';
            this.TextLogradouro.PrefixSuffixText = null;
            this.TextLogradouro.ReadOnly = false;
            this.TextLogradouro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextLogradouro.SelectedText = "";
            this.TextLogradouro.SelectionLength = 0;
            this.TextLogradouro.SelectionStart = 0;
            this.TextLogradouro.ShortcutsEnabled = true;
            this.TextLogradouro.Size = new System.Drawing.Size(279, 48);
            this.TextLogradouro.TabIndex = 5;
            this.TextLogradouro.TabStop = false;
            this.TextLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextLogradouro.TrailingIcon = null;
            this.TextLogradouro.UseSystemPasswordChar = false;
            // 
            // TextCPF
            // 
            this.TextCPF.AllowPromptAsInput = true;
            this.TextCPF.AnimateReadOnly = false;
            this.TextCPF.AsciiOnly = false;
            this.TextCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextCPF.BeepOnError = false;
            this.TextCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextCPF.Depth = 0;
            this.TextCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextCPF.HidePromptOnLeave = false;
            this.TextCPF.HideSelection = true;
            this.TextCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextCPF.LeadingIcon = null;
            this.TextCPF.Location = new System.Drawing.Point(624, 60);
            this.TextCPF.Mask = "";
            this.TextCPF.MaxLength = 32767;
            this.TextCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.TextCPF.Name = "TextCPF";
            this.TextCPF.PasswordChar = '\0';
            this.TextCPF.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.TextCPF.PrefixSuffixText = "CPF:";
            this.TextCPF.PromptChar = '_';
            this.TextCPF.ReadOnly = false;
            this.TextCPF.RejectInputOnFirstFailure = false;
            this.TextCPF.ResetOnPrompt = true;
            this.TextCPF.ResetOnSpace = true;
            this.TextCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextCPF.SelectedText = "";
            this.TextCPF.SelectionLength = 0;
            this.TextCPF.SelectionStart = 0;
            this.TextCPF.ShortcutsEnabled = true;
            this.TextCPF.Size = new System.Drawing.Size(207, 48);
            this.TextCPF.SkipLiterals = true;
            this.TextCPF.TabIndex = 1;
            this.TextCPF.TabStop = false;
            this.TextCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextCPF.TrailingIcon = null;
            this.TextCPF.UseSystemPasswordChar = false;
            this.TextCPF.ValidatingType = null;
            this.TextCPF.Leave += new System.EventHandler(this.TextCPF_Leave);
            // 
            // TextEmail
            // 
            this.TextEmail.AnimateReadOnly = false;
            this.TextEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextEmail.Depth = 0;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextEmail.HideSelection = true;
            this.TextEmail.Hint = "E-MAIL";
            this.TextEmail.LeadingIcon = null;
            this.TextEmail.Location = new System.Drawing.Point(84, 150);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.PrefixSuffixText = null;
            this.TextEmail.ReadOnly = false;
            this.TextEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.ShortcutsEnabled = true;
            this.TextEmail.Size = new System.Drawing.Size(279, 48);
            this.TextEmail.TabIndex = 3;
            this.TextEmail.TabStop = false;
            this.TextEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextEmail.TrailingIcon = null;
            this.TextEmail.UseSystemPasswordChar = false;
            // 
            // PRODUTOS
            // 
            this.PRODUTOS.Controls.Add(this.materialCard5);
            this.PRODUTOS.Controls.Add(this.materialCard6);
            this.PRODUTOS.Controls.Add(this.materialCard7);
            this.PRODUTOS.ImageKey = "PRODUTOS.png";
            this.PRODUTOS.Location = new System.Drawing.Point(4, 39);
            this.PRODUTOS.Name = "PRODUTOS";
            this.PRODUTOS.Size = new System.Drawing.Size(1587, 727);
            this.PRODUTOS.TabIndex = 2;
            this.PRODUTOS.Text = "   PRODUTOS";
            this.PRODUTOS.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.groupBox8);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(26, 460);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(1541, 281);
            this.materialCard5.TabIndex = 4;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listViewProdutos);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(20, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1507, 247);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "PRODUTOS CADASTRADOS";
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(16, 19);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(1470, 210);
            this.listViewProdutos.TabIndex = 0;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.groupBox4);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(1019, 32);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(548, 400);
            this.materialCard6.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_deletarProduto);
            this.groupBox4.Controls.Add(this.btn_SalvarProduto);
            this.groupBox4.Controls.Add(this.btn_NovoProduto);
            this.groupBox4.Controls.Add(this.btn_BuscaProduto);
            this.groupBox4.Controls.Add(this.materialCard15);
            this.groupBox4.Controls.Add(this.materialCard14);
            this.groupBox4.Controls.Add(this.materialCard13);
            this.groupBox4.Controls.Add(this.materialCard12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(514, 364);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AÇÕES";
            // 
            // btn_deletarProduto
            // 
            this.btn_deletarProduto.Depth = 0;
            this.btn_deletarProduto.Icon = ((System.Drawing.Image)(resources.GetObject("btn_deletarProduto.Icon")));
            this.btn_deletarProduto.Location = new System.Drawing.Point(403, 279);
            this.btn_deletarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deletarProduto.Name = "btn_deletarProduto";
            this.btn_deletarProduto.Size = new System.Drawing.Size(56, 56);
            this.btn_deletarProduto.TabIndex = 6;
            this.btn_deletarProduto.Text = "materialFloatingActionButton4";
            this.btn_deletarProduto.UseVisualStyleBackColor = true;
            this.btn_deletarProduto.Click += new System.EventHandler(this.btn_deletarProduto_Click);
            // 
            // btn_SalvarProduto
            // 
            this.btn_SalvarProduto.Depth = 0;
            this.btn_SalvarProduto.Icon = ((System.Drawing.Image)(resources.GetObject("btn_SalvarProduto.Icon")));
            this.btn_SalvarProduto.Location = new System.Drawing.Point(404, 195);
            this.btn_SalvarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SalvarProduto.Name = "btn_SalvarProduto";
            this.btn_SalvarProduto.Size = new System.Drawing.Size(56, 56);
            this.btn_SalvarProduto.TabIndex = 5;
            this.btn_SalvarProduto.Text = "materialFloatingActionButton3";
            this.btn_SalvarProduto.UseVisualStyleBackColor = true;
            this.btn_SalvarProduto.Click += new System.EventHandler(this.btn_SalvarProduto_Click_1);
            // 
            // btn_NovoProduto
            // 
            this.btn_NovoProduto.Depth = 0;
            this.btn_NovoProduto.Icon = ((System.Drawing.Image)(resources.GetObject("btn_NovoProduto.Icon")));
            this.btn_NovoProduto.Location = new System.Drawing.Point(404, 114);
            this.btn_NovoProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_NovoProduto.Name = "btn_NovoProduto";
            this.btn_NovoProduto.Size = new System.Drawing.Size(56, 56);
            this.btn_NovoProduto.TabIndex = 4;
            this.btn_NovoProduto.Text = "materialFloatingActionButton2";
            this.btn_NovoProduto.UseVisualStyleBackColor = true;
            this.btn_NovoProduto.Click += new System.EventHandler(this.btn_NovoProduto_Click);
            // 
            // btn_BuscaProduto
            // 
            this.btn_BuscaProduto.Depth = 0;
            this.btn_BuscaProduto.Icon = ((System.Drawing.Image)(resources.GetObject("btn_BuscaProduto.Icon")));
            this.btn_BuscaProduto.Location = new System.Drawing.Point(403, 32);
            this.btn_BuscaProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_BuscaProduto.Name = "btn_BuscaProduto";
            this.btn_BuscaProduto.Size = new System.Drawing.Size(56, 56);
            this.btn_BuscaProduto.TabIndex = 3;
            this.btn_BuscaProduto.Text = "materialFloatingActionButton1";
            this.btn_BuscaProduto.UseVisualStyleBackColor = true;
            this.btn_BuscaProduto.Click += new System.EventHandler(this.btn_BuscaProduto_Click);
            // 
            // materialCard15
            // 
            this.materialCard15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard15.Controls.Add(this.materialLabel2);
            this.materialCard15.Depth = 0;
            this.materialCard15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard15.Location = new System.Drawing.Point(83, 271);
            this.materialCard15.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard15.Name = "materialCard15";
            this.materialCard15.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard15.Size = new System.Drawing.Size(351, 72);
            this.materialCard15.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(145, 28);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "EXCLUIR";
            // 
            // materialCard14
            // 
            this.materialCard14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard14.Controls.Add(this.materialLabel3);
            this.materialCard14.Depth = 0;
            this.materialCard14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard14.Location = new System.Drawing.Point(83, 188);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(351, 72);
            this.materialCard14.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(145, 27);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "SALVAR";
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.materialLabel4);
            this.materialCard13.Depth = 0;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(83, 106);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard13.Size = new System.Drawing.Size(351, 72);
            this.materialCard13.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(151, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "NOVO";
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.TextBuscaProduto);
            this.materialCard12.Depth = 0;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(83, 24);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard12.Size = new System.Drawing.Size(351, 72);
            this.materialCard12.TabIndex = 0;
            // 
            // TextBuscaProduto
            // 
            this.TextBuscaProduto.AnimateReadOnly = false;
            this.TextBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBuscaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBuscaProduto.Depth = 0;
            this.TextBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBuscaProduto.HideSelection = true;
            this.TextBuscaProduto.Hint = "Busca por Produto";
            this.TextBuscaProduto.LeadingIcon = null;
            this.TextBuscaProduto.Location = new System.Drawing.Point(17, 13);
            this.TextBuscaProduto.MaxLength = 32767;
            this.TextBuscaProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBuscaProduto.Name = "TextBuscaProduto";
            this.TextBuscaProduto.PasswordChar = '\0';
            this.TextBuscaProduto.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.TextBuscaProduto.PrefixSuffixText = null;
            this.TextBuscaProduto.ReadOnly = false;
            this.TextBuscaProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBuscaProduto.SelectedText = "";
            this.TextBuscaProduto.SelectionLength = 0;
            this.TextBuscaProduto.SelectionStart = 0;
            this.TextBuscaProduto.ShortcutsEnabled = true;
            this.TextBuscaProduto.Size = new System.Drawing.Size(297, 48);
            this.TextBuscaProduto.TabIndex = 7;
            this.TextBuscaProduto.TabStop = false;
            this.TextBuscaProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBuscaProduto.TrailingIcon = null;
            this.TextBuscaProduto.UseSystemPasswordChar = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.TextValor);
            this.materialCard7.Controls.Add(this.TextProduto);
            this.materialCard7.Controls.Add(this.groupBox3);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(26, 32);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(965, 400);
            this.materialCard7.TabIndex = 2;
            // 
            // TextValor
            // 
            this.TextValor.AnimateReadOnly = false;
            this.TextValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextValor.Depth = 0;
            this.TextValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextValor.HideSelection = true;
            this.TextValor.Hint = "VALOR";
            this.TextValor.LeadingIcon = null;
            this.TextValor.Location = new System.Drawing.Point(59, 135);
            this.TextValor.MaxLength = 32767;
            this.TextValor.MouseState = MaterialSkin.MouseState.OUT;
            this.TextValor.Name = "TextValor";
            this.TextValor.PasswordChar = '\0';
            this.TextValor.PrefixSuffixText = null;
            this.TextValor.ReadOnly = false;
            this.TextValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextValor.SelectedText = "";
            this.TextValor.SelectionLength = 0;
            this.TextValor.SelectionStart = 0;
            this.TextValor.ShortcutsEnabled = true;
            this.TextValor.Size = new System.Drawing.Size(620, 48);
            this.TextValor.TabIndex = 1;
            this.TextValor.TabStop = false;
            this.TextValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextValor.TrailingIcon = null;
            this.TextValor.UseSystemPasswordChar = false;
            // 
            // TextProduto
            // 
            this.TextProduto.AnimateReadOnly = false;
            this.TextProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextProduto.Depth = 0;
            this.TextProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextProduto.HideSelection = true;
            this.TextProduto.Hint = "PRODUTO";
            this.TextProduto.LeadingIcon = null;
            this.TextProduto.Location = new System.Drawing.Point(59, 59);
            this.TextProduto.MaxLength = 32767;
            this.TextProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.TextProduto.Name = "TextProduto";
            this.TextProduto.PasswordChar = '\0';
            this.TextProduto.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.TextProduto.PrefixSuffixText = null;
            this.TextProduto.ReadOnly = false;
            this.TextProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextProduto.SelectedText = "";
            this.TextProduto.SelectionLength = 0;
            this.TextProduto.SelectionStart = 0;
            this.TextProduto.ShortcutsEnabled = true;
            this.TextProduto.Size = new System.Drawing.Size(842, 48);
            this.TextProduto.TabIndex = 0;
            this.TextProduto.TabStop = false;
            this.TextProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextProduto.TrailingIcon = null;
            this.TextProduto.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextDescricao);
            this.groupBox3.Controls.Add(this.LabelStatus);
            this.groupBox3.Controls.Add(this.TextQuatidade);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(924, 364);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CADASTRO PRODUTOS";
            // 
            // TextDescricao
            // 
            this.TextDescricao.AnimateReadOnly = false;
            this.TextDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextDescricao.Depth = 0;
            this.TextDescricao.HideSelection = true;
            this.TextDescricao.Hint = "DESCRIÇÃO ";
            this.TextDescricao.Location = new System.Drawing.Point(39, 188);
            this.TextDescricao.MaxLength = 32767;
            this.TextDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.PasswordChar = '\0';
            this.TextDescricao.ReadOnly = false;
            this.TextDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescricao.SelectedText = "";
            this.TextDescricao.SelectionLength = 0;
            this.TextDescricao.SelectionStart = 0;
            this.TextDescricao.ShortcutsEnabled = true;
            this.TextDescricao.Size = new System.Drawing.Size(842, 130);
            this.TextDescricao.TabIndex = 3;
            this.TextDescricao.TabStop = false;
            this.TextDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextDescricao.UseSystemPasswordChar = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Depth = 0;
            this.LabelStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatus.Location = new System.Drawing.Point(39, 334);
            this.LabelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(168, 19);
            this.LabelStatus.TabIndex = 5;
            this.LabelStatus.Text = "STATUS DO PRODUTO:";
            // 
            // TextQuatidade
            // 
            this.TextQuatidade.AllowPromptAsInput = true;
            this.TextQuatidade.AnimateReadOnly = false;
            this.TextQuatidade.AsciiOnly = false;
            this.TextQuatidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextQuatidade.BeepOnError = false;
            this.TextQuatidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextQuatidade.Depth = 0;
            this.TextQuatidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextQuatidade.HidePromptOnLeave = false;
            this.TextQuatidade.HideSelection = true;
            this.TextQuatidade.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextQuatidade.LeadingIcon = null;
            this.TextQuatidade.Location = new System.Drawing.Point(688, 118);
            this.TextQuatidade.Mask = "";
            this.TextQuatidade.MaxLength = 32767;
            this.TextQuatidade.MouseState = MaterialSkin.MouseState.OUT;
            this.TextQuatidade.Name = "TextQuatidade";
            this.TextQuatidade.PasswordChar = '\0';
            this.TextQuatidade.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.TextQuatidade.PrefixSuffixText = "QUANTIDADE:";
            this.TextQuatidade.PromptChar = '_';
            this.TextQuatidade.ReadOnly = false;
            this.TextQuatidade.RejectInputOnFirstFailure = false;
            this.TextQuatidade.ResetOnPrompt = true;
            this.TextQuatidade.ResetOnSpace = true;
            this.TextQuatidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextQuatidade.SelectedText = "";
            this.TextQuatidade.SelectionLength = 0;
            this.TextQuatidade.SelectionStart = 0;
            this.TextQuatidade.ShortcutsEnabled = true;
            this.TextQuatidade.Size = new System.Drawing.Size(193, 48);
            this.TextQuatidade.SkipLiterals = true;
            this.TextQuatidade.TabIndex = 2;
            this.TextQuatidade.TabStop = false;
            this.TextQuatidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextQuatidade.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextQuatidade.TrailingIcon = null;
            this.TextQuatidade.UseSystemPasswordChar = false;
            this.TextQuatidade.ValidatingType = null;
            // 
            // VENDAS
            // 
            this.VENDAS.Controls.Add(this.materialCard30);
            this.VENDAS.Controls.Add(this.materialCard22);
            this.VENDAS.Controls.Add(this.materialCard21);
            this.VENDAS.Controls.Add(this.materialCard20);
            this.VENDAS.ImageKey = "VENDAS.png";
            this.VENDAS.Location = new System.Drawing.Point(4, 39);
            this.VENDAS.Name = "VENDAS";
            this.VENDAS.Size = new System.Drawing.Size(1587, 727);
            this.VENDAS.TabIndex = 3;
            this.VENDAS.Text = "   VENDAS";
            this.VENDAS.UseVisualStyleBackColor = true;
            // 
            // materialCard30
            // 
            this.materialCard30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard30.Controls.Add(this.groupBox7);
            this.materialCard30.Depth = 0;
            this.materialCard30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard30.Location = new System.Drawing.Point(939, 413);
            this.materialCard30.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard30.Name = "materialCard30";
            this.materialCard30.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard30.Size = new System.Drawing.Size(634, 338);
            this.materialCard30.TabIndex = 33;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listViewVendas);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(17, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(600, 298);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PEDIDOS FINALIZADOS";
            // 
            // listViewVendas
            // 
            this.listViewVendas.HideSelection = false;
            this.listViewVendas.Location = new System.Drawing.Point(18, 24);
            this.listViewVendas.Name = "listViewVendas";
            this.listViewVendas.Size = new System.Drawing.Size(561, 254);
            this.listViewVendas.TabIndex = 18;
            this.listViewVendas.UseCompatibleStateImageBehavior = false;
            // 
            // materialCard22
            // 
            this.materialCard22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard22.Controls.Add(this.groupBox6);
            this.materialCard22.Depth = 0;
            this.materialCard22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard22.Location = new System.Drawing.Point(25, 413);
            this.materialCard22.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard22.Name = "materialCard22";
            this.materialCard22.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard22.Size = new System.Drawing.Size(886, 338);
            this.materialCard22.TabIndex = 32;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listViewPedidosEmAndamento);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(17, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(852, 298);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PEDIDO EM ANDAMENTO";
            // 
            // listViewPedidosEmAndamento
            // 
            this.listViewPedidosEmAndamento.HideSelection = false;
            this.listViewPedidosEmAndamento.Location = new System.Drawing.Point(15, 24);
            this.listViewPedidosEmAndamento.Name = "listViewPedidosEmAndamento";
            this.listViewPedidosEmAndamento.Size = new System.Drawing.Size(820, 254);
            this.listViewPedidosEmAndamento.TabIndex = 17;
            this.listViewPedidosEmAndamento.UseCompatibleStateImageBehavior = false;
            // 
            // materialCard21
            // 
            this.materialCard21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard21.Controls.Add(this.groupBox5);
            this.materialCard21.Depth = 0;
            this.materialCard21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard21.Location = new System.Drawing.Point(939, 14);
            this.materialCard21.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard21.Name = "materialCard21";
            this.materialCard21.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard21.Size = new System.Drawing.Size(634, 371);
            this.materialCard21.TabIndex = 38;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Finalizarpedido);
            this.groupBox5.Controls.Add(this.btn_novopedido);
            this.groupBox5.Controls.Add(this.materialCard23);
            this.groupBox5.Controls.Add(this.materialCard25);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(17, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 341);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AÇÕES";
            // 
            // btn_Finalizarpedido
            // 
            this.btn_Finalizarpedido.Depth = 0;
            this.btn_Finalizarpedido.Icon = ((System.Drawing.Image)(resources.GetObject("btn_Finalizarpedido.Icon")));
            this.btn_Finalizarpedido.Location = new System.Drawing.Point(444, 198);
            this.btn_Finalizarpedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Finalizarpedido.Name = "btn_Finalizarpedido";
            this.btn_Finalizarpedido.Size = new System.Drawing.Size(56, 56);
            this.btn_Finalizarpedido.TabIndex = 16;
            this.btn_Finalizarpedido.Text = "materialFloatingActionButton9";
            this.btn_Finalizarpedido.UseVisualStyleBackColor = true;
            this.btn_Finalizarpedido.Click += new System.EventHandler(this.btn_Finalizarpedido_Click);
            // 
            // btn_novopedido
            // 
            this.btn_novopedido.Depth = 0;
            this.btn_novopedido.Icon = ((System.Drawing.Image)(resources.GetObject("btn_novopedido.Icon")));
            this.btn_novopedido.Location = new System.Drawing.Point(445, 73);
            this.btn_novopedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_novopedido.Name = "btn_novopedido";
            this.btn_novopedido.Size = new System.Drawing.Size(56, 56);
            this.btn_novopedido.TabIndex = 15;
            this.btn_novopedido.Text = "materialFloatingActionButton11";
            this.btn_novopedido.UseVisualStyleBackColor = true;
            this.btn_novopedido.Click += new System.EventHandler(this.btn_novopedido_Click);
            // 
            // materialCard23
            // 
            this.materialCard23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard23.Controls.Add(this.materialLabel8);
            this.materialCard23.Depth = 0;
            this.materialCard23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard23.Location = new System.Drawing.Point(124, 190);
            this.materialCard23.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard23.Name = "materialCard23";
            this.materialCard23.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard23.Size = new System.Drawing.Size(351, 72);
            this.materialCard23.TabIndex = 35;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(112, 28);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(138, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "FINALIZAR PEDIDO";
            // 
            // materialCard25
            // 
            this.materialCard25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard25.Controls.Add(this.materialLabel10);
            this.materialCard25.Depth = 0;
            this.materialCard25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard25.Location = new System.Drawing.Point(124, 65);
            this.materialCard25.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard25.Name = "materialCard25";
            this.materialCard25.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard25.Size = new System.Drawing.Size(351, 72);
            this.materialCard25.TabIndex = 36;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(126, 28);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(104, 19);
            this.materialLabel10.TabIndex = 2;
            this.materialLabel10.Text = "NOVO PEDIDO";
            // 
            // materialCard20
            // 
            this.materialCard20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard20.Controls.Add(this.textProdutoVendas);
            this.materialCard20.Controls.Add(this.btn_RetirarSelecionados);
            this.materialCard20.Controls.Add(this.materialCard33);
            this.materialCard20.Controls.Add(this.textCPFVendas);
            this.materialCard20.Controls.Add(this.textValorVendas);
            this.materialCard20.Controls.Add(this.materialLabel12);
            this.materialCard20.Controls.Add(this.materialCard29);
            this.materialCard20.Controls.Add(this.btn_adicionarPedido);
            this.materialCard20.Controls.Add(this.materialCard28);
            this.materialCard20.Controls.Add(this.textNomeClienteVendas);
            this.materialCard20.Controls.Add(this.textQuantidadeVendas);
            this.materialCard20.Controls.Add(this.btn_buscaClienteVenda);
            this.materialCard20.Controls.Add(this.materialCard27);
            this.materialCard20.Controls.Add(this.NumericoQuantidadeDesejada);
            this.materialCard20.Controls.Add(this.btn_buscaProdutoVenda);
            this.materialCard20.Controls.Add(this.materialCard26);
            this.materialCard20.Depth = 0;
            this.materialCard20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard20.Location = new System.Drawing.Point(25, 14);
            this.materialCard20.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard20.Name = "materialCard20";
            this.materialCard20.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard20.Size = new System.Drawing.Size(886, 371);
            this.materialCard20.TabIndex = 34;
            // 
            // textProdutoVendas
            // 
            this.textProdutoVendas.AnimateReadOnly = false;
            this.textProdutoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textProdutoVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textProdutoVendas.Depth = 0;
            this.textProdutoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textProdutoVendas.HideSelection = true;
            this.textProdutoVendas.Hint = "Produto";
            this.textProdutoVendas.LeadingIcon = null;
            this.textProdutoVendas.Location = new System.Drawing.Point(43, 106);
            this.textProdutoVendas.MaxLength = 32767;
            this.textProdutoVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.textProdutoVendas.Name = "textProdutoVendas";
            this.textProdutoVendas.PasswordChar = '\0';
            this.textProdutoVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textProdutoVendas.PrefixSuffixText = null;
            this.textProdutoVendas.ReadOnly = true;
            this.textProdutoVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textProdutoVendas.SelectedText = "";
            this.textProdutoVendas.SelectionLength = 0;
            this.textProdutoVendas.SelectionStart = 0;
            this.textProdutoVendas.ShortcutsEnabled = true;
            this.textProdutoVendas.Size = new System.Drawing.Size(377, 48);
            this.textProdutoVendas.TabIndex = 2;
            this.textProdutoVendas.TabStop = false;
            this.textProdutoVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textProdutoVendas.TrailingIcon = null;
            this.textProdutoVendas.UseSystemPasswordChar = false;
            // 
            // btn_RetirarSelecionados
            // 
            this.btn_RetirarSelecionados.Depth = 0;
            this.btn_RetirarSelecionados.Icon = ((System.Drawing.Image)(resources.GetObject("btn_RetirarSelecionados.Icon")));
            this.btn_RetirarSelecionados.Location = new System.Drawing.Point(228, 298);
            this.btn_RetirarSelecionados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_RetirarSelecionados.Name = "btn_RetirarSelecionados";
            this.btn_RetirarSelecionados.Size = new System.Drawing.Size(56, 56);
            this.btn_RetirarSelecionados.TabIndex = 20;
            this.btn_RetirarSelecionados.Text = "materialFloatingActionButton14";
            this.btn_RetirarSelecionados.UseVisualStyleBackColor = true;
            this.btn_RetirarSelecionados.Click += new System.EventHandler(this.btn_RetirarSelecionados_Click);
            // 
            // materialCard33
            // 
            this.materialCard33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard33.Controls.Add(this.materialLabel13);
            this.materialCard33.Depth = 0;
            this.materialCard33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard33.Location = new System.Drawing.Point(43, 294);
            this.materialCard33.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard33.Name = "materialCard33";
            this.materialCard33.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard33.Size = new System.Drawing.Size(215, 63);
            this.materialCard33.TabIndex = 39;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(17, 23);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(164, 19);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "TIRAR SELECIONADOS";
            // 
            // textCPFVendas
            // 
            this.textCPFVendas.AnimateReadOnly = false;
            this.textCPFVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textCPFVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textCPFVendas.Depth = 0;
            this.textCPFVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textCPFVendas.HideSelection = true;
            this.textCPFVendas.Hint = "CPF";
            this.textCPFVendas.LeadingIcon = null;
            this.textCPFVendas.Location = new System.Drawing.Point(364, 165);
            this.textCPFVendas.MaxLength = 32767;
            this.textCPFVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.textCPFVendas.Name = "textCPFVendas";
            this.textCPFVendas.PasswordChar = '\0';
            this.textCPFVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textCPFVendas.PrefixSuffixText = null;
            this.textCPFVendas.ReadOnly = true;
            this.textCPFVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textCPFVendas.SelectedText = "";
            this.textCPFVendas.SelectionLength = 0;
            this.textCPFVendas.SelectionStart = 0;
            this.textCPFVendas.ShortcutsEnabled = true;
            this.textCPFVendas.Size = new System.Drawing.Size(160, 48);
            this.textCPFVendas.TabIndex = 6;
            this.textCPFVendas.TabStop = false;
            this.textCPFVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textCPFVendas.TrailingIcon = null;
            this.textCPFVendas.UseSystemPasswordChar = false;
            // 
            // textValorVendas
            // 
            this.textValorVendas.AnimateReadOnly = false;
            this.textValorVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textValorVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textValorVendas.Depth = 0;
            this.textValorVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textValorVendas.HideSelection = true;
            this.textValorVendas.Hint = "Valor Unitario";
            this.textValorVendas.LeadingIcon = null;
            this.textValorVendas.Location = new System.Drawing.Point(577, 106);
            this.textValorVendas.MaxLength = 32767;
            this.textValorVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.textValorVendas.Name = "textValorVendas";
            this.textValorVendas.PasswordChar = '\0';
            this.textValorVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textValorVendas.PrefixSuffixText = null;
            this.textValorVendas.ReadOnly = true;
            this.textValorVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textValorVendas.SelectedText = "";
            this.textValorVendas.SelectionLength = 0;
            this.textValorVendas.SelectionStart = 0;
            this.textValorVendas.ShortcutsEnabled = true;
            this.textValorVendas.Size = new System.Drawing.Size(232, 48);
            this.textValorVendas.TabIndex = 4;
            this.textValorVendas.TabStop = false;
            this.textValorVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textValorVendas.TrailingIcon = null;
            this.textValorVendas.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(550, 181);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(102, 19);
            this.materialLabel12.TabIndex = 19;
            this.materialLabel12.Text = "Qtd. desejada:";
            // 
            // materialCard29
            // 
            this.materialCard29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard29.Controls.Add(this.LabelTotal);
            this.materialCard29.Depth = 0;
            this.materialCard29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard29.Location = new System.Drawing.Point(364, 249);
            this.materialCard29.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard29.Name = "materialCard29";
            this.materialCard29.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard29.Size = new System.Drawing.Size(459, 63);
            this.materialCard29.TabIndex = 18;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Location = new System.Drawing.Point(0, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(459, 63);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "R$ 0,00";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_adicionarPedido
            // 
            this.btn_adicionarPedido.Depth = 0;
            this.btn_adicionarPedido.Icon = ((System.Drawing.Image)(resources.GetObject("btn_adicionarPedido.Icon")));
            this.btn_adicionarPedido.Location = new System.Drawing.Point(228, 230);
            this.btn_adicionarPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_adicionarPedido.Name = "btn_adicionarPedido";
            this.btn_adicionarPedido.Size = new System.Drawing.Size(56, 56);
            this.btn_adicionarPedido.TabIndex = 19;
            this.btn_adicionarPedido.Text = "materialFloatingActionButton14";
            this.btn_adicionarPedido.UseVisualStyleBackColor = true;
            this.btn_adicionarPedido.Click += new System.EventHandler(this.btn_adicionarPedido_Click);
            // 
            // materialCard28
            // 
            this.materialCard28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard28.Controls.Add(this.materialLabel11);
            this.materialCard28.Depth = 0;
            this.materialCard28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard28.Location = new System.Drawing.Point(43, 226);
            this.materialCard28.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard28.Name = "materialCard28";
            this.materialCard28.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard28.Size = new System.Drawing.Size(215, 63);
            this.materialCard28.TabIndex = 40;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 23);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(167, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "ADICIONAR AO PEDIDO";
            // 
            // textNomeClienteVendas
            // 
            this.textNomeClienteVendas.AnimateReadOnly = false;
            this.textNomeClienteVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textNomeClienteVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textNomeClienteVendas.Depth = 0;
            this.textNomeClienteVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textNomeClienteVendas.HideSelection = true;
            this.textNomeClienteVendas.Hint = "Nome Cliente";
            this.textNomeClienteVendas.LeadingIcon = null;
            this.textNomeClienteVendas.Location = new System.Drawing.Point(43, 165);
            this.textNomeClienteVendas.MaxLength = 32767;
            this.textNomeClienteVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.textNomeClienteVendas.Name = "textNomeClienteVendas";
            this.textNomeClienteVendas.PasswordChar = '\0';
            this.textNomeClienteVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textNomeClienteVendas.PrefixSuffixText = null;
            this.textNomeClienteVendas.ReadOnly = true;
            this.textNomeClienteVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textNomeClienteVendas.SelectedText = "";
            this.textNomeClienteVendas.SelectionLength = 0;
            this.textNomeClienteVendas.SelectionStart = 0;
            this.textNomeClienteVendas.ShortcutsEnabled = true;
            this.textNomeClienteVendas.Size = new System.Drawing.Size(302, 48);
            this.textNomeClienteVendas.TabIndex = 5;
            this.textNomeClienteVendas.TabStop = false;
            this.textNomeClienteVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textNomeClienteVendas.TrailingIcon = null;
            this.textNomeClienteVendas.UseSystemPasswordChar = false;
            // 
            // textQuantidadeVendas
            // 
            this.textQuantidadeVendas.AnimateReadOnly = false;
            this.textQuantidadeVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textQuantidadeVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textQuantidadeVendas.Depth = 0;
            this.textQuantidadeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textQuantidadeVendas.HideSelection = true;
            this.textQuantidadeVendas.Hint = "QTD Estoque";
            this.textQuantidadeVendas.LeadingIcon = null;
            this.textQuantidadeVendas.Location = new System.Drawing.Point(438, 106);
            this.textQuantidadeVendas.MaxLength = 32767;
            this.textQuantidadeVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.textQuantidadeVendas.Name = "textQuantidadeVendas";
            this.textQuantidadeVendas.PasswordChar = '\0';
            this.textQuantidadeVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.textQuantidadeVendas.PrefixSuffixText = null;
            this.textQuantidadeVendas.ReadOnly = true;
            this.textQuantidadeVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textQuantidadeVendas.SelectedText = "";
            this.textQuantidadeVendas.SelectionLength = 0;
            this.textQuantidadeVendas.SelectionStart = 0;
            this.textQuantidadeVendas.ShortcutsEnabled = true;
            this.textQuantidadeVendas.Size = new System.Drawing.Size(124, 48);
            this.textQuantidadeVendas.TabIndex = 3;
            this.textQuantidadeVendas.TabStop = false;
            this.textQuantidadeVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textQuantidadeVendas.TrailingIcon = null;
            this.textQuantidadeVendas.UseSystemPasswordChar = false;
            // 
            // btn_buscaClienteVenda
            // 
            this.btn_buscaClienteVenda.Depth = 0;
            this.btn_buscaClienteVenda.Icon = ((System.Drawing.Image)(resources.GetObject("btn_buscaClienteVenda.Icon")));
            this.btn_buscaClienteVenda.Location = new System.Drawing.Point(779, 26);
            this.btn_buscaClienteVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscaClienteVenda.Name = "btn_buscaClienteVenda";
            this.btn_buscaClienteVenda.Size = new System.Drawing.Size(56, 56);
            this.btn_buscaClienteVenda.TabIndex = 26;
            this.btn_buscaClienteVenda.Text = "materialFloatingActionButton13";
            this.btn_buscaClienteVenda.UseVisualStyleBackColor = true;
            this.btn_buscaClienteVenda.Click += new System.EventHandler(this.btn_buscaClienteVenda_Click);
            // 
            // materialCard27
            // 
            this.materialCard27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard27.Controls.Add(this.TextBucarClienteVendas);
            this.materialCard27.Depth = 0;
            this.materialCard27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard27.Location = new System.Drawing.Point(458, 17);
            this.materialCard27.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard27.Name = "materialCard27";
            this.materialCard27.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard27.Size = new System.Drawing.Size(351, 72);
            this.materialCard27.TabIndex = 10;
            // 
            // TextBucarClienteVendas
            // 
            this.TextBucarClienteVendas.AllowPromptAsInput = true;
            this.TextBucarClienteVendas.AnimateReadOnly = false;
            this.TextBucarClienteVendas.AsciiOnly = false;
            this.TextBucarClienteVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBucarClienteVendas.BeepOnError = false;
            this.TextBucarClienteVendas.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBucarClienteVendas.Depth = 0;
            this.TextBucarClienteVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBucarClienteVendas.HidePromptOnLeave = false;
            this.TextBucarClienteVendas.HideSelection = true;
            this.TextBucarClienteVendas.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBucarClienteVendas.LeadingIcon = null;
            this.TextBucarClienteVendas.Location = new System.Drawing.Point(17, 12);
            this.TextBucarClienteVendas.Mask = "";
            this.TextBucarClienteVendas.MaxLength = 32767;
            this.TextBucarClienteVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBucarClienteVendas.Name = "TextBucarClienteVendas";
            this.TextBucarClienteVendas.PasswordChar = '\0';
            this.TextBucarClienteVendas.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            this.TextBucarClienteVendas.PrefixSuffixText = "CPF:";
            this.TextBucarClienteVendas.PromptChar = '_';
            this.TextBucarClienteVendas.ReadOnly = false;
            this.TextBucarClienteVendas.RejectInputOnFirstFailure = false;
            this.TextBucarClienteVendas.ResetOnPrompt = true;
            this.TextBucarClienteVendas.ResetOnSpace = true;
            this.TextBucarClienteVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBucarClienteVendas.SelectedText = "";
            this.TextBucarClienteVendas.SelectionLength = 0;
            this.TextBucarClienteVendas.SelectionStart = 0;
            this.TextBucarClienteVendas.ShortcutsEnabled = true;
            this.TextBucarClienteVendas.Size = new System.Drawing.Size(298, 48);
            this.TextBucarClienteVendas.SkipLiterals = true;
            this.TextBucarClienteVendas.TabIndex = 2;
            this.TextBucarClienteVendas.TabStop = false;
            this.TextBucarClienteVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBucarClienteVendas.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBucarClienteVendas.TrailingIcon = null;
            this.TextBucarClienteVendas.UseSystemPasswordChar = false;
            this.TextBucarClienteVendas.ValidatingType = null;
            // 
            // NumericoQuantidadeDesejada
            // 
            this.NumericoQuantidadeDesejada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericoQuantidadeDesejada.Location = new System.Drawing.Point(681, 165);
            this.NumericoQuantidadeDesejada.Name = "NumericoQuantidadeDesejada";
            this.NumericoQuantidadeDesejada.Size = new System.Drawing.Size(128, 47);
            this.NumericoQuantidadeDesejada.TabIndex = 7;
            // 
            // btn_buscaProdutoVenda
            // 
            this.btn_buscaProdutoVenda.Depth = 0;
            this.btn_buscaProdutoVenda.Icon = ((System.Drawing.Image)(resources.GetObject("btn_buscaProdutoVenda.Icon")));
            this.btn_buscaProdutoVenda.Location = new System.Drawing.Point(367, 26);
            this.btn_buscaProdutoVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_buscaProdutoVenda.Name = "btn_buscaProdutoVenda";
            this.btn_buscaProdutoVenda.Size = new System.Drawing.Size(56, 56);
            this.btn_buscaProdutoVenda.TabIndex = 25;
            this.btn_buscaProdutoVenda.Text = "materialFloatingActionButton12";
            this.btn_buscaProdutoVenda.UseVisualStyleBackColor = true;
            this.btn_buscaProdutoVenda.Click += new System.EventHandler(this.btn_buscaProdutoVenda_Click);
            // 
            // materialCard26
            // 
            this.materialCard26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard26.Controls.Add(this.TextBucarProdutoVendas);
            this.materialCard26.Depth = 0;
            this.materialCard26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard26.Location = new System.Drawing.Point(43, 17);
            this.materialCard26.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard26.Name = "materialCard26";
            this.materialCard26.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard26.Size = new System.Drawing.Size(351, 72);
            this.materialCard26.TabIndex = 0;
            // 
            // TextBucarProdutoVendas
            // 
            this.TextBucarProdutoVendas.AnimateReadOnly = false;
            this.TextBucarProdutoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBucarProdutoVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBucarProdutoVendas.Depth = 0;
            this.TextBucarProdutoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBucarProdutoVendas.HideSelection = true;
            this.TextBucarProdutoVendas.Hint = "Busca por Produto";
            this.TextBucarProdutoVendas.LeadingIcon = null;
            this.TextBucarProdutoVendas.Location = new System.Drawing.Point(17, 12);
            this.TextBucarProdutoVendas.MaxLength = 32767;
            this.TextBucarProdutoVendas.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBucarProdutoVendas.Name = "TextBucarProdutoVendas";
            this.TextBucarProdutoVendas.PasswordChar = '\0';
            this.TextBucarProdutoVendas.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.TextBucarProdutoVendas.PrefixSuffixText = null;
            this.TextBucarProdutoVendas.ReadOnly = false;
            this.TextBucarProdutoVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBucarProdutoVendas.SelectedText = "";
            this.TextBucarProdutoVendas.SelectionLength = 0;
            this.TextBucarProdutoVendas.SelectionStart = 0;
            this.TextBucarProdutoVendas.ShortcutsEnabled = true;
            this.TextBucarProdutoVendas.Size = new System.Drawing.Size(297, 48);
            this.TextBucarProdutoVendas.TabIndex = 0;
            this.TextBucarProdutoVendas.TabStop = false;
            this.TextBucarProdutoVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBucarProdutoVendas.TrailingIcon = null;
            this.TextBucarProdutoVendas.UseSystemPasswordChar = false;
            this.TextBucarProdutoVendas.Click += new System.EventHandler(this.TextBucarProdutoVendas_Click);
            // 
            // RELATÓRIOS
            // 
            this.RELATÓRIOS.Controls.Add(this.materialCard32);
            this.RELATÓRIOS.Controls.Add(this.materialCard31);
            this.RELATÓRIOS.ImageKey = "RELATORIOS.png";
            this.RELATÓRIOS.Location = new System.Drawing.Point(4, 39);
            this.RELATÓRIOS.Name = "RELATÓRIOS";
            this.RELATÓRIOS.Size = new System.Drawing.Size(1587, 727);
            this.RELATÓRIOS.TabIndex = 4;
            this.RELATÓRIOS.Text = "   RELATÓRIOS";
            this.RELATÓRIOS.UseVisualStyleBackColor = true;
            // 
            // materialCard32
            // 
            this.materialCard32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard32.Depth = 0;
            this.materialCard32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard32.Location = new System.Drawing.Point(402, 14);
            this.materialCard32.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard32.Name = "materialCard32";
            this.materialCard32.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard32.Size = new System.Drawing.Size(1171, 699);
            this.materialCard32.TabIndex = 1;
            // 
            // materialCard31
            // 
            this.materialCard31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard31.Controls.Add(this.groupBox11);
            this.materialCard31.Controls.Add(this.dateTimePickerFim);
            this.materialCard31.Controls.Add(this.dateTimePickerInicio);
            this.materialCard31.Controls.Add(this.Btn_GerarRelatorio);
            this.materialCard31.Controls.Add(this.groupBox10);
            this.materialCard31.Depth = 0;
            this.materialCard31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard31.Location = new System.Drawing.Point(14, 14);
            this.materialCard31.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard31.Name = "materialCard31";
            this.materialCard31.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard31.Size = new System.Drawing.Size(360, 699);
            this.materialCard31.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.listViewOpcoesRelatorios);
            this.groupBox11.Location = new System.Drawing.Point(26, 27);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(303, 485);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "RELATÓRIOS";
            // 
            // listViewOpcoesRelatorios
            // 
            this.listViewOpcoesRelatorios.HideSelection = false;
            this.listViewOpcoesRelatorios.Location = new System.Drawing.Point(14, 19);
            this.listViewOpcoesRelatorios.Name = "listViewOpcoesRelatorios";
            this.listViewOpcoesRelatorios.Size = new System.Drawing.Size(275, 448);
            this.listViewOpcoesRelatorios.TabIndex = 0;
            this.listViewOpcoesRelatorios.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFim.Location = new System.Drawing.Point(208, 572);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerFim.TabIndex = 2;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(40, 572);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerInicio.TabIndex = 1;
            // 
            // Btn_GerarRelatorio
            // 
            this.Btn_GerarRelatorio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_GerarRelatorio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_GerarRelatorio.Depth = 0;
            this.Btn_GerarRelatorio.HighEmphasis = true;
            this.Btn_GerarRelatorio.Icon = null;
            this.Btn_GerarRelatorio.Location = new System.Drawing.Point(100, 619);
            this.Btn_GerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_GerarRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_GerarRelatorio.Name = "Btn_GerarRelatorio";
            this.Btn_GerarRelatorio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_GerarRelatorio.Size = new System.Drawing.Size(149, 36);
            this.Btn_GerarRelatorio.TabIndex = 0;
            this.Btn_GerarRelatorio.Text = "Gerar Relatório";
            this.Btn_GerarRelatorio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_GerarRelatorio.UseAccentColor = false;
            this.Btn_GerarRelatorio.UseVisualStyleBackColor = true;
            this.Btn_GerarRelatorio.Click += new System.EventHandler(this.Btn_GerarRelatorio_Click_1);
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(26, 528);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(303, 154);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "INTERVALO";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RELATORIOS.png");
            this.imageList1.Images.SetKeyName(1, "VENDAS.png");
            this.imageList1.Images.SetKeyName(2, "HOME.png");
            this.imageList1.Images.SetKeyName(3, "CLIENTES.png");
            this.imageList1.Images.SetKeyName(4, "PRODUTOS.png");
            this.imageList1.Images.SetKeyName(5, "CONFIG.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "BUSCAR.png");
            this.imageList2.Images.SetKeyName(1, "SALVAR.png");
            this.imageList2.Images.SetKeyName(2, "EXCLUIR.png");
            this.imageList2.Images.SetKeyName(3, "NOVO.png");
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 837);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRESA X - ANALYTICS";
            CONEXÃO_BD.ResumeLayout(false);
            CONEXÃO_BD.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.HOME.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard11.ResumeLayout(false);
            this.materialCard11.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.CLIENTES.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.materialCard16.ResumeLayout(false);
            this.materialCard16.PerformLayout();
            this.materialCard17.ResumeLayout(false);
            this.materialCard17.PerformLayout();
            this.materialCard18.ResumeLayout(false);
            this.materialCard18.PerformLayout();
            this.materialCard19.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PRODUTOS.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.materialCard15.ResumeLayout(false);
            this.materialCard15.PerformLayout();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            this.materialCard13.ResumeLayout(false);
            this.materialCard13.PerformLayout();
            this.materialCard12.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.VENDAS.ResumeLayout(false);
            this.materialCard30.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.materialCard22.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.materialCard21.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.materialCard23.ResumeLayout(false);
            this.materialCard23.PerformLayout();
            this.materialCard25.ResumeLayout(false);
            this.materialCard25.PerformLayout();
            this.materialCard20.ResumeLayout(false);
            this.materialCard20.PerformLayout();
            this.materialCard33.ResumeLayout(false);
            this.materialCard33.PerformLayout();
            this.materialCard29.ResumeLayout(false);
            this.materialCard28.ResumeLayout(false);
            this.materialCard28.PerformLayout();
            this.materialCard27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericoQuantidadeDesejada)).EndInit();
            this.materialCard26.ResumeLayout(false);
            this.RELATÓRIOS.ResumeLayout(false);
            this.materialCard31.ResumeLayout(false);
            this.materialCard31.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage HOME;
        private System.Windows.Forms.TabPage CLIENTES;
        private System.Windows.Forms.TabPage PRODUTOS;
        private System.Windows.Forms.TabPage VENDAS;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage RELATÓRIOS;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialTextBox2 TextValor;
        private MaterialSkin.Controls.MaterialTextBox2 TextProduto;
        private MaterialSkin.Controls.MaterialComboBox ComboUF;
        private MaterialSkin.Controls.MaterialTextBox2 TextLocalidade;
        private MaterialSkin.Controls.MaterialTextBox2 TextBairro;
        private MaterialSkin.Controls.MaterialTextBox2 TextComplemento;
        private MaterialSkin.Controls.MaterialTextBox2 TextLogradouro;
        private MaterialSkin.Controls.MaterialTextBox2 TextEmail;
        private MaterialSkin.Controls.MaterialTextBox2 TextNomeCompleto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TextDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private System.Windows.Forms.Label Label_Totaldevendas;
        private System.Windows.Forms.Label Label_QuantidadeDeVendidos;
        private System.Windows.Forms.Label Label_TotalDeClientesAtivos;
        private System.Windows.Forms.Label Label_TotalDeItensEmEstoque;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_SalvarProduto;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_NovoProduto;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_BuscaProduto;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_deletarProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_ExcluirCliente;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_SalvarCliente;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_NovoCliente;
        private MaterialSkin.Controls.MaterialFloatingActionButton BTN_BuscaClientes;
        private MaterialSkin.Controls.MaterialCard materialCard16;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard17;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard18;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard19;
        private MaterialSkin.Controls.MaterialTextBox2 TextBuscaProduto;
        private System.Windows.Forms.ImageList imageList2;
        private MaterialSkin.Controls.MaterialCard materialCard22;
        private MaterialSkin.Controls.MaterialCard materialCard21;
        private MaterialSkin.Controls.MaterialCard materialCard20;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_Finalizarpedido;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_novopedido;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_buscaProdutoVenda;
        private MaterialSkin.Controls.MaterialCard materialCard23;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard25;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialCard materialCard26;
        private MaterialSkin.Controls.MaterialTextBox2 TextBucarProdutoVendas;
        private System.Windows.Forms.NumericUpDown NumericoQuantidadeDesejada;
        private MaterialSkin.Controls.MaterialTextBox2 textQuantidadeVendas;
        private MaterialSkin.Controls.MaterialTextBox2 textProdutoVendas;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_buscaClienteVenda;
        private MaterialSkin.Controls.MaterialCard materialCard27;
        private MaterialSkin.Controls.MaterialTextBox2 textNomeClienteVendas;
        private MaterialSkin.Controls.MaterialCard materialCard30;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_adicionarPedido;
        private MaterialSkin.Controls.MaterialCard materialCard28;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialCard materialCard29;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.ListView listViewVendas;
        private System.Windows.Forms.ListView listViewPedidosEmAndamento;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListView listViewClientes;
        private MaterialSkin.Controls.MaterialCard materialCard32;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialCard materialCard31;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialButton Btn_GerarRelatorio;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView listViewOpcoesRelatorios;
        public MaterialSkin.Controls.MaterialTextBox2 campo_database;
        public MaterialSkin.Controls.MaterialTextBox2 campo_password;
        public MaterialSkin.Controls.MaterialTextBox2 campo_username;
        public MaterialSkin.Controls.MaterialTextBox2 campo_port;
        public MaterialSkin.Controls.MaterialTextBox2 campo_host;
        private MaterialSkin.Controls.MaterialButton Btn_testar_conexao;
        private MaterialSkin.Controls.MaterialButton btn_salvarconfig;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextTelefone;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextCEP;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextCPF;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextQuatidade;
        private MaterialSkin.Controls.MaterialMaskedTextBox Text_buscaCliente;
        private MaterialSkin.Controls.MaterialTextBox2 textValorVendas;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBucarClienteVendas;
        private MaterialSkin.Controls.MaterialTextBox2 textCPFVendas;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_RetirarSelecionados;
        private MaterialSkin.Controls.MaterialCard materialCard33;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel LabelStatus;
        private MaterialSkin.Controls.MaterialLabel LabelStatusCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}