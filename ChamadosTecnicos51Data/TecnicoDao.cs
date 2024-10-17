using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TecnicoDao
    {
        // Atenção não esquecer de instalar o pacote Nuget System.Data.SqlClient e Associar o projeto para o Window form encontrar o DAO
        //atributos globais
        private string _conexao;

        //metodo construtor => inicializa objeto instanciado
        public TecnicoDao(string conexao)
        {
            _conexao = conexao;
        }
        //metodo de consulta para seleção de um Tecnico
        public Tecnico ObtemTecnicoPorCodigo(int codigoTecnico)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                // Comando SQL para buscar o técnico pelo código
                string query = "SELECT * FROM Tecnicos WHERE CodigoTecnico = @codigoTecnico;";

                using (SqlCommand comando = new SqlCommand(query, conexaoBd))
                {
                    // Adiciona o parâmetro
                    comando.Parameters.AddWithValue("@codigoTecnico", codigoTecnico);

                    try
                    {
                        // Abre a conexão
                        conexaoBd.Open();

                        using (SqlDataReader tabela = comando.ExecuteReader())
                        {
                            if (tabela.Read())
                            {
                                return new Tecnico
                                {
                                    CodigoTecnico = Convert.ToInt32(tabela["CodigoTecnico"]),
                                    Nome = tabela["Nome"].ToString(),
                                    Especialidade = tabela["Especialidade"].ToString()
                                };
                            }
                        }

                        // Se não encontrar nenhum técnico com o código fornecido, retorna null
                        return null;
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Ocorreu um erro ao obter o técnico: " + erro.Message);
                    }
                }
            }
        }


        //metodo de exclusão de clientes
        public void ExcluiTecnico(int codigoTecnico)
        {
            // Trabalhar com using para garantir a liberação adequada dos recursos
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                // Comando SQL para excluir o técnico pelo código
                string query = "DELETE FROM Tecnicos WHERE CodigoTecnico = @CodigoTecnico;";

                // Usar o using com o SqlCommand também
                using (SqlCommand comando = new SqlCommand(query, conexaoBd))
                {
                    // Adicionar o parâmetro
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);

                    try
                    {
                        // Abrir a conexão
                        conexaoBd.Open();

                        // Executar o comando no banco de dados
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        // Obter o erro na execução do comando
                        throw new Exception("Ocorreu um erro ao excluir o técnico: " + erro.Message);
                    }
                } // O comando será automaticamente liberado aqui
            } // A conexão será automaticamente liberada aqui
        }


        //metodo de alteração de clientes
        public void AlteraTecnico(Tecnico tecnico)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            using (SqlCommand comando = conexaoBd.CreateCommand())
            {
                // Comando SQL para atualizar o técnico
                comando.CommandText = "UPDATE Tecnicos SET Nome = @Nome, Especialidade = @Especialidade WHERE CodigoTecnico = @CodigoTecnico;";

                // Adicionando parâmetros com nomes
                comando.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar) { Value = tecnico.Nome });
                comando.Parameters.Add(new SqlParameter("@Especialidade", SqlDbType.NVarChar) { Value = tecnico.Especialidade });
                comando.Parameters.Add(new SqlParameter("@CodigoTecnico", SqlDbType.Int) { Value = tecnico.CodigoTecnico });

                try
                {
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    throw new Exception("Ocorreu um erro ao alterar o técnico: " + erro.Message);
                }
            }
        }

        //metodo de inclusão de Tecnico
        public void IncluiTecnico(Tecnico tecnico)
        {
            // O bloco "using" garante que os recursos da conexão e do comando SQL serão liberados adequadamente após o uso.
            using (SqlConnection conexaoBd = new SqlConnection(_conexao)) // Cria a conexão com o banco de dados usando a string de conexão "_conexao".
            using (SqlCommand comando = conexaoBd.CreateCommand()) // Cria o comando SQL associado à conexão.
            {
                // Comando SQL para inserir um novo técnico na tabela 'Tecnicos', definindo parâmetros para Nome e Especialidade.
                comando.CommandText = "INSERT INTO Tecnicos (Nome, Especialidade) VALUES (@Nome, @Especialidade);";

                // Adiciona o parâmetro '@Nome' à query, especificando que ele é do tipo NVarChar (texto) e atribuindo o valor da propriedade Nome do técnico.
                // Se 'tecnico.Nome' for nulo, substitui por DBNull.Value para garantir que não ocorra erro de banco de dados.
                comando.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar)
                {
                    Value = tecnico.Nome ?? (object)DBNull.Value
                });

                // Adiciona o parâmetro '@Especialidade' à query, também garantindo que não seja nulo, usando DBNull.Value quando for o caso.
                comando.Parameters.Add(new SqlParameter("@Especialidade", SqlDbType.NVarChar)
                {
                    Value = tecnico.Especialidade ?? (object)DBNull.Value
                });

                try
                {
                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Executa o comando SQL (inserção no banco de dados). "ExecuteNonQuery" é usado quando não há retorno de dados (apenas a execução da query).
                    comando.ExecuteNonQuery();
                }
                // Captura exceções específicas de SQL para um melhor tratamento de erros do banco de dados.
                catch (SqlException sqlEx)
                {
                    // Lança uma nova exceção com uma mensagem personalizada, incluindo detalhes do erro original.
                    throw new Exception("Ocorreu um erro de banco de dados ao incluir o técnico: " + sqlEx.Message, sqlEx);
                }
                // Captura qualquer outra exceção geral que não seja relacionada ao SQL.
                catch (Exception ex)
                {
                    // Lança uma exceção genérica com detalhes do erro.
                    throw new Exception("Ocorreu um erro ao incluir o técnico: " + ex.Message, ex);
                }
            }
        }


        public DataSet BuscaTecnico(string pesquisa = "")
        {
            using (SqlConnection sqlConexao = new SqlConnection(_conexao))
            using (SqlCommand sqlComando = sqlConexao.CreateCommand())
            {
                string sql = "SELECT * FROM Tecnicos";

                if (!string.IsNullOrEmpty(pesquisa))
                {
                    sql = "SELECT * FROM Tecnicos WHERE Nome LIKE '%' + @Pesquisa + '%'";
                    sqlComando.Parameters.AddWithValue("@Pesquisa", pesquisa);
                }

                sqlComando.CommandText = sql;
                sqlComando.CommandType = CommandType.Text;

                try
                {
                    sqlConexao.Open();

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataSet dsTecnicos = new DataSet();

                    sqlAdaptador.Fill(dsTecnicos, "Tecnicos");

                    return dsTecnicos;
                }
                catch (Exception erro)
                {
                    throw new Exception("Ocorreu um erro na busca de técnicos: " + erro.Message);
                }
            }
        }

    }
}
