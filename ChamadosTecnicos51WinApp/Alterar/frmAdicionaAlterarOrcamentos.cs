using Data; // Importa o namespace para acessar classes relacionadas aos dados do sistema
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Forms.Alterar; // Importa o namespace para acessar classes relacionadas à alteração de chamados
using System.Data.SqlClient; // Importa o namespace para acesso ao SQL Server

namespace Forms.Adicionar
{
    /// <summary>
    /// Formulário para adicionar ou alterar chamados.
    /// </summary>
    public partial class frmAdicionaAlterarOrcamentos : Form
    {
        // Define uma variável chamada "_conexao" para armazenar a string de conexão
        string _conexao = Forms.Properties.Settings.Default.Conexao;

        /*
         Este código é o construtor da classe frmAdicionaAlterarChamados e é chamado quando um novo objeto dessa classe é instanciado.
         O parâmetro (int codigo) no construtor frmAdicionaAlterarChamados(int codigo) recebe o código do chamado a ser adicionado ou alterado. 
         Ele permite distinguir entre a adição de um novo chamado e a alteração de um chamado existente.
         Quando um novo objeto frmAdicionaAlterarChamados é instanciado e o construtor é chamado com um valor de código específico, indica que o formulário está sendo aberto para a alteração de um chamado existente. 
         Nesse caso, os dados do chamado correspondente são carregados nos campos do formulário para permitir sua edição.
         Com base no valor do código recebido, o construtor pode realizar ações específicas, como carregar os dados de um chamado existente para edição ou configurar o formulário para permitir a adição de um novo chamado, 
         caso o valor do código seja nulo ou zero.
         Vamos setar o codigo = 0 para caso não enviar nenhuma informação quando chamar o form ganhamos tempo e evitamos erros.
        */
        public frmAdicionaAlterarOrcamentos(int codigo = 0)
        {
            InitializeComponent();
            // Para evitar que os campos fiquem preenchidos, antes de qualquer metodo vamos limpar todos os campos
            LimparCampos();

            if (codigo > 0)
            {
                PreencherCamposComChamado(codigo);
            }
            else
            {
                // Chama os métodos ListarTecnicos para preencher as listas de clientes e técnicos
                ListarTecnicos();
            }
        }

