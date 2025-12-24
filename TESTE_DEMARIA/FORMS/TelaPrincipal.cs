using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using TESTE_DEMARIA.CLASSES.BASE_DE_DADOS;
using TESTE_DEMARIA.CLASSES.OBJETOS;
using TESTE_DEMARIA.CLASSES.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TESTE_DEMARIA.CLASSES.Utils.ConsultaCEP;
using static TESTE_DEMARIA.CLASSES.Utils.ValidarCPF;


namespace TESTE_DEMARIA.FORMS
{
    public partial class TelaPrincipal : MaterialForm
    {

        public string Host {  get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }

        public TelaPrincipal()
        {
            InitializeComponent();

            #region CONFIGURAÇÕES DE INICIO

            //ATUALIZA INFORMAÇÕES HOME
            AtualizarTotaldeVendasHOME();
            AtualizarTotaldeEstoqueHOME();
            AtualizarTotaldeAtivosHOME();
            AtualizaritemsvendidosHOME();

            //ATUALIZA LISTVIEWS
            AtualizarListviewClientes();
            AtualizarListviewProdutos();
            AtualizarListviewVendas();

            //CONFIG DE INTERFACE MATERIALSKIN
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            //CONFIG ELEMENTOS 
            Label_Totaldevendas.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            Label_TotalDeItensEmEstoque.Font = new Font("Segoe UI", 50, FontStyle.Bold);
            Label_TotalDeClientesAtivos.Font = new Font("Segoe UI", 50, FontStyle.Bold);
            Label_QuantidadeDeVendidos.Font = new Font("Segoe UI", 50, FontStyle.Bold);
            LabelTotal.Font = new Font("Segoe UI", 22, FontStyle.Bold);
          
            NumericUpDown numerico = NumericoQuantidadeDesejada;
            numerico.Controls[1].Font = new Font("Arial", 25, FontStyle.Bold);

            NumericoQuantidadeDesejada.Font = new Font("Arial", 25, FontStyle.Bold);
            listViewOpcoesRelatorios.View = View.List; 
            listViewOpcoesRelatorios.Items.Clear();   
            listViewOpcoesRelatorios.Font = new Font("Segoe UI", 18, FontStyle.Regular);

            //CARRREGA LISTA DE 'RELATORIOS' ASSIM QUE INICIA
            List<string> relatorios = new List<string> { "Relatório de vendas", "Relatório de Clientes", "Relatório de Produtos" };
            foreach (string relatorio in relatorios)
            {
                var item = new ListViewItem(relatorio);
                listViewOpcoesRelatorios.Items.Add(item);
            }

            //CARRREGA LISTA DE 'UF' ASSIM QUE INICIA
            List<string> ufs = new List<string>
            {
                "UF","AC","AL","AP","AM","BA","CE","DF","ES","GO","MA",
                "MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN",
                "RS","RO","RR","SC","SP","SE","TO"
            };

            foreach (string uf in ufs)
            {
                ComboUF.Items.Add(uf);
            }
            ComboUF.SelectedIndex = 0;

            //MASCARAS
            TextCEP.Mask = "00000-000";
            TextTelefone.Mask = "(00)00000-0000";
            TextCPF.Mask = "000,000,000-00";
            TextBucarClienteVendas.Mask = "000,000,000-00";
            Text_buscaCliente.Mask = "000,000,000-00";
            TextNum.Mask = "000000000000000";
            TextNum.PromptChar = ' ';
            TextQuatidade.Mask = "000000000000000";
            TextQuatidade.PromptChar = ' ';

            this.ActiveControl = TextNomeCompleto;


            TextNomeCompleto.TabIndex = 0;
            TextCPF.TabIndex = 1;
            TextEmail.TabIndex = 2;
            TextTelefone.TabIndex = 3;
            TextCEP.TabIndex = 4;
            TextLogradouro.TabIndex = 5;
            TextNum.TabIndex = 6;
            TextComplemento.TabIndex = 7;
            TextBairro.TabIndex = 8;
            TextLocalidade.TabIndex = 9;
            ComboUF.TabIndex = 10;
            Text_buscaCliente.TabIndex = 11;

            TextBucarProdutoVendas.TabIndex = 0;
            TextBucarClienteVendas.TabIndex = 1;
            textProdutoVendas.TabIndex = 2;
            textQuantidadeVendas.TabIndex = 3;
            textValorVendas.TabIndex = 4;
            textNomeClienteVendas.TabIndex = 5;
            textCPFVendas.TabIndex = 6;
            NumericoQuantidadeDesejada.TabIndex = 7;

            #endregion
        }

