using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TESTE_DEMARIA.CLASSES.OBJETOS;

namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class ProdutoSQL
    {
        private readonly ConexaoBD _conexao;
        public ProdutoSQL()
        {
            _conexao = new ConexaoBD();
        }

        #region INSERT
        //INSERT PARA SALVAR O PRODUTO
        public void SalvarProduto1(Produto produto)

        {
            string nome = produto.Nome.ToUpper();
            string descricao = produto.Descricao.ToUpper();
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
                                    cmd.Parameters.AddWithValue("@valor", produto.Valor);
                                    cmd.Parameters.AddWithValue("@estoque", produto.Estoque);


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
                                    cmd.Parameters.AddWithValue("@valor", produto.Valor);
                                    cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
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
        #endregion

        #region SELECT
        //SELECT DE BUSCA DE PRODUTO POR NOME

        public Produto BuscarProdutoPorNome1(string nome)
        {
            const string sql = @"SELECT nome, descricao, valor, estoque, ativo 
                         FROM cadastro_de_produtos 
                         WHERE nome ILIKE @nome";

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        return new Produto
                        {
                            Nome = reader["nome"].ToString(),
                            Descricao = reader["descricao"].ToString(),
                            Valor = Convert.ToSingle(reader["valor"]),
                            Estoque = Convert.ToInt32(reader["estoque"]),
                            Ativo = Convert.ToBoolean(reader["ativo"])
                        };
                    }
                }
            }
        }

        //SELECT PARA VALIDAR QUANTIDADE DE ESTOQUE E ATUALIZAR NA TELA DE VENDA
        public int ValidarEstoque1(string nome)
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

        //SELECT PARA OBTER O ID DO PRODUTO
        public int ObterIdProduto1(string nome)
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

        #endregion

        #region UPDATE

        //UPDATE PARA DESATIVAR PRODUTO NA BASE
        public void DeletarProdutoPorNome1(string nome)
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
        public void AtualizarEstoque1(string Produto, int quantidade)
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
        public void RetomarEstoque1(string Produto, int quantidade)
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