        /// <summary>
        /// Preenche os campos do formulário com os dados do chamado correspondente ao código fornecido.
        /// </summary>
        /// <param name="codigo">Código do chamado a ser preenchido.</param>
        private void PreencherCamposComChamado(int codigo)
        {
            // Cria um objeto Chamado
            Orcamento chamado = new Orcamento();

            // Cria um objeto ChamadoDao
            OrcamentoDao chamadodao = new OrcamentoDao(_conexao);

            chamado = chamadodao.ObtemOrcamento(codigo);

            if (chamado == null)
            {
                MessageBox.Show("Chamado não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListarTecnicos();
                txbCodigoOrcamento.Text = "0";
            }
            else
            {
                txbCodigoOrcamento.Text = chamado.CodigoOrcamento.ToString();
                ListarClientes(chamado.CodigoCliente);
                ListarTecnicos(chamado.CodigoTecnico);
                txBoxOcorrencia.Text = chamado.Ocorrencia;
                txbProblema.Text = chamado.Problema;
            }
        }

        /// <summary>
        /// Lista os clientes e preenche o campo de cliente com o nome do cliente correspondente ao código fornecido.
        /// </summary>
        /// <param name="codigo">Código do cliente a ser preenchido.</param>
        private void ListarClientes(int codigo)
        {
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao(_conexao);
            cliente = clientedao.ObtemCliente(codigo);
            txbCliente.Text = cliente.Nome;
            txbCliente.Tag = cliente.CodigoCliente;
        }

        /*
        O objetivo desse método é listar os Técnicos disponíveis em um controle ComboBox (cbTecnico). 
        Ele segue a mesma lógica do ListarClientes(int codigo = 0) , fiz uma cópia do ListarClientes e adaptei para o Técnico
        */
        /// <summary>
        /// Lista os técnicos disponíveis em um controle ComboBox (cbTecnico), preenchendo-o com os dados recuperados do banco de dados.
        /// </summary>
        /// <param name="codigo">Código do técnico a ser exibido inicialmente. Se for 0, todos os técnicos serão listados.</param>
        private void ListarTecnicos(int codigo = 0)
        {
            // Instancia um objeto TecnicoDao para acessar os dados dos técnicos
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            if (codigo == 0)
            {
                // Se o código for 0, todos os técnicos serão listados

                // Cria um novo DataSet para armazenar os dados dos técnicos
                DataSet dsListaTecnico = new DataSet();

                // Obtém os dados dos técnicos do banco de dados
                dsListaTecnico = tecnicodao.BuscaTecnico();

                // Define o DataSet como a origem de dados para o ComboBox cbTecnico
                cbTecnico.DataSource = dsListaTecnico.Tables["Tecnicos"];

                // Define a coluna a ser exibida no ComboBox como o nome do técnico
                cbTecnico.DisplayMember = "Nome";

                // Define a coluna que contém os valores a serem retornados como o código do técnico
                cbTecnico.ValueMember = "CodigoTecnico";

                // Define o valor selecionado inicialmente (opcional)
                cbTecnico.SelectedValue = 0;
            }
            else
            {
                // Caso contrário, apenas o técnico com o código especificado será listado

                // Obtém o técnico com o código fornecido
                Tecnico tecnico = tecnicodao.ObtemTecnicoPorCodigo(codigo);

                // Cria uma lista de técnicos e adiciona o técnico recuperado
                List<Tecnico> listaTecnicos = new List<Tecnico>();
                listaTecnicos.Add(tecnico);

                // Define a lista de técnicos como a origem de dados para o ComboBox cbTecnico
                cbTecnico.DataSource = listaTecnicos;

                // Define a coluna a ser exibida no ComboBox como o nome do técnico
                cbTecnico.DisplayMember = "Nome";

                // Define a coluna que contém os valores a serem retornados como o código do técnico
                cbTecnico.ValueMember = "CodigoTecnico";

                // Atualiza o ComboBox
                cbTecnico.Refresh();
            }
        }


        /*
          Esse método percorre cada campo desejado e executa a ação apropriada para limpá-lo. 
          Por exemplo, define o índice selecionado nas ComboBoxes como -1 para que nenhuma opção seja selecionada, 
          define a data atual no DatePicker e limpa o conteúdo dos TextBoxes. Ao chamar esse método, todos esses campos serão limpos, 
          permitindo que o usuário insira novos dados.
        */

        /// <summary>
        /// Limpa todos os campos do formulário, restaurando-os aos valores padrão.
        /// </summary>
        private void LimparCampos()
        {
            // Limpa a seleção da ComboBox cbCliente
            txbCliente.Clear();

            // Limpa a seleção da ComboBox cbTecnico
            cbTecnico.SelectedIndex = -1;

            // Define a data atual no DatePicker dtpSolicita
            dtpSolicita.Value = DateTime.Now;

            // Limpa o conteúdo do TextBox txBoxOcorrencia
            txBoxOcorrencia.Clear();

            // Limpa o conteúdo do TextBox txbProblema
            txbProblema.Clear();
        }


        /// <summary>
        /// Obtém um objeto Tecnico com base no código do técnico fornecido.
        /// </summary>
        /// <param name="codigoTecnico">O código do técnico a ser buscado.</param>
        /// <returns>O objeto Tecnico correspondente ao código fornecido, ou null se nenhum técnico for encontrado.</returns>
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


        // Evento de clique no botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Evento de clique no botão Selecionar Cliente
        private void btnSelecionaCliente_Click(object sender, EventArgs e)
        {
            frmSelecionaCliente formSCliente = new frmSelecionaCliente(this);
            formSCliente.ShowDialog();
        }

        // Evento de clique no botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbCliente.Tag == null || (int)txbCliente.Tag < 1)
            {
                MessageBox.Show("Preencha um Cliente !");
                return;
            }

            // Instanciando a classe ChamadoDao para acesso aos dados
            OrcamentoDao oracamentodao = new OrcamentoDao(_conexao);

            // Verifica se o chamado foi concluído ou não
            bool oracamentoConcluido = rbConcluidoSim.Checked;
            bool orcamentoFoiConcluido = false;
            if (oracamentoConcluido)
            {
                orcamentoFoiConcluido = true;
            }

            try
            {
                // Criando um objeto Chamado e preenchendo suas propriedades com os valores dos campos do formulário
                Orcamento orcamento = new Orcamento
                {
                    // Validando e atribuindo CodigoCliente
                    CodigoCliente = (int)txbCliente.Tag,

                    // Validando e atribuindo CodigoTecnico
                    CodigoTecnico = cbTecnico.SelectedValue != null && int.TryParse(cbTecnico.SelectedValue.ToString(), out int codigoTecnico) ? codigoTecnico : 0,

                    // Validando e atribuindo DataSolicitacao
                    DataSolicitacao = dtpSolicita.Value,

                    // Atribuindo Ocorrencia (condicionalmente)
                    Ocorrencia = !string.IsNullOrEmpty(txBoxOcorrencia.Text) ? txBoxOcorrencia.Text : null,

                    // Atribuindo Problema (condicionalmente)
                    Problema = !string.IsNullOrEmpty(txBoxOcorrencia.Text) ? txBoxOcorrencia.Text : null,

                    // Atribuindo Concluido
                    Concluido = orcamentoFoiConcluido
                };

                // Obtendo o valor do campo txbCodigoChamado convertido para int
                int codigo = Convert.ToInt32(txbCodigoOrcamento.Text);

                if (codigo == 0)
                {
                    // Se o código for igual a 0, significa que é um novo chamado e deve ser incluído no banco de dados
                    oracamentodao.IncluiOrcamento(orcamento);
                }
                else
                {
                    // Se o código for diferente de 0, significa que é uma alteração de um chamado existente e deve ser atualizado no banco de dados
                    orcamento.CodigoOrcamento = codigo; // Preenche a propriedade CodigoChamado com o código do chamado a ser alterado
                    oracamentodao.AlterarOrcamento(orcamento);
                }

                // Fechando o formulário após a operação ser concluída com sucesso
                this.Close();
            }
            catch (Exception erro)
            {
                // Exibindo uma mensagem de erro em caso de exceção
                MessageBox.Show("Ocorreu um erro!!" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}