        #region METODOS UTILIZADOS
        public void AtualizarTotaldeVendasHOME()
        {
            var comando = new VendasSQL();
            decimal total = comando.ObterTotalDeVendas();
            Label_Totaldevendas.Text = ("R$ " + total.ToString());

        }

        public void AtualizarTotaldeEstoqueHOME()
        {
            var comando = new ProdutoSQL();
            int total = comando.ObterQtdItemsEmEstoque();
            Label_TotalDeItensEmEstoque.Text = total.ToString();

        }

        public void AtualizarTotaldeAtivosHOME()
        {
            var comando = new ClienteSQL();
            int total = comando.ObterQtdClientesAtivos();
            Label_TotalDeClientesAtivos.Text = total.ToString();

        }

        public void AtualizaritemsvendidosHOME()
        {
            var comando = new VendasSQL();
            int total = comando.ObterQtdItemsVendidos();
            Label_QuantidadeDeVendidos.Text = total.ToString();
        }

        public void AtualizarListviewClientes()
        {
            listViewClientes.Columns.Clear();
            listViewClientes.Items.Clear();
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("Nome", 250);
            listViewClientes.Columns.Add("Email", 250);
            listViewClientes.Columns.Add("Telefone", 100);
            listViewClientes.Columns.Add("CPF", 120);
            listViewClientes.Columns.Add("Logradouro", 150);
            listViewClientes.Columns.Add("Número", 80);
            listViewClientes.Columns.Add("Complemento", 100);
            listViewClientes.Columns.Add("Bairro", 120);
            listViewClientes.Columns.Add("Localidade", 120);
            listViewClientes.Columns.Add("UF", 50);
            listViewClientes.Columns.Add("CEP", 100);
            listViewClientes.Columns.Add("Data Cadastro", 100);
            var comandos2 = new ClienteSQL();
            comandos2.CarregarClientes(listViewClientes);
        }

        public void AtualizarListviewVendas()
        {
            listViewVendas.Columns.Clear();
            listViewVendas.Items.Clear();
            listViewVendas.View = View.Details;
            listViewVendas.Columns.Add("ID Venda", 100);
            listViewVendas.Columns.Add("ID Cliente", 100);
            listViewVendas.Columns.Add("Data Venda", 200);
            listViewVendas.Columns.Add("Valor total", 100);

            var comando = new VendasSQL();
            comando.CarregarVendas(listViewVendas);
        }

        private void LimparCamposVendas()
        {
            TextBucarProdutoVendas.Clear();
            TextBucarClienteVendas.Clear();
            textProdutoVendas.Clear();
            textQuantidadeVendas.Clear();
            textValorVendas.Clear();
            textNomeClienteVendas.Clear();
            textCPFVendas.Clear();
            NumericoQuantidadeDesejada.Value = 0;
            LabelTotal.Text = "R$ 00,00";
        }

        private void LimparCamposProdutos()
        {
            TextProduto.Clear();
            TextValor.Clear();
            TextQuatidade.Clear();
            TextDescricao.Clear();
            TextBuscaProduto.Clear();
            LabelStatus.Text = "STATUS DO PRODUTO:";
        }

        private void LimparCamposClientes()
        {
            TextNomeCompleto.Clear();
            TextCPF.Clear();
            TextEmail.Clear();
            TextTelefone.Clear();
            TextCEP.Clear();
            TextLogradouro.Clear();
            TextNum.Clear();
            TextComplemento.Clear();
            TextBairro.Clear();
            TextLocalidade.Clear();
            Text_buscaCliente.Clear();
            ComboUF.SelectedIndex = 0;
            LabelStatusCliente.Text = "STATUS DO CLIENTE:";
        }

