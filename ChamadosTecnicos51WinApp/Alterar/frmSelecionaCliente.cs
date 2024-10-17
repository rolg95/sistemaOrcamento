// Importa o namespace ChamadosTecnicos51Data para acessar classes relacionadas aos dados do sistema
using Data;

// Importa o namespace ChamadosTecnicos51WinApp.Adicionar para acessar o formulário de adicionar chamados
using Forms.Adicionar;

// Importa o namespace System para acessar classes básicas do sistema
using System;

// Importa o namespace System.Collections.Generic para acessar tipos de coleções genéricas
using System.Collections.Generic;

// Importa o namespace System.ComponentModel para acessar classes relacionadas à programação de componentes
using System.ComponentModel;

// Importa o namespace System.Data para acessar classes relacionadas ao acesso a dados
using System.Data;

// Importa o namespace System.Drawing para acessar classes relacionadas à criação de gráficos e imagens
using System.Drawing;

// Importa o namespace System.Linq para acessar métodos de extensão LINQ
using System.Linq;

// Importa o namespace System.Text para acessar classes relacionadas à manipulação de strings e caracteres
using System.Text;

// Importa o namespace System.Threading.Tasks para acessar classes relacionadas à programação assíncrona
using System.Threading.Tasks;

// Importa o namespace System.Windows.Forms para acessar classes relacionadas à criação de aplicativos Windows Forms
using System.Windows.Forms;


namespace Forms.Alterar
{
    public partial class frmSelecionaCliente : Form
    {
        // Declaração da variável _conexao e atribuição do valor da string de conexão
        string _conexao = Forms.Properties.Settings.Default.Conexao;

        // Criação de uma instância da classe frmAdicionaAlterarChamados
        frmAdicionaAlterarOrcamentos formChamados = new frmAdicionaAlterarOrcamentos();

        // Criação do construtor do frmSelecionaCliente que recebe um parâmetro do tipo frmAdicionaAlterarChamados (f)
        public frmSelecionaCliente(frmAdicionaAlterarOrcamentos f)
        {
            // Inicialização dos componentes do formulário
            InitializeComponent();

            // Atribuição do valor do parâmetro f (frmAdicionaAlterarChamados) à variável formChamados
            formChamados = f;
        }

        // Método chamado quando o formulário é carregado
        private void frmSelecionaCliente_Load(object sender, EventArgs e)
        {
            // Cria uma instância do objeto ClienteDao para acessar os dados do cliente
            ClienteDao clientedao = new ClienteDao(_conexao);

            // Cria um objeto DataSet para armazenar os dados do cliente
            DataSet dsListaCliente = new DataSet();

            // Chama o método BuscaCliente do objeto ClienteDao para obter os dados dos clientes e coloca no Dataset
            dsListaCliente = clientedao.BuscaCliente();

            // Define o DataSource do DataGridView como o DataSet dsCliente.
            dgvSelecionaCliente.DataSource = dsListaCliente;
            // Define o DataMember do DataGridView como "Clientes" para especificar a tabela a ser exibida.
            dgvSelecionaCliente.DataMember = "Clientes";
        }

        // Método chamado quando o usuário clica duas vezes em uma célula do DataGridView
        private void dgvSelecionaCliente_DoubleClick(object sender, EventArgs e)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dgvSelecionaCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvSelecionaCliente.SelectedRows[0];

                // Verifica se a célula "Nome" e seu valor não são nulos antes de acessá-los
                if (selectedRow.Cells["Nome"] != null && selectedRow.Cells["Nome"].Value != null)
                {
                    // Obtém o nome da célula selecionada
                    string nome = selectedRow.Cells["Nome"].Value.ToString();

                    // Verifica se a célula "CodigoCliente" e seu valor não são nulos antes de acessá-los
                    if (selectedRow.Cells["CodigoCliente"] != null && selectedRow.Cells["CodigoCliente"].Value != null)
                    {
                        // Obtém o código da célula selecionada
                        int codigo = Convert.ToInt32(selectedRow.Cells["CodigoCliente"].Value);

                        // Preenche o TextBox com o nome
                        formChamados.txbCliente.Text = nome;

                        // Define a Tag do formulário com o código
                        // Tag: A propriedade Tag é uma propriedade genérica disponível em vários controles do Windows Forms, incluindo o TextBox.
                        // É usada para armazenar dados extras associados a um controle.
                        formChamados.txbCliente.Tag = codigo;

                        // Fecha o formulário de seleção do cliente
                        Close();
                    }
                }
            }
        }
    }
}
