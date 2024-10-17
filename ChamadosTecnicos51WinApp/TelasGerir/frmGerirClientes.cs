// Bibliotecas padrão do .NET para funcionalidades gerais, coleções, UI, etc.
using System; // Contém tipos fundamentais e classes base para todos os aplicativos.
using System.Collections.Generic; // Fornece definições para coleções genéricas de objetos.
using System.ComponentModel; // Inclui classes base para implementar o comportamento em tempo de execução e design de componentes e controles.
using System.Data; // Fornece acesso a dados e manipulação de dados para aplicativos de banco de dados.
using System.Drawing; // Contém classes para trabalhar com gráficos, imagens e fontes.
using System.Linq; // Oferece funcionalidades para consultar objetos em coleções, arrays, etc.
using System.Text; // Contém classes que representam codificações de caracteres ASCII e Unicode.
using System.Threading.Tasks; // Facilita o uso de operações assíncronas, permitindo código mais limpo e responsivo.
using System.Windows.Forms; // Fornece classes para criar aplicativos baseados em Windows com uma rica interface gráfica.

// Referências específicas ao projeto e namespaces para funcionalidades customizadas e gerenciamento de telas.
using Data; // Contém funcionalidades relacionadas ao acesso e manipulação de dados.
using Forms.Alterar; // Contém telas ou lógicas para alteração de registros, como clientes ou chamados.

namespace Forms.TelasGerir
{
    public partial class frmGerirClientes : Form
    {
        /* 
         Cria uma variável para armazenar a string de conexão ao banco de dados.
         A string é obtida da configuração "Settings" no arquivo Settings.settings do projeto, 
         que contém as propriedades de configuração do aplicativo.
        */
        string _conexao = Forms.Properties.Settings.Default.Conexao;

        // Construtor do formulário frmGerirClientes.
        public frmGerirClientes()
        {
            // Inicializa os componentes da interface gráfica.
            InitializeComponent();

            // Chama o método ListarCliente() para preencher o DataGridView com a lista de clientes ao abrir o formulário.
            ListarCliente();

            // Configura as propriedades visuais do DataGridView através do método configuDataGrid().
            configuDataGrid();
        }

