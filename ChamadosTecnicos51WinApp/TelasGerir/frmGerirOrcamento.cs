using Data; // Importa a biblioteca de acesso a dados
using Forms.Adicionar; // Importa a tela de adicionar chamado
using Forms.Alterar; // Importa a tela de alterar chamado
using System; // Importa funcionalidades básicas da linguagem C#
using System.Collections.Generic; // Importa funcionalidades para trabalhar com coleções
using System.ComponentModel; // Importa funcionalidades para trabalhar com componentes visuais
using System.Data; // Importa funcionalidades para trabalhar com dados
using System.Drawing; // Importa funcionalidades para trabalhar com interfaces gráficas
using System.Linq; // Importa funcionalidades para trabalhar com consultas LINQ
using System.Text; // Importa funcionalidades para trabalhar com strings
using System.Threading.Tasks; // Importa funcionalidades para trabalhar com tarefas assíncronas
using System.Windows.Forms; // Importa funcionalidades para trabalhar com formulários

namespace Forms.TelasGerir // Define o namespace da aplicação
{
    public partial class frmGerirOrcamento : Form // Define a classe principal do formulário
    {
        #region Variáveis

        // Armazena a string de conexão com o banco de dados
        private string _conexao = Forms.Properties.Settings.Default.Conexao;

        #endregion

        #region Construtor

        public frmGerirOrcamento() // Construtor da classe
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            ListarChamados(); // Lista os chamados na grid
            configuDataGrid(); // Configura a grid de chamados
        }

        #endregion

        /// <summary>
        /// Configura a grid de chamados.
        /// </summary>
        private void configuDataGrid()
        {
            // Define a fonte padrão e estilo das células do DataGridView como Arial, tamanho 9 e em negrito.
            dgvChamados.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            // Desabilita a opção de adicionar novas linhas manualmente no DataGridView.
            dgvChamados.AllowUserToAddRows = false;

            // Desabilita a opção de deletar linhas manualmente no DataGridView.
            dgvChamados.AllowUserToDeleteRows = false;

            // Permite que o usuário ordene as colunas do DataGridView clicando no cabeçalho das colunas.
            dgvChamados.AllowUserToOrderColumns = true;

            // Define o DataGridView como somente leitura, impedindo a edição direta das células.
            dgvChamados.ReadOnly = true;

            // Configura o modo de seleção do DataGridView para selecionar a linha inteira quando o usuário clicar em alguma célula.
            dgvChamados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desabilita a seleção múltipla de linhas no DataGridView, permitindo selecionar apenas uma linha por vez.
            dgvChamados.MultiSelect = false;

            // Define a largura da coluna de cabeçalho das linhas do DataGridView "dgvChamados" como 25 pixels.
            dgvChamados.RowHeadersWidth = 25;

            // Oculta as colunas "CodigoChamado", "fk_Clientes_CodigoCliente" e "fk_Tecnicos_CodigoTecnico".
            dgvChamados.Columns["CodigoChamado"].Visible = false;
            dgvChamados.Columns["fk_Clientes_CodigoCliente"].Visible = false;
            dgvChamados.Columns["fk_Tecnicos_CodigoTecnico"].Visible = false;

            // **Utiliza um laço de repetição para formatar as colunas da grid**

            // Percorre cada coluna do DataGridView
            foreach (DataGridViewColumn coluna in dgvChamados.Columns)
            {
                // Centraliza o texto do cabeçalho da coluna
                dgvChamados.Columns[coluna.Name].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Centraliza o texto das células de dados da coluna
                dgvChamados.Columns[coluna.Name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Adiciona um espaçamento à esquerda das células de dados da coluna
                dgvChamados.Columns[coluna.Name].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            }
        }

        /// <summary>
        /// Atualiza o DataGridView com a lista de chamados com base no texto de busca.
        /// </summary>
        private void ListarChamados()
        {
            // Instancia um objeto ChamadoDao com a string de conexão fornecida
            OrcamentoDao chamadosdao = new OrcamentoDao(_conexao);

            // Obtém o texto de busca da caixa de texto de pesquisa
            string busca = txbBuscar.Text.ToString();

            // Cria um novo DataSet para armazenar os dados retornados do banco de dados
            DataSet dsCliente = new DataSet();

            // Realiza a busca de chamados com base no texto de busca e armazena o resultado no DataSet
            dsCliente = chamadosdao.BuscaOrcamento(busca);

            // Define o DataSource do DataGridView como o DataSet contendo os dados dos chamados
            dgvChamados.DataSource = dsCliente;

            // Define o DataMember como "Chamados" para especificar a tabela a ser exibida no DataGridView
            dgvChamados.DataMember = "Chamados";
        }

        /// <summary>
        /// Manipula o evento de clique do botão "Incluir", abrindo o formulário para adicionar um novo chamado e atualizando a lista de chamados.
        /// </summary>
        /// <param name="sender">O objeto que acionou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // Instancia um novo formulário para adicionar ou alterar chamados
            var frmAdicionaAlteraChamados = new frmAdicionaAlterarOrcamentos();

            // Exibe o formulário de adição/alteração de chamados de forma modal
            frmAdicionaAlteraChamados.ShowDialog();

            // Atualiza a lista de chamados após fechar o formulário de adição/alteração
            ListarChamados();
        }


