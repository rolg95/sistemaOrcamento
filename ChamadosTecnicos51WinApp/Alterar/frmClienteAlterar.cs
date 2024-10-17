using Data; // Importa o namespace para acessar classes relacionadas aos dados do sistema
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Alterar
{
    /// <summary>
    /// Formulário para alterar informações de um cliente.
    /// </summary>
    public partial class frmClienteAlterar : Form
    {
        // Declaração da variável _conexao que armazena a string de conexão
        string _conexao = Forms.Properties.Settings.Default.Conexao;

        /// <summary>
        /// Construtor da classe frmClienteAlterar.
        /// </summary>
        /// <param name="codigo">Código do cliente a ser alterado.</param>
        public frmClienteAlterar(int codigo)
        {
            InitializeComponent();

            // Verifica se o código é maior que zero para realizar a busca e preencher os campos
            if (codigo > 0)
            {
                // Cria uma instância do objeto Cliente
                Cliente cliente = new Cliente();

                // Cria uma instância do objeto ClienteDao
                ClienteDao clienteDao = new ClienteDao(_conexao);

                // Obtém o cliente a partir do código fornecido
                cliente = clienteDao.ObtemCliente(codigo);

                // Verifica se o cliente foi encontrado
                if (cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Fecha o formulário
                    this.Close();
                }

                // Preenche os campos do formulário com os dados do cliente
                txbCodigoCliente.Text = cliente.CodigoCliente.ToString();
                txbNome.Text = cliente.Nome;
                txbProfissao.Text = cliente.Profissao;
                txbSetor.Text = cliente.Setor;
                msbCep.Text = cliente.Cep;
                txbCidade.Text = cliente.Cidade;
                txbEstado.Text = cliente.Estado;
                txbNumero.Text = cliente.Numero.ToString(); 
                txbObs.Text = cliente.Observacao;

            }
        }

        /// <summary>
        /// Evento de clique no botão salvar.
        /// </summary>
        /// <param name="sender">O objeto que acionou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // Criação de um objeto Cliente
            Cliente cliente = new Cliente();

            // Criação de um objeto ClienteDao
            ClienteDao clienteDao = new ClienteDao(_conexao);

            try
            {
                // Atribui os valores dos campos de texto aos atributos do objeto Cliente
                cliente.Nome = txbNome.Text;
                cliente.Profissao = txbProfissao.Text;
                cliente.Setor = txbSetor.Text;
                cliente.Cep = msbCep.Text;
                cliente.Cidade = txbCidade.Text;
                cliente.Estado = txbEstado.Text;
                cliente.Numero = int.Parse(txbNumero.Text); // Converte o texto para inteiro
                cliente.Observacao = txbObs.Text;


                /* 
                    Observação sobre converter números
                    int.Parse()
                    Uso: Ideal quando você está confiante de que a string sempre contém um número válido que pode ser convertido em inteiro.
                    Comportamento: Lança uma exceção (FormatException) se a string não for um número válido e uma OverflowException se o número for muito grande ou pequeno para ser representado como um inteiro.
                    Exemplo : int numero = int.Parse("123"); // OK
                              int numero = int.Parse("abc"); // Lança FormatException


                    Convert.ToInt32()
                    Uso: Útil quando você também precisa lidar com null ou com representações numéricas em outros formatos (como bool ou float).
                    Comportamento: Similar ao int.Parse(), mas retorna 0 se a string for null. Também lança FormatException e OverflowException.
                
                    Exemplo : int numero = Convert.ToInt32("123"); // OK
                              int numero = Convert.ToInt32("abc"); // Lança FormatException
                              int numero = Convert.ToInt32(null); // Retorna 0
                
                 */

                // Converte o valor do campo de texto CodigoCliente para inteiro
                int codigo = Convert.ToInt32(txbCodigoCliente.Text);

                // Atribui o valor do código ao atributo CodigoCliente do objeto Cliente
                cliente.CodigoCliente = codigo;

                // Chama o método AlteraCliente do objeto ClienteDao para alterar os dados do cliente no banco de dados
                clienteDao.AlteraCliente(cliente);

                // Fecha o formulário
                this.Close();
            }
            catch (Exception erro)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção durante a alteração do cliente
                MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