        /*
         Método responsável por configurar a aparência e o comportamento do DataGridView (dgvCliente).
         Modifica estilos de célula, alinhamento de texto, visibilidade de colunas e ordenação dos dados.
        */
        private void configuDataGrid()
        {
            // Define a fonte padrão das células do DataGridView como Arial, tamanho 9 e estilo negrito.
            dgvCliente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            // Define a largura das células de cabeçalho da linha (seletor) como 25 pixels.
            dgvCliente.RowHeadersWidth = 25;

            // Oculta a coluna "CodigoCliente" do DataGridView para que ela não seja exibida.
            dgvCliente.Columns["CodigoCliente"].Visible = false;

            // Centraliza o texto no cabeçalho e nas células da coluna "Nome".
            dgvCliente.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Nome"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            // Ordena os dados pela coluna "Nome" em ordem ascendente.
            dgvCliente.Sort(dgvCliente.Columns["Nome"], ListSortDirection.Ascending);

            // Centraliza o texto no cabeçalho e nas células da coluna "Profissao".
            dgvCliente.Columns["Profissao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Profissao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Profissao"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgvCliente.Columns["Profissao"].HeaderText = "Profissão"; // Define o texto do cabeçalho como "Profissão".

            // Centraliza o texto no cabeçalho e nas células da coluna "Setor".
            dgvCliente.Columns["Setor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Setor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Setor"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
        }

        /*
         Método responsável por listar os clientes no DataGridView.
         Utiliza a classe ClienteDao para obter dados dos clientes de acordo com o critério de busca.
         Os dados são carregados no DataSet e exibidos no DataGridView.
        */
        private void ListarCliente()
        {
            // Cria uma instância da classe ClienteDao para manipulação de dados, passando a string de conexão como parâmetro.
            ClienteDao clienteDao = new ClienteDao(_conexao);

            // Obtém o termo de busca digitado na caixa de texto txbBuscar.
            string busca = txbBuscar.Text.Trim(); // Trim remove espaços extras.

            // Busca os dados dos clientes usando o termo de pesquisa.
            DataSet dsCliente = new DataSet();
            dsCliente = clienteDao.BuscaCliente(busca);

            // Define o DataSource do DataGridView como o DataSet dsCliente.
            dgvCliente.DataSource = dsCliente;

            // Define o DataMember como "Clientes", especificando a tabela de dados a ser exibida.
            dgvCliente.DataMember = "Clientes";
        }

        /*
         Método associado ao evento de clique do botão "Incluir".
         Ao ser clicado, abre o formulário de inserção de cliente e, ao fechar, atualiza a lista de clientes.
        */
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário para adicionar um novo cliente.
            var frmInsereCliente = new frmClienteAdicionar();

            // Exibe o formulário como uma janela modal (diálogo), bloqueando a janela principal até que seja fechado.
            frmInsereCliente.ShowDialog();

            // Atualiza a lista de clientes no DataGridView.
            ListarCliente();
        }

        /*
         Método associado ao evento de clique do botão "Alterar".
         Permite ao usuário alterar os dados de um cliente selecionado no DataGridView.
        */
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se alguma linha está selecionada no DataGridView.
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Obtém o código do cliente da linha selecionada (primeira célula da linha).
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                // Cria uma instância do formulário de alteração de cliente, passando o código do cliente como parâmetro.
                var frmAlteraCliente = new frmClienteAlterar(codigo);

                // Exibe o formulário como uma janela modal (diálogo).
                frmAlteraCliente.ShowDialog();

                // Atualiza a lista de clientes no DataGridView.
                ListarCliente();
            }
            else
            {
                // Exibe uma mensagem de aviso se nenhuma linha estiver selecionada.
                MessageBox.Show("Selecione um registro para alteração!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         Método associado ao evento de clique do botão "Excluir".
         Permite ao usuário excluir um cliente selecionado no DataGridView após confirmação.
        */
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se alguma linha está selecionada no DataGridView.
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Obtém o código do cliente da linha selecionada (primeira célula da linha).
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                // Exibe uma caixa de diálogo de confirmação perguntando se o usuário deseja excluir o cliente.
                var resultado = MessageBox.Show(
                    "Deseja excluir esse registro?",
                    "Pergunta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Se o usuário confirmar a exclusão (clicar em "Sim").
                if (resultado == DialogResult.Yes)
                {
                    // Cria uma instância da classe ClienteDao para manipulação de dados.
                    ClienteDao clienteDao = new ClienteDao(_conexao);

                    // Chama o método ExcluiCliente, passando o código do cliente.
                    clienteDao.ExcluiCliente(codigo);

                    // Atualiza a lista de clientes no DataGridView.
                    ListarCliente();
                }
            }
            else
            {
                // Exibe uma mensagem de aviso se nenhuma linha estiver selecionada.
                MessageBox.Show("Selecione um registro para exclusão!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         Evento KeyDown associado à caixa de texto de busca (txbBuscar).
         Se a tecla "Enter" for pressionada, o método ListarCliente é chamado para atualizar os resultados de busca.
        */
        private void txbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é a tecla "Enter".
            if (e.KeyCode == Keys.Enter)
            {
                // Chama o método ListarCliente() para realizar a busca e atualizar a lista de clientes.
                ListarCliente();
            }
        }

        /*
         Evento de clique associado ao botão "Buscar".
         Verifica se o campo de busca está vazio. Se estiver, exibe um aviso, caso contrário, chama o método ListarCliente.
        */
        private void btnBusca_Click(object sender, EventArgs e)
        {
            // Verifica se a caixa de busca está vazia.
            if (txbBuscar.Text == "")
            {
                // Exibe uma mensagem de aviso indicando que o campo de busca está vazio.
                MessageBox.Show("Informe um conteúdo !");
                // Define o foco para o campo de busca.
                txbBuscar.Focus();
            }
            // Se a caixa de busca tiver algum valor, chama o método ListarCliente() para realizar a busca.
            ListarCliente();
        }
    }
}
