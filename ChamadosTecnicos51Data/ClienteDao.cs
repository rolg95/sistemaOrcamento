using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    // Classe que representa o Data Access Object (DAO) para clientes.
    public class ClienteDao
    {
        // Campo privado que armazena a string de conexão com o banco de dados.
        private readonly string _conexao;

        // Construtor da classe ClienteDao, que recebe a string de conexão e a atribui ao campo privado _conexao.
        public ClienteDao(string conexao)
        {
            _conexao = conexao;
        }

        // Método que insere um novo cliente no banco de dados.
        // Recebe um objeto 'Cliente' com as informações do cliente que será inserido.
        // Forma 1
        public void IncluiCliente(Cliente cliente)
        {
            // Query SQL que realiza a inserção de um novo registro na tabela 'Clientes'.
            const string query = @"INSERT INTO Clientes (Nome, Profissao, Setor, Cep, Rua, Numero, Cidade, Estado, Observacao) 
                           VALUES (@Nome, @Profissao, @Setor, @Cep, @Rua, @Numero, @Cidade, @Estado, @Observacao)";

            // Bloco try para tratar possíveis exceções que possam ocorrer durante a execução da inserção.
            try
            {
                // Criação de uma conexão com o banco de dados utilizando a string de conexão '_conexao'.
                using (var conexaoBd = new SqlConnection(_conexao))
                // Criação de um comando SQL associado à conexão e à query.
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    // Adiciona os parâmetros à query SQL para prevenir injeção de SQL.
                    // Verifica se o valor da propriedade do cliente é nulo, atribuindo DBNull.Value se for.
                    // Maneira Simplificada  comandoBD.Parameters.AddWithValue("@CodigoMedico", codigoMedico); 
                    // Maneira Garantindo integridade dos dados :

                    // Adiciona o parâmetro "@Nome" ao comando SQL, especificando que ele será do tipo NVarChar (string SqlDbType.NVarChar).
                    // O valor atribuído ao parâmetro será o valor da propriedade 'Nome' do objeto 'cliente'.
                    // Caso 'cliente.Nome' seja nulo, o valor atribuído ao parâmetro será 'DBNull.Value', que indica um valor nulo no banco de dados.
                    comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cliente.Nome ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Profissao", SqlDbType.NVarChar).Value = cliente.Profissao ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Setor", SqlDbType.NVarChar).Value = cliente.Setor ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Cep", SqlDbType.NVarChar).Value = cliente.Cep ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Rua", SqlDbType.NVarChar).Value = cliente.Rua ?? (object)DBNull.Value;

                    // Campo 'Numero' é tratado separadamente, pois é do tipo int?, ou seja, pode ser nulo.
                    comando.Parameters.Add("@Numero", SqlDbType.Int).Value = cliente.Numero.HasValue ? (object)cliente.Numero.Value : DBNull.Value;
                    comando.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = cliente.Cidade ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = cliente.Estado ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = cliente.Observacao ?? (object)DBNull.Value;

                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Executa a query SQL de inserção no banco de dados.
                    comando.ExecuteNonQuery();
                }
            }
            // Caso ocorra uma exceção, ela é capturada e uma nova exceção é lançada com uma mensagem detalhada.
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir cliente: {ex.Message}", ex);
            }
        }

        // Forma 2 de Incluir Cliente usando os conceitos modernos de ASYNC 
        // Método assíncrono para incluir um cliente no banco de dados.
        /*
        Mudanças Implementadas:
        Uso de async/await:

        Tornei o método IncluiCliente assíncrono para melhorar a escalabilidade e evitar o bloqueio da UI. Isso foi feito usando OpenAsync() e ExecuteNonQueryAsync().
        Transação:

        Adicionei uma transação usando BeginTransaction() para garantir que a operação de inserção seja atômica. Se ocorrer algum erro, a transação é revertida com Rollback(). Se tudo correr bem, é confirmada com Commit().
        Tratamento de Exceções:

        Separei o tratamento de exceções para capturar erros específicos de SQL usando SqlException, proporcionando uma melhor análise e tratamento dos erros. Outras exceções são tratadas de forma genérica.
        Segurança de SQL:

        O código já estava protegendo contra injeção de SQL usando parâmetros SQL. Não foi necessário modificar essa parte, mas a prática continua sendo utilizada com a adição de transações.
        Evitar AddWithValue:

        Continuei utilizando o método Parameters.Add em vez de AddWithValue para garantir a correta especificação dos tipos de dados. 
        */
        public async Task IncluiClienteAsync(Cliente cliente)
        {
            // Query SQL para inserir um novo cliente na tabela.
            const string query = @"INSERT INTO Clientes (Nome, Profissao, Setor, Cep, Rua, Numero, Cidade, Estado, Observacao) 
                               VALUES (@Nome, @Profissao, @Setor, @Cep, @Rua, @Numero, @Cidade, @Estado, @Observacao)";

            // Bloco try para capturar exceções.
            try
            {
                // Abre a conexão com o banco de dados e inicia uma transação.
                using (var conexaoBd = new SqlConnection(_conexao))
                {
                    await conexaoBd.OpenAsync(); // Abre a conexão de forma assíncrona.

                    // Inicia uma transação para garantir atomicidade da operação.
                    using (var transacao = conexaoBd.BeginTransaction())
                    using (var comando = new SqlCommand(query, conexaoBd, transacao))
                    {
                        try
                        {
                            // Adiciona os parâmetros para prevenir injeção de SQL.
                            comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cliente.Nome ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Profissao", SqlDbType.NVarChar).Value = cliente.Profissao ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Setor", SqlDbType.NVarChar).Value = cliente.Setor ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Cep", SqlDbType.NVarChar).Value = cliente.Cep ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Rua", SqlDbType.NVarChar).Value = cliente.Rua ?? (object)DBNull.Value;

                            // Trata o campo 'Numero', que é do tipo int? (pode ser nulo).
                            comando.Parameters.Add("@Numero", SqlDbType.Int).Value = cliente.Numero.HasValue ? (object)cliente.Numero.Value : DBNull.Value;
                            comando.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = cliente.Cidade ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = cliente.Estado ?? (object)DBNull.Value;
                            comando.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = cliente.Observacao ?? (object)DBNull.Value;

                            // Executa a query SQL de forma assíncrona.
                            await comando.ExecuteNonQueryAsync();

                            // Confirma a transação caso não haja exceções.
                            transacao.Commit();
                        }
                        catch (Exception)
                        {
                            // Reverte a transação em caso de erro.
                            transacao.Rollback();
                            throw;
                        }
                    }
                }
            }
            // Captura e trata erros específicos de SQL.
            catch (SqlException ex)
            {
                throw new Exception($"Erro de banco de dados ao incluir cliente: {ex.Message}", ex);
            }
            // Captura qualquer outro tipo de exceção.
            catch (Exception ex)
            {
                throw new Exception($"Erro geral ao incluir cliente: {ex.Message}", ex);
            }
        }

        // Método que obtém um cliente a partir de seu código (identificador único).
        // Retorna um objeto 'Cliente' preenchido ou null se o cliente não for encontrado.


        public Cliente ObtemCliente(int codigoCliente)
        {
            // Query SQL que seleciona todos os campos de um cliente específico, filtrando pelo 'CodigoCliente'.
            const string query = "SELECT * FROM Clientes WHERE CodigoCliente = @CodigoCliente";
            Cliente cliente = null; // Variável para armazenar o cliente retornado.

            // Bloco try para tratar exceções.
            try
            {
                // Criação de conexão com o banco de dados.
                using (var conexaoBd = new SqlConnection(_conexao))
                // Criação do comando SQL associado à conexão e à query.
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    // Adiciona o parâmetro '@CodigoCliente' ao comando SQL.
                    comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);

                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Executa a query e obtém os dados do cliente através de um SqlDataReader.
                    using (var reader = comando.ExecuteReader())
                    {
                        // Verifica se a consulta retornou algum registro.
                        if (reader.Read())
                        {
                            // Instancia um novo objeto Cliente e preenche suas propriedades com os dados do banco.
                            cliente = new Cliente
                            {
                                CodigoCliente = Convert.ToInt32(reader["CodigoCliente"]),
                                Nome = reader["Nome"].ToString(),
                                Profissao = reader.IsDBNull(reader.GetOrdinal("Profissao")) ? null : reader["Profissao"].ToString(),
                                Setor = reader.IsDBNull(reader.GetOrdinal("Setor")) ? null : reader["Setor"].ToString(),
                                Cep = reader.IsDBNull(reader.GetOrdinal("Cep")) ? null : reader["Cep"].ToString(),
                                Rua = reader.IsDBNull(reader.GetOrdinal("Rua")) ? null : reader["Rua"].ToString(),
                                Numero = reader.IsDBNull(reader.GetOrdinal("Numero")) ? (int?)null : Convert.ToInt32(reader["Numero"]),
                                Cidade = reader.IsDBNull(reader.GetOrdinal("Cidade")) ? null : reader["Cidade"].ToString(),
                                Estado = reader.IsDBNull(reader.GetOrdinal("Estado")) ? null : reader["Estado"].ToString(),
                                Observacao = reader.IsDBNull(reader.GetOrdinal("Observacao")) ? null : reader["Observacao"].ToString(),
                            };
                        }
                    }
                }
            }
            // Captura exceções e as lança com uma mensagem detalhada.
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o cliente: {ex.Message}", ex);
            }

            // Retorna o cliente obtido ou null.
            return cliente;
        }

        // Método que busca clientes no banco de dados com base em um termo de pesquisa (opcional).
        // Retorna um DataSet contendo os resultados da busca.
        public DataSet BuscaCliente(string pesquisa = "")
        {
            // Query SQL que realiza uma busca por clientes, filtrando pelo nome.
            const string query = "SELECT * FROM Clientes WHERE Nome LIKE @Pesquisa";

            try
            {
                // Cria uma nova conexão com o banco de dados.
                using (var conexaoBd = new SqlConnection(_conexao))
                // Criação do comando SQL associado à query e à conexão.
                using (var comando = new SqlCommand(query, conexaoBd))
                // Criação de um adaptador para preencher o DataSet com os resultados da busca.
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    // Prepara o valor do parâmetro de pesquisa, adicionando '%' para permitir busca parcial.
                    string parametroPesquisa = $"%{pesquisa}%";
                    // Adiciona o parâmetro de pesquisa à query SQL.
                    comando.Parameters.Add("@Pesquisa", SqlDbType.NVarChar).Value = parametroPesquisa;

                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Criação do DataSet que será preenchido com os resultados da busca.
                    var dsClientes = new DataSet();
                    adaptador.Fill(dsClientes, "Clientes"); // Preenche o DataSet com os resultados da query.
                    return dsClientes; // Retorna o DataSet preenchido.
                }
            }
            // Captura exceções e lança uma nova exceção com uma mensagem detalhada.
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar clientes: {ex.Message}", ex);
            }
        }

        // Método que atualiza os dados de um cliente no banco de dados.
        public void AlteraCliente(Cliente cliente)
        {
            // Query SQL que atualiza os campos de um cliente na tabela 'Clientes'.
            const string query = @"
                                UPDATE Clientes 
                                SET 
                                    Nome = @Nome, 
                                    Profissao = @Profissao, 
                                    Setor = @Setor, 
                                    Cep = @Cep, 
                                    Rua = @Rua, 
                                    Numero = @Numero, 
                                    Cidade = @Cidade, 
                                    Estado = @Estado, 
                                    Observacao = @Observacao
                                WHERE CodigoCliente = @CodigoCliente";

            try
            {
                // Criação de uma conexão com o banco de dados.
                using (var conexaoBd = new SqlConnection(_conexao))
                // Criação do comando SQL associado à query e à conexão.
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    // Adiciona os parâmetros ao comando SQL, prevenindo injeção de SQL.
                    comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cliente.Nome ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Profissao", SqlDbType.NVarChar).Value = cliente.Profissao ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Setor", SqlDbType.NVarChar).Value = cliente.Setor ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Cep", SqlDbType.NVarChar).Value = cliente.Cep ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Rua", SqlDbType.NVarChar).Value = cliente.Rua ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Numero", SqlDbType.Int).Value = cliente.Numero.HasValue ? (object)cliente.Numero.Value : DBNull.Value;
                    comando.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = cliente.Cidade ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = cliente.Estado ?? (object)DBNull.Value;
                    comando.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = cliente.Observacao ?? (object)DBNull.Value;

                    // Adiciona o parâmetro do código do cliente para identificar qual registro será atualizado.
                    comando.Parameters.Add("@CodigoCliente", SqlDbType.Int).Value = cliente.CodigoCliente;

                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Executa o comando SQL para atualizar o registro.
                    comando.ExecuteNonQuery();
                }
            }
            // Captura exceções específicas de SQL e lança uma exceção com detalhes adicionais.
            catch (SqlException ex)
            {
                throw new Exception($"Erro de banco de dados ao alterar o cliente: {ex.Message}", ex);
            }
            // Captura outras exceções e lança uma exceção detalhada.
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar o cliente: {ex.Message}", ex);
            }
        }

        // Método que exclui um cliente do banco de dados com base no código do cliente.
        public void ExcluiCliente(int codigoCliente)
        {
            // Query SQL que deleta um cliente específico da tabela 'Clientes'.
            const string query = "DELETE FROM Clientes WHERE CodigoCliente = @CodigoCliente";

            try
            {
                // Criação de uma conexão com o banco de dados.
                using (var conexaoBd = new SqlConnection(_conexao))
                // Criação do comando SQL associado à query e à conexão.
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    // Adiciona o parâmetro para o código do cliente.
                    comando.Parameters.Add("@CodigoCliente", SqlDbType.Int).Value = codigoCliente;

                    // Abre a conexão com o banco de dados.
                    conexaoBd.Open();

                    // Executa o comando SQL para excluir o cliente.
                    comando.ExecuteNonQuery();
                }
            }
            // Captura exceções de SQL e lança uma exceção detalhada.
            catch (SqlException ex)
            {
                throw new Exception($"Erro de banco de dados ao excluir o cliente: {ex.Message}", ex);
            }
            // Captura outras exceções e lança uma exceção detalhada.
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o cliente: {ex.Message}", ex);
            }
        }
    }
}
