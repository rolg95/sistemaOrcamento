using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DAO (Data Access Object) 
namespace Data
{
    public class OrcamentoDao
    {
        private string _conexao;

        public OrcamentoDao(string conexao)
        {
            _conexao = conexao;
        }


        #region ObtemOrcamento
        public Orcamento ObtemOrcamento(int codigoOrcamento)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            using (SqlCommand comando = conexaoBd.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM Orcamento WHERE CodigoOrcamento = @CodigoOrcamento;";
                comando.Parameters.AddWithValue("@CodigoOrcamento", codigoOrcamento);

                try
                {
                    conexaoBd.Open();

                    using (SqlDataReader tabela = comando.ExecuteReader())
                    {
                        if (tabela.Read())
                        {
                            return new Orcamento
                            {
                                CodigoOrcamento = tabela.GetInt32(tabela.GetOrdinal("CodigoOrcamento")),
                                CodigoCliente = tabela.GetInt32(tabela.GetOrdinal("fk_Clientes_CodigoCliente")),
                                CodigoTecnico = tabela.GetInt32(tabela.GetOrdinal("fk_Tecnicos_CodigoTecnico")),
                                DataSolicitacao = tabela.GetDateTime(tabela.GetOrdinal("DataSolicitacao")),
                                Ocorrencia = tabela["Ocorrencia"].ToString(),
                                Problema = tabela["Problema"].ToString(),
                                Concluido = tabela.GetBoolean(tabela.GetOrdinal("Concluido"))
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao obter orcamento: " + ex.Message);
                }

                return null;
            }
        }
        #endregion

        #region ExcluiOrcamento
        public void ExcluiOrcamento(int codigoOrcamento)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            using (SqlCommand comando = conexaoBd.CreateCommand())
            {
                comando.CommandText = "DELETE FROM Orcamentos WHERE CodigoOrcamento = @CodigoOrcamento;";
                comando.Parameters.AddWithValue("@CodigoOrcamento", codigoOrcamento);

                try
                {
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir orcamento: " + ex.Message);
                }
            }
        }
        #endregion

        public void AlterarOrcamento(Orcamento orcamento)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            using (SqlCommand comando = conexaoBd.CreateCommand())
            {
                comando.CommandText = "UPDATE Orcamentos SET fk_Clientes_CodigoCliente = @CodigoCliente, fk_Tecnicos_CodigoTecnico = @CodigoTecnico, DataSolicitacao = @DataSolicitacao, Ocorrencia = @Ocorrencia, Problema = @Problema, Concluido = @Concluido WHERE CodigoOrcamento = @CodigoOrcamento;";

                // Adiciona os parâmetros ao comando
                comando.Parameters.Add(new SqlParameter("@CodigoCliente", SqlDbType.Int) { Value = orcamento.CodigoCliente });
                comando.Parameters.Add(new SqlParameter("@CodigoTecnico", SqlDbType.Int) { Value = orcamento.CodigoTecnico });
                comando.Parameters.Add(new SqlParameter("@DataSolicitacao", SqlDbType.DateTime) { Value = orcamento.DataSolicitacao });
                comando.Parameters.Add(new SqlParameter("@Ocorrencia", SqlDbType.VarChar) { Value = orcamento.Ocorrencia });
                comando.Parameters.Add(new SqlParameter("@Problema", SqlDbType.VarChar) { Value = orcamento.Problema });
                comando.Parameters.Add(new SqlParameter("@Concluido", SqlDbType.Bit) { Value = orcamento.Concluido });
                comando.Parameters.Add(new SqlParameter("@CodigoOrcamento", SqlDbType.Int) { Value = orcamento.CodigoOrcamento });

                comando.Connection = conexaoBd;

                try
                {
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar Orçamento: " + ex.Message);
                }
            }
        }


        public void IncluiOrcamento(Orcamento orcamento)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                conexaoBd.Open();

