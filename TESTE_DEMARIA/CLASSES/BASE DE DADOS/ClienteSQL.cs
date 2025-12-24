using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TESTE_DEMARIA.CLASSES.OBJETOS;
using TESTE_DEMARIA.CLASSES.Utils;


namespace TESTE_DEMARIA.CLASSES.BASE_DE_DADOS
{
    public class ClienteSQL
    {

        private readonly ConexaoBD _conexao;
        public ClienteSQL()
        {
            _conexao = new ConexaoBD();
        }

        #region INSERT
        // INSERT PARA SALVAR O CLIENTE
        public void SalvarCliente1(Cliente cliente)
        {
            string nome = cliente.Nome.ToUpper();
            string email = cliente.Email.ToUpper();

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
                        checkCmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
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
                                        cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                                        cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                                        cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
                                        cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                                        cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                                        cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                                        cmd.Parameters.AddWithValue("@localidade", cliente.Localidade);
                                        cmd.Parameters.AddWithValue("@uf", cliente.Uf);
                                        cmd.Parameters.AddWithValue("@cep", cliente.Cep);

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
                                        cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                                        cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                                        cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
                                        cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                                        cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                                        cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                                        cmd.Parameters.AddWithValue("@localidade", cliente.Localidade);
                                        cmd.Parameters.AddWithValue("@uf", cliente.Uf);
                                        cmd.Parameters.AddWithValue("@cep", cliente.Cep);

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
                                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                                cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
                                cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                                cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                                cmd.Parameters.AddWithValue("@localidade", cliente.Localidade);
                                cmd.Parameters.AddWithValue("@uf", cliente.Uf);
                                cmd.Parameters.AddWithValue("@cep", cliente.Cep);

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


        #endregion

        #region SELECT
        //SELECT PARA BUSCAR CLIENTE POR CPF
        public Cliente BuscarClientePorCPF1(string cpf)
        {
            const string sql = @"SELECT * FROM cadastro_de_clientes WHERE cpf = @cpf";

            using (var conn = new NpgsqlConnection(_conexao.GetConnectionString()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        return new Cliente
                        {
                            ClienteId = Convert.ToInt32(reader["cliente_id"]),
                            Nome = reader["nome"].ToString(),
                            Email = reader["email"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            Cpf = reader["cpf"].ToString(),
                            Logradouro = reader["logradouro"].ToString(),
                            Numero = reader["numero"].ToString(),
                            Complemento = reader["complemento"].ToString(),
                            Bairro = reader["bairro"].ToString(),
                            Localidade = reader["localidade"].ToString(),
                            Uf = reader["uf"].ToString(),
                            Cep = reader["cep"].ToString(),
                            Ativo = Convert.ToBoolean(reader["ativo"])
                        };
                    }
                }
            }
        }

        //SELECT PARA OBTER O ID DO CLIENTE
        public int ObterIdCliente1(string cpf)
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

        #endregion

        #region UPDATE
        //UPDATE PARA DESATIVAR CLIENTE PELO CPF

        public void DeletarClientePorCPF1(string cpf)
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
        #endregion
    }
}