        /// <summary>
        /// Manipula o evento de clique do botão "Buscar", atualizando a lista de chamados com base no texto de busca.
        /// </summary>
        /// <param name="sender">O objeto que acionou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnBusca_Click(object sender, EventArgs e)
        {
            // Atualiza a lista de chamados com base no texto de busca
            ListarChamados();
        }

        /// <summary>
        /// Manipula o evento de clique do botão "Alterar", abrindo o formulário para alterar um chamado selecionado e atualizando a lista de chamados.
        /// </summary>
        /// <param name="sender">O objeto que acionou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada no DataGridView
            if (dgvChamados.SelectedRows.Count > 0)
            {
                // Obtém o código do chamado da linha selecionada
                int codigo = Convert.ToInt32(dgvChamados.CurrentRow.Cells["CodigoChamado"].Value);

                // Instancia um novo formulário para adicionar ou alterar chamados com o código do chamado a ser alterado
                var frmChamadosAlterar = new frmAdicionaAlterarOrcamentos(codigo);

                // Exibe o formulário de adição/alteração de chamados de forma modal
                frmChamadosAlterar.ShowDialog();

                // Atualiza a lista de chamados após fechar o formulário de adição/alteração
                ListarChamados();
            }
            else
            {
                // Exibe uma mensagem de alerta se nenhuma linha estiver selecionada
                MessageBox.Show("Selecione um registro para alteração!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Manipula o evento de clique do botão "Excluir", excluindo o chamado selecionado e atualizando a lista de chamados.
        /// </summary>
        /// <param name="sender">O objeto que acionou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada no DataGridView
            if (dgvChamados.SelectedRows.Count > 0)
            {
                // Obtém o código do chamado da linha selecionada
                int codigo = Convert.ToInt32(dgvChamados.CurrentRow.Cells["CodigoChamado"].Value);

                // Exibe uma mensagem de confirmação para excluir o chamado
                var resultado = MessageBox.Show(
                    "Deseja excluir esse registro?",
                    "Pergunta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Se o usuário confirmar a exclusão
                if (resultado == DialogResult.Yes)
                {
                    // Instancia um objeto ChamadoDao com a string de conexão
                    OrcamentoDao chamadodao = new OrcamentoDao(_conexao);

                    // Exclui o chamado com base no código obtido
                    chamadodao.ExcluiOrcamento(codigo);

                    // Atualiza a lista de chamados após excluir o registro
                    ListarChamados();
                }
            }
            else
            {
                // Exibe uma mensagem de alerta se nenhuma linha estiver selecionada
                MessageBox.Show("Selecione um registro para exclusão!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}