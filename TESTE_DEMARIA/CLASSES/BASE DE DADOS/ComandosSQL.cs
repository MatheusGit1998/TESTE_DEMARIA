using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using TESTE_DEMARIA.CLASSES.BASE_DE_DADOS;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class ComandosSQL
    {
        private readonly ConexaoBD _conexao;

        //INICIA UM NOVO COMANDO
        public ComandosSQL()
        {
            _conexao = new ConexaoBD();
        }
        //INICIA UM CONEXAO COM O BANCO

        public NpgsqlConnection GetConn()
        {
            return new NpgsqlConnection(_conexao.GetConnectionString());
        }

        #region INSERT

        // INSERT PARA SALVAR O CLIENTE
        public void SalvarCliente(
        string nome, string email, string telefone, string cpf,
        string logradouro, string numero, string complemento,
        string bairro, string localidade, string uf, string cep)
        {
            const string sqlCheck = @"SELECT ativo FROM Cadastro_de_Clientes WHERE cpf = @cpf";
            const string sqlInsert = @"
            INSERT INTO Cadastro_de_Clientes (
            nome, email, telefone, cpf,
            logradouro, numero, complemento,
            bairro, localidade, uf, cep, ativo
            )
             VALUES (@nome, @email, @telefone, @cpf, @logradouro, @numero, @complemento,
            @bairro, @localidade, @uf, @cep, TRUE
            );";

            const string sqlUpdate = @"
            UPDATE Cadastro_de_Clientes
            SET nome = @nome,
            email = @email,
            telefone = @telefone,
            logradouro = @logradouro,
            numero = @numero,
            complemento = @complemento,
            bairro = @bairro,
            localidade = @localidade,
            uf = @uf,
            cep = @cep
            WHERE cpf = @cpf;";

            const string sqlReativar = @"
            UPDATE Cadastro_de_Clientes
            SET ativo = TRUE,
            nome = @nome,
            email = @email,
            telefone = @telefone,
            logradouro = @logradouro,
            numero = @numero,
            complemento = @complemento,
            bairro = @bairro,
            localidade = @localidade,
            uf = @uf,
            cep = @cep
            WHERE cpf = @cpf;";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var checkCmd = new NpgsqlCommand(sqlCheck, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@cpf", cpf);
                        var statusObj = checkCmd.ExecuteScalar();

                        if (statusObj != null)
                        {
                            bool ativo = Convert.ToBoolean(statusObj);

                            if (ativo)
                            {
                                var resultado = MessageBox.Show(
                                    "Já existe um cliente com este CPF. Deseja substituir as informações?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );

                                if (resultado == DialogResult.Yes)
                                {
                                    using (var cmd = new NpgsqlCommand(sqlUpdate, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@nome", nome);
                                        cmd.Parameters.AddWithValue("@email", email);
                                        cmd.Parameters.AddWithValue("@telefone", telefone);
                                        cmd.Parameters.AddWithValue("@cpf", cpf);
                                        cmd.Parameters.AddWithValue("@logradouro", logradouro);
                                        cmd.Parameters.AddWithValue("@numero", numero);
                                        cmd.Parameters.AddWithValue("@complemento", complemento);
                                        cmd.Parameters.AddWithValue("@bairro", bairro);
                                        cmd.Parameters.AddWithValue("@localidade", localidade);
                                        cmd.Parameters.AddWithValue("@uf", uf);
                                        cmd.Parameters.AddWithValue("@cep", cep);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Cliente atualizado com sucesso!");
                                    }
                                }
                            }
                            else
                            {
                                var resultado = MessageBox.Show(
                                    "Cliente existe mas está inativo. Deseja reativar?",
                                    "Reativar Cliente",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );

                                if (resultado == DialogResult.Yes)
                                {
                                    using (var cmd = new NpgsqlCommand(sqlReativar, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@nome", nome);
                                        cmd.Parameters.AddWithValue("@email", email);
                                        cmd.Parameters.AddWithValue("@telefone", telefone);
                                        cmd.Parameters.AddWithValue("@cpf", cpf);
                                        cmd.Parameters.AddWithValue("@logradouro", logradouro);
                                        cmd.Parameters.AddWithValue("@numero", numero);
                                        cmd.Parameters.AddWithValue("@complemento", complemento);
                                        cmd.Parameters.AddWithValue("@bairro", bairro);
                                        cmd.Parameters.AddWithValue("@localidade", localidade);
                                        cmd.Parameters.AddWithValue("@uf", uf);
                                        cmd.Parameters.AddWithValue("@cep", cep);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Cliente reativado com sucesso!");
                                    }
                                }
                            }
                        }
                        else
                        {
                            using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                            {
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@telefone", telefone);
                                cmd.Parameters.AddWithValue("@cpf", cpf);
                                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                                cmd.Parameters.AddWithValue("@numero", numero);
                                cmd.Parameters.AddWithValue("@complemento", complemento);
                                cmd.Parameters.AddWithValue("@bairro", bairro);
                                cmd.Parameters.AddWithValue("@localidade", localidade);
                                cmd.Parameters.AddWithValue("@uf", uf);
                                cmd.Parameters.AddWithValue("@cep", cep);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cliente inserido com sucesso!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
            }
        }

        //INSERT PARA REGISTRAR VENDA NA BASE VENDAS
        public int RegistrarVendaBase1(int idCliente, float valor)
        {
            const string sqlInsert = @"
            INSERT INTO vendas (
            cliente_id, valor_total
            )
            VALUES (
             @cliente_id, @valor_total
            )
            RETURNING id_venda;
            ";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", idCliente);
                        cmd.Parameters.AddWithValue("@valor_total", valor);

                        int idVenda = Convert.ToInt32(cmd.ExecuteScalar());
                        return idVenda;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar a venda: " + ex.Message);
                return -1;
            }
        }

        //INSERT PARA REGISTRAR VENDA NA BASE ITENS_VENDA
        public void RegistrarVendaBase2(int idVenda, int idProduto, int Quantidade, float valorUni, float valorTotal)
        {
            const string sqlInsert = @"
            INSERT INTO itens_venda (
            id_venda, id_produto, quantidade, preco_unitario, preco_total
            )
            VALUES (
            @id_venda, @id_produto, @quantidade, @preco_unitario, @preco_total
            );";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_venda", idVenda);
                        cmd.Parameters.AddWithValue("@id_produto", idProduto);
                        cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                        cmd.Parameters.AddWithValue("@preco_unitario", valorUni);
                        cmd.Parameters.AddWithValue("@preco_total", valorTotal);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a venda Produto: " + ex.Message);
            }
        }



        #endregion

        #region SELECT

        //SELECT PARA BUSCAR CLIENTE POR CPF
        public void BuscarClientePorCPF(string cpf,
            MaterialSkin.Controls.MaterialTextBox2 txtNome,
            MaterialSkin.Controls.MaterialTextBox2 txtEmail,
            MaterialSkin.Controls.MaterialMaskedTextBox txtTelefone,
            MaterialSkin.Controls.MaterialMaskedTextBox txtCPF,
            MaterialSkin.Controls.MaterialTextBox2 txtLogradouro,
            MaterialSkin.Controls.MaterialMaskedTextBox txtNumero,
            MaterialSkin.Controls.MaterialTextBox2 txtComplemento,
            MaterialSkin.Controls.MaterialTextBox2 txtBairro,
            MaterialSkin.Controls.MaterialTextBox2 txtLocalidade,
            MaterialSkin.Controls.MaterialComboBox comboUF,
            MaterialSkin.Controls.MaterialMaskedTextBox txtCEP,
            ref string ativo)
        {
            const string sql = @"SELECT nome, email, telefone, cpf,
                                logradouro, numero, complemento,
                                bairro, localidade, uf, cep, ativo
                                FROM Cadastro_de_Clientes
                                WHERE cpf = @cpf";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@cpf", cpf);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtTelefone.Text = reader["telefone"].ToString();
                                txtCPF.Text = reader["cpf"].ToString();
                                txtLogradouro.Text = reader["logradouro"].ToString();
                                txtNumero.Text = reader["numero"].ToString();
                                txtComplemento.Text = reader["complemento"].ToString();
                                txtBairro.Text = reader["bairro"].ToString();
                                txtLocalidade.Text = reader["localidade"].ToString();
                                comboUF.Text = reader["uf"].ToString();
                                txtCEP.Text = reader["cep"].ToString();
                                ativo = reader["ativo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum cliente encontrado com este CPF.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
        }

        //SELECT PARA BUSCAR CLIENTES E CARREGAR LISTVIEW
        public void CarregarClientes(ListView listView)
        {
            const string sql = @"SELECT nome, email, telefone, cpf,
                   logradouro, numero, complemento,
                   bairro, localidade, uf, cep, data_cadastro
                   FROM cadastro_de_clientes
                   WHERE ativo = TRUE;";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listView.Items.Clear(); // limpa antes de preencher

                        while (reader.Read())
                        {
                            // Primeiro campo vira o item principal
                            var item = new ListViewItem(reader["nome"].ToString());

                            // Os demais viram subitens
                            item.SubItems.Add(reader["email"].ToString());
                            item.SubItems.Add(reader["telefone"].ToString());
                            item.SubItems.Add(reader["cpf"].ToString());
                            item.SubItems.Add(reader["logradouro"].ToString());
                            item.SubItems.Add(reader["numero"].ToString());
                            item.SubItems.Add(reader["complemento"].ToString());
                            item.SubItems.Add(reader["bairro"].ToString());
                            item.SubItems.Add(reader["localidade"].ToString());
                            item.SubItems.Add(reader["uf"].ToString());
                            item.SubItems.Add(reader["cep"].ToString());
                            item.SubItems.Add(reader["data_cadastro"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }


        //SELECT PARA SALVAR O PRODUTO
        public void SalvarProduto(
        string nome, string descricao, float valor, int estoque)

        {
            nome = nome.ToUpper();
            descricao = descricao.ToUpper();
            const string sqlCheck = @"SELECT COUNT(*) FROM Cadastro_de_Produtos WHERE  nome =  @nome";
            const string sqlCheckstatus = @"SELECT ativo FROM Cadastro_de_Produtos WHERE  nome =  @nome";
            const string sqlInsert = @"
            INSERT INTO Cadastro_de_Produtos (
            nome, descricao, valor, estoque
            )
            VALUES (
            (@nome), (@descricao), @valor, @estoque
            );";

            const string sqlUpdate = @"
            UPDATE Cadastro_de_Produtos
            SET nome = (@nome),
            descricao = (@descricao),
            valor = @valor,
            estoque = @estoque
            WHERE (nome) = (@nome);";


            const string sqlReativar = @"
            UPDATE cadastro_de_produtos SET ativo = TRUE WHERE (nome) = (@nome);";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var checkCmd = new NpgsqlCommand(sqlCheck, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nome", nome);
                        long existe = Convert.ToInt64(checkCmd.ExecuteScalar());
                        using (var checkstatus = new NpgsqlCommand(sqlCheckstatus, conn))
                        {
                            if (existe > 0)
                            {
                                checkstatus.Parameters.AddWithValue("@nome", nome);
                                bool status = (bool)checkstatus.ExecuteScalar();


                                if (status == true)
                                {
                                    var resultado = MessageBox.Show(
                                    "Já existe um produto com este nome. Deseja substituir as informações?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                    );
                                    if (resultado == DialogResult.No)
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    var resultado = MessageBox.Show(
                                    "Já existe um produto com este nome, mas esta inativo. Deseja substituir as informações e reativar?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                    );
                                    if (resultado == DialogResult.No)
                                    {
                                        return;
                                    }
                                    // EM CASO DE AFIRMATIVO FAZ UPDATE STATUS
                                    using (var cmd = new NpgsqlCommand(sqlReativar, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@nome", nome);
                                        int linhasAfetadas = cmd.ExecuteNonQuery();
                                        MessageBox.Show($"Produto reativado com sucesso!");
                                    }
                                }

                                // EM CASO DE AFIRMATIVO FAZ UPDATE DADOS
                                using (var cmd = new NpgsqlCommand(sqlUpdate, conn))
                                {
                                    cmd.Parameters.AddWithValue("@nome", nome);
                                    cmd.Parameters.AddWithValue("@descricao", descricao);
                                    cmd.Parameters.AddWithValue("@valor", valor);
                                    cmd.Parameters.AddWithValue("@estoque", estoque);


                                    int linhasAfetadas = cmd.ExecuteNonQuery();
                                    MessageBox.Show($"Produto atualizado com sucesso!");
                                }
                            }
                            else
                            {
                                // FAZ INSERT CASO NÃO EXISTA
                                using (var cmd = new NpgsqlCommand(sqlInsert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@nome", nome);
                                    cmd.Parameters.AddWithValue("@descricao", descricao);
                                    cmd.Parameters.AddWithValue("@valor", valor);
                                    cmd.Parameters.AddWithValue("@estoque", estoque);
                                    ;

                                    int linhasAfetadas = cmd.ExecuteNonQuery();
                                    MessageBox.Show($"Produto inserido com sucesso!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Produto: " + ex.Message);
            }
        }

        //SELECT DA BASE PRODUTOS PARA ATUALIZAR LISTVIEW
        public void CarregarProduto(ListView listView)
        {
            const string sql = @"SELECT nome, descricao, valor, estoque,criado_em FROM Cadastro_de_Produtos WHERE ativo = TRUE;";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listView.Items.Clear();

                        while (reader.Read())
                        {
                            
                            var item = new ListViewItem(reader["nome"].ToString());
                            item.SubItems.Add(reader["descricao"].ToString());
                            item.SubItems.Add(reader["valor"].ToString());
                            item.SubItems.Add(reader["estoque"].ToString());
                            item.SubItems.Add(reader["criado_em"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        //SELECT DA BASE VENDAS PARA ATUALIZAR LISTVIEW
        public void CarregarVendas(ListView listView)
        {
            const string sql = @"SELECT id_venda, cliente_id, data_venda, valor_total FROM Vendas";


            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listView.Items.Clear();

                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["id_venda"].ToString());
                            item.SubItems.Add(reader["cliente_id"].ToString());
                            item.SubItems.Add(reader["data_venda"].ToString());
                            item.SubItems.Add(reader["valor_total"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        //SELECT DE BUSCA DE PRODUTO POR NOME

        public void BuscarProdutoPorNome(string nome,
            MaterialSkin.Controls.MaterialTextBox2 txtNome,
            MaterialSkin.Controls.MaterialMultiLineTextBox2 TextDescricao,
            MaterialSkin.Controls.MaterialTextBox2 TextValor,
            MaterialSkin.Controls.MaterialMaskedTextBox TextQuatidade,
            ref string ativo)
        {
            const string sql = @"SELECT nome, descricao, valor, estoque,ativo FROM Cadastro_de_Produtos WHERE nome ILIKE @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome"].ToString();
                                TextDescricao.Text = reader["descricao"].ToString();
                                TextValor.Text = reader["valor"].ToString();
                                TextQuatidade.Text = reader["estoque"].ToString();
                                ativo = reader["ativo"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Nenhum Produto encontrado com este Nome.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Produto: " + ex.Message);
            }
        }

        //SELECT PARA BUSCAR PRODUTO POR NOME 'VENDAS'

        public void BuscarProdutoPorNomeVendas(string nome,
            MaterialSkin.Controls.MaterialTextBox2 txtNome,
            MaterialSkin.Controls.MaterialTextBox2 TextValor,
            MaterialSkin.Controls.MaterialTextBox2 TextQuatidade)
        {
            const string sql = @"SELECT nome, valor, estoque FROM Cadastro_de_Produtos WHERE nome ILIKE @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome"].ToString();
                                TextValor.Text = reader["valor"].ToString();
                                TextQuatidade.Text = reader["estoque"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Nenhum Produto encontrado com este Nome.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Produto: " + ex.Message);
            }
        }


        //SELECT PARA BUSCAR CLIENTE POR CPF 'VENDAS'
        public void BuscarClientePorNomeVendas(string cpf,
        MaterialSkin.Controls.MaterialTextBox2 txtNome, MaterialSkin.Controls.MaterialTextBox2 txtCPF)
        {
            const string sql = @"SELECT nome, cpf FROM Cadastro_de_Clientes  WHERE cpf = @cpf";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@cpf", cpf);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome"].ToString();
                                txtCPF.Text = reader["cpf"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Nenhum Cliente encontrado com este Nome.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Cliente: " + ex.Message);
            }
        }


        //SELECT PARA OBTER O ID DO CLIENTE
        public int ObterIdCliente(string cpf)
        {
            const string sql = @"SELECT cliente_id, cpf 
                         FROM Cadastro_de_Clientes  
                         WHERE cpf = @cpf";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpf);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToInt32(reader["cliente_id"]);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum id encontrado com este CPF.");
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Cliente: " + ex.Message);
                return -1;
            }
        }

        //SELECT PARA OBTER O ID DO PRODUTO
        public int ObterIdProduto(string nome)
        {
            const string sql = @"SELECT id_produto 
                         FROM Cadastro_de_Produtos  
                         WHERE nome = @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToInt32(reader["id_produto"]);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum id encontrado com este produto.");
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Cliente: " + ex.Message);
                return -1;
            }
        }

        //SELECT PARA OBTER O ID DE VENDA
        public int ObterIdVenda(string nome)
        {
            const string sql = @"SELECT id_venda 
                         FROM vendas  
                         WHERE nome = @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToInt32(reader["id_produto"]);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum id encontrado com este produto.");
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Cliente: " + ex.Message);
                return -1;
            }
        }

        //SELECT PARA VALIDAR QUANTIDADE DE ESTOQUE E ATUALIZAR NA TELA DE VENDA
        public int ValidarEstoque(string nome)
        {
            const string sql = @"SELECT estoque 
                         FROM Cadastro_de_Produtos  
                         WHERE nome = @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToInt32(reader["estoque"]);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar estoque.");
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Cliente: " + ex.Message);
                return -1;
            }
        }

        //SELECT PARA OBTER DETALHES DAS VENDAS E ATUALIZAR REPORTVIEWER DE VENDAS COM INTERVALO DE DATAS
        public DataTable ObterDadosDasVendas(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                    c.nome AS cliente,
                    v.id_venda AS idvenda,
                    v.data_venda AS datavenda,
                    p.nome AS produto,
                    i.quantidade AS quantidade,
                    i.preco_unitario AS precounitario,
                    (i.quantidade * i.preco_unitario) AS subtotalitem,
                    v.valor_total AS totalvenda
                FROM vendas v
                INNER JOIN cadastro_de_clientes c ON v.cliente_id = c.cliente_id
                INNER JOIN itens_venda i ON v.id_venda = i.id_venda
                INNER JOIN cadastro_de_produtos p ON i.id_produto = p.id_produto
                WHERE v.data_venda BETWEEN @dataInicio AND @dataFim
                ";


                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", dataFim);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //SELECT PARA OBTER DETALHES DAS DOS CLIENTES E ATUALIZAR REPORTVIEWER DE CADASTROS CLIENTES

        public DataTable ObterDadosClientes()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                c.*,
                c.data_cadastro AS datacadastro 
                FROM cadastro_de_clientes c
                ";


                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //SELECT PARA OBTER DETALHES DAS DOS PRODUTOS E ATUALIZAR REPORTVIEWER DE CADASTROS PRODUTOS
        public DataTable ObterDadosProduto()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                    p.*,
                    p.criado_em AS criadoem 
                FROM cadastro_de_produtos p
                ";
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //SELECT PARA ATUALIZAR VENDAS TOTAIS TELA HOME
        public decimal ObterTotalDeVendas()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT SUM(valor_total) FROM vendas";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter total de vendas: " + ex.Message);
                return 0;
            }
        }

        //SELECT PARA ATUALIZAR QUANTIDADE DE ESTOQUE TOTAL TELA HOME

        public int ObterQtdItemsEmEstoque()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT SUM(estoque) FROM cadastro_de_produtos";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter total de vendas: " + ex.Message);
                return 0;
            }
        }

        //SELECT PARA ATUALIZAR QUANTIDADE DE CLIENTES ATIVOS TOTAIS TELA HOME

        public int ObterQtdClientesAtivos()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) AS clientes_ativos FROM cadastro_de_clientes WHERE ativo = TRUE;";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter total de clientes ativos: " + ex.Message);
                return 0;
            }
        }

        //SELECT PARA ATUALIZAR QUANTIDADE TOTAL DE ITEMS VENDIDOS TELA HOME

        public int ObterQtdItemsVendidos()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT SUM(quantidade) FROM itens_venda;";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter total de clientes ativos: " + ex.Message);
                return 0;
            }
        }
        #endregion

        #region UPDATE
        //UPDATE PARA DESATIVAR CLIENTE PELO CPF

        public void DeletarClientePorCPF(string cpf)
        {
            const string sql = @"UPDATE cadastro_de_clientes SET ativo = FALSE WHERE cpf = @cpf";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpf);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cliente desativado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente encontrado com este CPF.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar cliente: " + ex.Message);
            }
        }

        //UPDATE PARA DESATIVAR PRODUTO NA BASE
        public void DeletarProdutoPorNome(string nome)
        {
            const string sql = @"UPDATE cadastro_de_produtos SET ativo = FALSE WHERE nome = @nome";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Produto desativado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum Produto encontrado com este Nome.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar Produto: " + ex.Message);
            }
        }

        //UPDATE PARA REMOVER ITEM DO ESTOQUE DE PRODUTOS 'RESERVADO'
        public void AtualizarEstoque(string Produto, int quantidade)
        {
            const string sqlUpdate = @"
                UPDATE cadastro_de_produtos
                SET estoque = estoque - @quantidade
                WHERE nome = @produto;
                ";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@produto", Produto);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas < 1)
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estoque: " + ex.Message);
            }
        }

        //UPDATE PARA DEVOLVER ITEM AO ESTOQUE DE PRODUTOS 'COMPRA CANCELADA'
        public void RetomarEstoque(string Produto, int quantidade)
        {
            const string sqlUpdate = @"
                UPDATE cadastro_de_produtos
                SET estoque = estoque + @quantidade
                WHERE nome = @produto;
                ";

            try
            {
                using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@produto", Produto);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas < 0)
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estoque: " + ex.Message);
            }
        }
        #endregion

    }
}