                // Iniciar uma transação
                SqlTransaction transacao = conexaoBd.BeginTransaction();

                try
                {
                    string comandoSQL = @"INSERT INTO Orcamentos (fk_Clientes_CodigoCliente, fk_Tecnicos_CodigoTecnico, DataSolicitacao, Ocorrencia, Problema, Concluido)
                                   VALUES (@CodigoCliente, @CodigoTecnico, @DataSolicitacao, @Ocorrencia, @Problema, @Concluido)";

                    using (SqlCommand comando = new SqlCommand(comandoSQL, conexaoBd, transacao))
                    {
                        comando.Parameters.AddWithValue("@CodigoCliente", orcamento.CodigoCliente);
                        comando.Parameters.AddWithValue("@CodigoTecnico", orcamento.CodigoTecnico);
                        comando.Parameters.AddWithValue("@DataSolicitacao", orcamento.DataSolicitacao);
                        comando.Parameters.AddWithValue("@Ocorrencia", orcamento.Ocorrencia);
                        comando.Parameters.AddWithValue("@Problema", orcamento.Problema);
                        comando.Parameters.AddWithValue("@Concluido", orcamento.Concluido);

                        comando.ExecuteNonQuery();
                    }

                    // Commit da transação se tudo ocorreu bem
                    transacao.Commit();
                }
                catch (Exception)
                {
                    // Reverter a transação em caso de exceção
                    transacao.Rollback();
                    throw; // Lança a exceção novamente para que seja tratada no nível superior
                }
            }
        }



        public DataSet BuscaOrcamento(string pesquisa = "")
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql;

                if (string.IsNullOrEmpty(pesquisa))
                {
                    sql = @"SELECT Orcamento.CodigoOrcamento, Orcamento.fk_Clientes_CodigoCliente, Orcamento.fk_Tecnicos_CodigoTecnico, 
                    Orcamento.DataSolicitacao AS 'Data da Solicitação', Clientes.Nome AS 'Cliente', 
                    Tecnicos.Nome AS 'Técnico', Orcamento.Ocorrencia AS 'Ocorrência', 
                    Orcamento.Problema, Orcamento.Concluido 
                    FROM Orcamento 
                    JOIN Clientes ON Orcamento.fk_Clientes_CodigoCliente = Clientes.CodigoCliente 
                    JOIN Tecnicos ON Orcamento.fk_Tecnicos_CodigoTecnico = Tecnicos.CodigoTecnico;";
                }
                else
                {
                    sql = @"SELECT Orcamento.CodigoOrcamento, Orcamento.fk_Clientes_CodigoCliente, Orcamento.fk_Tecnicos_CodigoTecnico, 
                    Orcamento.DataSolicitacao AS 'Data da Solicitação', Clientes.Nome AS 'Cliente', 
                    Tecnicos.Nome AS 'Técnico', Orcamento.Ocorrencia AS 'Ocorrência', 
                    Orcamento.Problema, Orcamento.Concluido 
                    FROM Orcamento 
                    JOIN Clientes ON Orcamento.fk_Clientes_CodigoCliente = Clientes.CodigoCliente 
                    JOIN Tecnicos ON Orcamento.fk_Tecnicos_CodigoTecnico = Tecnicos.CodigoTecnico 
                    WHERE Clientes.Nome LIKE '%' + @Pesquisa + '%';";
                }

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    if (!string.IsNullOrEmpty(pesquisa))
                    {
                        comando.Parameters.AddWithValue("@Pesquisa", pesquisa);
                    }

                    try
                    {
                        conexaoBd.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet dsOrcamento = new DataSet();
                        adaptador.Fill(dsOrcamento, "Orcamento");
                        return dsOrcamento;
                    }
                    catch (Exception erro)
                    {
                        throw new Exception($"Ocorreu o erro: {erro.Message}");
                    }
                }
            }
        }

    }
}