        public void AtualizarListviewProdutos()
        {
            listViewProdutos.Columns.Clear();
            listViewProdutos.Items.Clear();
            listViewProdutos.View = View.Details;
            listViewProdutos.Columns.Add("Nome", 200);
            listViewProdutos.Columns.Add("Descricao", 300);
            listViewProdutos.Columns.Add("Valor", 100);
            listViewProdutos.Columns.Add("Estoque", 120);
            listViewProdutos.Columns.Add("Criado em", 150);

            var comandos2 = new ProdutoSQL();
            comandos2.CarregarProduto(listViewProdutos);
        }

        #endregion

        #region RELATORIOS REPORT REVIEWER

        //GERA O RELATORIO SELECIONADO
        private void Btn_GerarRelatorio_Click_1(object sender, EventArgs e)
        {
            if (listViewOpcoesRelatorios.SelectedIndices.Count > 0)
            {
                int indiceSelecionado = listViewOpcoesRelatorios.SelectedIndices[0];

                if (indiceSelecionado == 0)
                {
                    var comando = new FiltrosReportReviewerSQL();
                    DateTime datainicio = dateTimePickerInicio.Value.Date.AddHours(00).AddMinutes(00).AddSeconds(59); ;
                    DateTime datafim = dateTimePickerFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                    DataTable dtVendas = comando.ObterDadosDasVendas(datainicio, datafim);
                    ReportViewer rv = new ReportViewer();
                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.Dock = DockStyle.Fill;

                    rv.LocalReport.ReportPath = Application.StartupPath + @"\RELATORIOS\VendasFinalizadas.rdlc";
                    rv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSetVendas", dtVendas);
                    rv.LocalReport.DataSources.Add(rds);

                    rv.RefreshReport();
          
                    materialCard32.Controls.Clear();
                    materialCard32.Controls.Add(rv);
                }
                else if (indiceSelecionado == 1)
                {
                    var comando = new FiltrosReportReviewerSQL();
                    DataTable dtClientes = comando.ObterDadosClientes();

                    ReportViewer rv = new ReportViewer();
                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.Dock = DockStyle.Fill;
                    rv.LocalReport.ReportPath = Application.StartupPath + @"\RELATORIOS\CadastroClientes.rdlc";
                    rv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSetClientes", dtClientes);
                    rv.LocalReport.DataSources.Add(rds);

                    rv.RefreshReport();

                    materialCard32.Controls.Clear();
                    materialCard32.Controls.Add(rv);
                }
                else if (indiceSelecionado == 2)
                {
                    var comando = new FiltrosReportReviewerSQL();
                    DataTable dtClientes = comando.ObterDadosProduto();

                    ReportViewer rv = new ReportViewer();
                    rv.ProcessingMode = ProcessingMode.Local;
                    rv.Dock = DockStyle.Fill;
                    rv.LocalReport.ReportPath = Application.StartupPath + @"\RELATORIOS\CadastroProdutos.rdlc";
                    rv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSetProdutos", dtClientes);
                    rv.LocalReport.DataSources.Add(rds);

                    rv.RefreshReport();

                    materialCard32.Controls.Clear();
                    materialCard32.Controls.Add(rv);
                }

            }
            else
            {
                MessageBox.Show("Selecione o relatório que deseja.", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        #endregion

        #region TELA DE CONFIG CONEXAO
        private void Btn_testar_conexao_Click(object sender, EventArgs e)
        {
            var teste = new TesteCon();

            try
            {
                teste.TestarConexao();
                MessageBox.Show("Conexão realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
        }

        private void btn_salvarconfig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(campo_host.Text))
            {
                MessageBox.Show("Campo host está vazio", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(campo_port.Text))
            {
                MessageBox.Show("Campo port está vazio", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(campo_username.Text))
            {
                MessageBox.Show("Campo Username está vazio", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(campo_password.Text))
            {
                MessageBox.Show("Campo Password está vazio", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(campo_database.Text))
            {
                MessageBox.Show("Campo Data Base está vazio", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dados = new
                {
                    Host = campo_host.Text,
                    Port = campo_port.Text,
                    UserName = campo_username.Text,
                    Password = campo_password.Text,
                    DataBase = campo_database.Text
                };

                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados_form.json");
                string json = JsonConvert.SerializeObject(dados, Formatting.Indented);

                File.WriteAllText(caminho, json);
                MessageBox.Show($"Informações salvas em: {caminho}");

                MessageBox.Show("Conexão pronta: ", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #endregion

        #region CADASTRO DE CLIENTES

        private void BTN_NovoCliente_Click(object sender, EventArgs e)
        {

            LimparCamposClientes();
        }

        private void BTN_SalvarCliente_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(TextNomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(TextEmail.Text) ||
                string.IsNullOrWhiteSpace(TextTelefone.Text) ||
                string.IsNullOrWhiteSpace(TextCPF.Text) ||
                string.IsNullOrWhiteSpace(TextLogradouro.Text) ||
                string.IsNullOrWhiteSpace(TextNum.Text) ||
                string.IsNullOrWhiteSpace(TextComplemento.Text) ||
                string.IsNullOrWhiteSpace(TextBairro.Text) ||
                string.IsNullOrWhiteSpace(TextLocalidade.Text) ||
                string.IsNullOrWhiteSpace(ComboUF.Text) ||
                string.IsNullOrWhiteSpace(TextCEP.Text))

            {
                MessageBox.Show("1 ou mais campos estão vazios! \n\n Por favor preencha todos.", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                var cliente = new Cliente
                {
                    Nome = TextNomeCompleto.Text,
                    Email = TextEmail.Text,
                    Telefone = TextTelefone.Text,
                    Cpf = TextCPF.Text,
                    Logradouro = TextLogradouro.Text,
                    Numero = TextNum.Text,
                    Complemento = TextComplemento.Text,
                    Bairro = TextBairro.Text,
                    Localidade = TextLocalidade.Text,
                    Uf = ComboUF.Text,
                    Cep = TextCEP.Text
                  };
     

                var clienteSQL = new ClienteSQL();
                clienteSQL.SalvarCliente1(cliente);


                AtualizarListviewClientes();
            }
            LimparCamposClientes();
        }

        private void BTN_BuscaClientes_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Text_buscaCliente.Text))
            {

                var clienteSQL = new ClienteSQL();
                var cliente = clienteSQL.BuscarClientePorCPF1(Text_buscaCliente.Text);

                if (cliente != null)
                {
                    TextNomeCompleto.Text = cliente.Nome;
                    TextEmail.Text = cliente.Email;
                    TextTelefone.Text = cliente.Telefone;
                    TextCPF.Text = cliente.Cpf;
                    TextLogradouro.Text = cliente.Logradouro;
                    TextNum.Text = cliente.Numero;
                    TextComplemento.Text = cliente.Complemento;
                    TextBairro.Text = cliente.Bairro;
                    TextLocalidade.Text = cliente.Localidade;
                    ComboUF.Text = cliente.Uf;
                    TextCEP.Text = cliente.Cep;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }



                ComboUF.Refresh();

                if (cliente.Ativo == true)
                {
                    LabelStatusCliente.Text = "STATUS DO CLIENTE: ATIVO";
                }
                else
                {
                    LabelStatusCliente.Text = "STATUS DO CLIENTE: INATIVO";
                }

            }
            else
            {
                MessageBox.Show("Preencha o campo 'Busca por CPF'.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_ExcluirCliente_Click(object sender, EventArgs e)
        {

            var resultado = MessageBox.Show(
            "Tem certeza que deseja deletar este cliente?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if ( resultado == DialogResult.Yes)
            {
                var clienteSQL = new ClienteSQL();
                clienteSQL.DeletarClientePorCPF1(TextCPF.Text);
                AtualizarListviewClientes();
            }
            LimparCamposClientes();
        }

        private void TextCPF_Leave(object sender, EventArgs e)
        {
            var resultado = CPFValidator.Validar(TextCPF.Text);

            if (!resultado.IsValid)
            {
                MessageBox.Show(resultado.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region CADASTRO DE PRODUTOS
        private void btn_SalvarProduto_Click_1(object sender, EventArgs e)
        {

                if (Regex.IsMatch(TextValor.Text, @"^\d+([.,]\d+)?$"))
                {
                    string texto = TextValor.Text.Replace(",", ".");
                    float valor = float.Parse(texto, System.Globalization.CultureInfo.InvariantCulture);
                    int quantidade = Convert.ToInt32(TextQuatidade.Text.Replace(" ", ""));

                var produto = new Produto
                {
                    Nome = TextProduto.Text,
                    Descricao = TextDescricao.Text,
                    Valor = valor,
                    Estoque = quantidade,
                };


                var produtoSQL = new ProdutoSQL();
                produtoSQL.SalvarProduto1(produto);

                AtualizarListviewProdutos();
                }
                else
                {
                    MessageBox.Show("Digite apenas números com '.' ou ',' para separar decimais.", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            LimparCamposProdutos();


        }

        private void btn_BuscaProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBuscaProduto.Text))
            {

                var produtoSQL = new ProdutoSQL();
                var produto = produtoSQL.BuscarProdutoPorNome1(TextBuscaProduto.Text);

                if (produto != null)
                {
                    TextProduto.Text = produto.Nome;
                    TextDescricao.Text = produto.Descricao;
                    TextValor.Text = produto.Valor.ToString();
                    TextQuatidade.Text = produto.Estoque.ToString();

                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                }



                if (produto.Ativo == true)
                {
                    LabelStatus.Text = "STATUS DO PRODUTO: ATIVO";
                }
                else
                {
                    LabelStatus.Text = "STATUS DO PRODUTO: INATIVO";
                }
                
            }
            else
            {
                MessageBox.Show("Preencha o campo 'Busca por produto'.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_NovoProduto_Click(object sender, EventArgs e)
        {
            LimparCamposProdutos();
        }

        private async void TextCEP_Leave(object sender, EventArgs e)
        {
            string cep = TextCEP.Text.Trim();

            if (string.IsNullOrEmpty(cep))
                return;

            var busca = new BuscaCEP();
            var endereco = await busca.ObterEnderecoAsync(cep);

            if (endereco != null)
            {
                TextLogradouro.Text = endereco.logradouro;
                TextBairro.Text = endereco.bairro;
                TextLocalidade.Text = endereco.localidade;
                ComboUF.Text = endereco.uf;
                ComboUF.Refresh();
            }

        }

        private void btn_deletarProduto_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
            "Tem certeza que deseja deletar este produto?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                var produtoSQL = new ProdutoSQL();
                produtoSQL.DeletarProdutoPorNome1(TextProduto.Text);
                AtualizarListviewProdutos();
            }
            LimparCamposProdutos();
        }
        #endregion

        #region TELA DE VENDAS
        private void btn_buscaProdutoVenda_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TextBucarProdutoVendas.Text))
            {
                var comandos = new ProdutoSQL();
                comandos.BuscarProdutoPorNomeVendas(
                    TextBucarProdutoVendas.Text,
                    textProdutoVendas,
                    textValorVendas,
                    textQuantidadeVendas

                );
            }
            else
            {
                MessageBox.Show($"Campo pesquisa estoque vazio. \n\nPreencha o campo para buscar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscaClienteVenda_Click(object sender, EventArgs e)
        {

                var comandos = new ClienteSQL();
                comandos.BuscarClientePorNomeVendas(
                    TextBucarClienteVendas.Text,
                    textNomeClienteVendas,
                    textCPFVendas

                );
  
        }

        private void btn_adicionarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProdutoVendas.Text) ||
            string.IsNullOrWhiteSpace(textQuantidadeVendas.Text) ||
            string.IsNullOrWhiteSpace(textValorVendas.Text) ||
            string.IsNullOrWhiteSpace(textNomeClienteVendas.Text) ||
            string.IsNullOrWhiteSpace(textCPFVendas.Text) ||
            string.IsNullOrWhiteSpace(NumericoQuantidadeDesejada.Text))

            {
                MessageBox.Show("1 ou mais campos estão vazios! \n\n Por favor preencha todos.", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                    int QTDadicionado =Convert.ToInt32(NumericoQuantidadeDesejada.Value);

                    var produtoSQL = new ProdutoSQL();
                    int EstoqueAtual = produtoSQL.ValidarEstoque1(textProdutoVendas.Text);
                    textQuantidadeVendas.Text = EstoqueAtual.ToString();

                if ( EstoqueAtual < QTDadicionado)
                    {
                        MessageBox.Show($"Sem itens suficiente em estoque. \n\nHá {EstoqueAtual.ToString()} disponiveis.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                    produtoSQL = new ProdutoSQL();
                    produtoSQL.AtualizarEstoque1(textProdutoVendas.Text, QTDadicionado);

                    }


                    int QtdItems = (int)NumericoQuantidadeDesejada.Value;

                    if (!string.IsNullOrEmpty(NumericoQuantidadeDesejada.Text) && NumericoQuantidadeDesejada.Value > 0)
                    {



                        float ValorUnitario = float.Parse(textValorVendas.Text);
                        float ValorTotal = QtdItems * ValorUnitario;
                        var itemExistente = listViewPedidosEmAndamento.Items
                            .Cast<ListViewItem>()
                            .FirstOrDefault(i => i.Text.Equals(textProdutoVendas.Text, StringComparison.OrdinalIgnoreCase));

                        if (itemExistente != null)
                        {
                            float qtdAtual = float.Parse(itemExistente.SubItems[2].Text);
                            float ValorAtual = float.Parse(itemExistente.SubItems[4].Text);
                            itemExistente.SubItems[2].Text = (qtdAtual + QtdItems).ToString();
                            itemExistente.SubItems[4].Text = (ValorAtual + ValorTotal).ToString();
                        }
                        else
                        {
                            produtoSQL = new ProdutoSQL();
                            int idproduto = produtoSQL.ObterIdProduto1(textProdutoVendas.Text);

                            listViewPedidosEmAndamento.CheckBoxes = true;
                            listViewPedidosEmAndamento.View = View.Details;
                            listViewPedidosEmAndamento.Columns.Add("PRODUTO", 220);
                            listViewPedidosEmAndamento.Columns.Add("ID", 220);
                            listViewPedidosEmAndamento.Columns.Add("QUANTIDADE", 100);
                            listViewPedidosEmAndamento.Columns.Add("VALOR UNITARIO", 150);
                            listViewPedidosEmAndamento.Columns.Add("VALOR TOTAL", 120);
                            listViewPedidosEmAndamento.Columns.Add("NOME CLIENTE", 150);
                            listViewPedidosEmAndamento.Columns.Add("CPF CLIENTE", 150);
                            listViewPedidosEmAndamento.Columns.Add("CPF CLIENTE", 150);

                            var item = new ListViewItem(textProdutoVendas.Text);
                            item.SubItems.Add(idproduto.ToString());
                            item.SubItems.Add(NumericoQuantidadeDesejada.Text.ToString());
                            item.SubItems.Add(textValorVendas.Text.ToString());
                            item.SubItems.Add(ValorTotal.ToString());
                            item.SubItems.Add(textNomeClienteVendas.Text.ToString());
                            item.SubItems.Add(textCPFVendas.Text.ToString());

                            listViewPedidosEmAndamento.Items.Add(item);
                        }

                        List<float> Valores = new List<float>();
                        foreach (ListViewItem item in listViewPedidosEmAndamento.Items)
                        {
                            float valor = float.Parse(item.SubItems[4].Text);
                            Valores.Add(valor);
                        }
                        float total = Valores.Sum();
                        LabelTotal.Text = "R$ " + total.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Quantidade de mercadorias invalida. \n\nColoque um valor maior que '0'.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                produtoSQL = new ProdutoSQL();
                EstoqueAtual = produtoSQL.ValidarEstoque1(textProdutoVendas.Text);
                textQuantidadeVendas.Text = EstoqueAtual.ToString();
            }   
        }

        private void btn_RetirarSelecionados_Click(object sender, EventArgs e)
        {
                               
            foreach (ListViewItem item in listViewPedidosEmAndamento.CheckedItems)
            {
                string qtd = item.SubItems[2].Text;
                string produto = item.SubItems[0].Text;
                int quantidade = Convert.ToInt32(qtd);

                var produtoSQL = new ProdutoSQL();
                produtoSQL.RetomarEstoque1(produto, quantidade);

                if (produto == textProdutoVendas.Text)
                {
                    produtoSQL = new ProdutoSQL();
                    int EstoqueAtual = produtoSQL.ValidarEstoque1(textProdutoVendas.Text);
                    textQuantidadeVendas.Text = EstoqueAtual.ToString();
                }

                listViewPedidosEmAndamento.Items.Remove(item);
            }
            List<float> Valores = new List<float>();
            foreach (ListViewItem item in listViewPedidosEmAndamento.Items)
            {
                float valor = float.Parse(item.SubItems[3].Text);
                Valores.Add(valor);
            }
            float total = Valores.Sum();
            LabelTotal.Text = "R$ " + total.ToString("F2");
        }

        private void btn_Finalizarpedido_Click(object sender, EventArgs e)
        {
       

            if (listViewPedidosEmAndamento.Items.Count == 0)
            {
                MessageBox.Show("Não há produtos adicionados para finalizar a compra.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                var cliente = new ClienteSQL();
                int idCliente = cliente.ObterIdCliente1(TextBucarClienteVendas.Text);
                string CapValor = LabelTotal.Text.Replace("R$ ", "");
                float ValorTotal = float.Parse(CapValor);

                var venda = new VendasSQL();
                int idVenda = venda.RegistrarVendaBase1(idCliente, ValorTotal);
                foreach (ListViewItem item in listViewPedidosEmAndamento.Items)
                {

                    int idproduto = Convert.ToInt32(item.SubItems[1].Text);
                    int Quatidade = Convert.ToInt32(item.SubItems[2].Text);
                    float valorunitario = float.Parse(item.SubItems[3].Text);
                    float valortotal = float.Parse(item.SubItems[4].Text);

                    venda = new VendasSQL();
                    venda.RegistrarVendaBase2(
                        idVenda,
                        idproduto,
                        Quatidade,
                        valorunitario,
                        valortotal

                    );
                } 

            }

            AtualizarListviewProdutos();
            LimparCamposVendas();
            listViewPedidosEmAndamento.Clear();
            AtualizarListviewVendas();

            MessageBox.Show("Pedido Finalizado!");
        }

        private void btn_novopedido_Click(object sender, EventArgs e)
        {

            TextBucarProdutoVendas.Clear();
            TextBucarClienteVendas.Clear();
            textProdutoVendas.Clear();
            textQuantidadeVendas.Clear();
            textValorVendas.Clear();
            textNomeClienteVendas.Clear();
            textCPFVendas.Clear();
            NumericoQuantidadeDesejada.Value = 0;
            LabelTotal.Text = "R$ 0,00";


            foreach (ListViewItem item in listViewPedidosEmAndamento.Items)
            {
                string qtd = item.SubItems[2].Text;
                string produto = item.SubItems[0].Text;
                int quantidade = Convert.ToInt32(qtd);

                var produtoSQL = new ProdutoSQL();
                produtoSQL.RetomarEstoque1(produto, quantidade);

                if (produto == textProdutoVendas.Text)
                {
                     produtoSQL = new ProdutoSQL();
                    int EstoqueAtual = produtoSQL.ValidarEstoque1(textProdutoVendas.Text);
                    textQuantidadeVendas.Text = EstoqueAtual.ToString();
                }

                listViewPedidosEmAndamento.Items.Remove(item);
            }

            listViewPedidosEmAndamento.Clear();


        }
        #endregion

        private void TextBucarProdutoVendas_Click(object sender, EventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
