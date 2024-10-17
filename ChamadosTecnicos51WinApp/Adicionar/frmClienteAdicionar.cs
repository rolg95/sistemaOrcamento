using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Local onde está as configuraçãoes da conexão 
using System.Configuration;
using System.Data.SqlClient;
using Data;

namespace Forms
{
    public partial class frmClienteAdicionar : Form
    {
        //_conexao: variável local para conexão com banco de dados    
        //Conexao: Variavel global para conexão com banco de dados - Variável do App.Config
        // Lembre-se de criar a Pasta Properties dentro do projeto -> Add New Item -> Settings File
        string _conexao = Forms.Properties.Settings.Default.Conexao;
        public frmClienteAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*
               Nesse fragmento de código, está sendo criada uma nova instância da classe Cliente e atribuída à variável cliente.

               A instrução new() cria um novo objeto da classe Cliente, utilizando o construtor padrão da classe. Isso significa que está sendo criado um novo objeto vazio da classe Cliente, sem nenhum valor ou estado definido.

               A variável cliente é do tipo Cliente e serve como uma referência para o objeto criado. Com essa referência, você pode acessar os membros e métodos da classe Cliente, realizar operações e atribuir valores às propriedades e campos do objeto.

               Após criar a instância do objeto Cliente, você pode usar a variável cliente para realizar operações relacionadas a clientes, como definir propriedades específicas do cliente ou chamar métodos da classe Cliente.

               Lembre-se de que a classe Cliente deve estar corretamente definida em seu código ou em um arquivo de classe separado, e pode possuir propriedades, métodos e outros membros, dependendo da sua implementação.
            */

            Cliente cliente = new();

            /*  
               A instrução new MedicoDao(_conexao) cria um novo objeto da classe MedicoDao, utilizando o construtor que recebe um parâmetro _conexao. O valor da variável _conexao é passado como argumento para o construtor da classe MedicoDao.

               A classe MedicoDao é provavelmente uma classe responsável por realizar operações de acesso a dados relacionadas aos médicos, como consultas, inserções, atualizações ou exclusões no banco de dados.

               A variável medicoDao é do tipo MedicoDao e serve como uma referência para o objeto criado. Com essa referência, você pode chamar os métodos e utilizar os recursos disponíveis na classe MedicoDao para interagir com o banco de dados.

               Lembre-se de que a classe MedicoDao deve estar corretamente definida em seu código ou em um arquivo de classe separado, e pode possuir métodos e outros membros relacionados às operações com médicos e acesso a dados.
            */

            ClienteDao clienteDao = new ClienteDao(_conexao);

            //Inclusão
            // Verifica se os campos estão preenchidos corretamente
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbProfissao.Text) || string.IsNullOrWhiteSpace(txbSetor.Text))
            {
                // Exibe a mensagem de erro em uma MessageBox
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Atribuição de valores às propriedades do objeto 'cliente'
                    // Aqui, você está pegando o texto inserido nos TextBoxes da interface gráfica e atribuindo às propriedades do objeto 'cliente'.
                    cliente.Nome = txbNome.Text;        // Atribui o texto do campo 'txbNome' à propriedade 'Nome' do objeto 'cliente'.
                    cliente.Profissao = txbProfissao.Text; // Atribui o texto do campo 'txbProfissao' à propriedade 'Profissao' do objeto 'cliente'.
                    cliente.Setor = txbSetor.Text;        // Atribui o texto do campo 'txbSetor' à propriedade 'Setor' do objeto 'cliente'.
                    cliente.Observacao = txbObs.Text;        // Atribui o texto do campo 'txbSetor' à propriedade 'Setor' do objeto 'cliente'.
                    cliente.Cep = msbCep.Text; // Atribui o texto do novo campo 'txbCep' à propriedade 'Cep'.
                    cliente.Rua = txbRua.Text; // Atribui o texto do novo campo 'txbRua' à propriedade 'Rua'.
                    cliente.Cidade = txbCidade.Text; // Atribui o texto do novo campo 'txbCidade' à propriedade 'Cidade'.
                    cliente.Estado = txbEstado.Text; // Atribui o texto do novo campo 'txbEstado' à propriedade 'Estado'.
                    // Certifique-se de tratar o valor de 'txbxNumero' corretamente, pois é um inteiro.
                    cliente.Numero = int.TryParse(txbNumero.Text, out int numero) ? numero : (int?)null; // Tenta converter o texto do novo campo 'txbxNumero' para int.

                    /*
                     * int.TryParse(string?, out int)
                     * O método int.TryParse tenta converter a representação em string de um número para seu equivalente inteiro. 
                     * É uma forma segura de converter strings em números inteiros, pois não lança exceções em caso de falha na conversão (diferentemente de int.Parse), 
                     * retornando um valor booleano que indica se a conversão foi bem-sucedida ou não.
                     * 
                     * Parâmetros:
                     * 
                     * O primeiro parâmetro (string?) é a string que você deseja converter em um número inteiro. No seu caso, é o texto do campo txbNumero.Text, que o usuário inseriu na interface gráfica.
                     * O segundo parâmetro (out int) é uma variável inteira que será preenchida com o valor convertido se a conversão for bem-sucedida. 
                     * Este parâmetro é passado por referência usando a palavra-chave out, permitindo que o método modifique seu valor.
                     * Retorno: Retorna true se a string foi convertida com sucesso para um número inteiro; caso contrário, retorna false.
                     * 
                     * Operador Ternário (? :)
                     * 
                     * O operador ternário é uma forma concisa de realizar uma instrução if-else em uma única linha. A sintaxe geral é condição ? valorSeVerdadeiro : valorSeFalso.
                     * int.TryParse(txbNumero.Text, out int numero) é a condição testada. Se a conversão da string para inteiro for bem-sucedida, o método retorna true, e a variável numero é preenchida com o valor convertido.
                     * Se true (conversão bem-sucedida), o valor de numero é usado.
                     * Se false (falha na conversão), (int?)null é o valor atribuído, indicando explicitamente que você está atribuindo um valor nulo do tipo int? (inteiro nullable).
                     * 
                     */

                    // Executa o comando de inclusão do cliente
                    // Este método tenta inserir o objeto 'cliente', que agora contém os dados fornecidos pelo usuário, no banco de dados.
                    clienteDao.IncluiClienteAsync(cliente);

                    // Exibe uma caixa de diálogo informando o usuário de que o cadastro foi realizado com sucesso.
                    // 'MessageBox.Show' é um método que cria uma janela de diálogo com uma mensagem.
                    // "Cadastrado com Sucesso" é a mensagem que será exibida na caixa de diálogo.
                    // "Sucesso" é o título da caixa de diálogo.
                    // MessageBoxButtons.OK define que a caixa de diálogo terá um único botão "OK".
                    // MessageBoxIcon.Information define o ícone de informação a ser exibido na caixa de diálogo.
                    MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha o formulário atual.
                    // 'this.Close()' é um comando para fechar o formulário em que o código está sendo executado.
                    this.Close();
                }
                catch (Exception erro)
                {
                    // Este bloco é executado se ocorrer um erro durante a execução do bloco 'try'.
                    // Exibe uma caixa de diálogo informando o usuário de que um erro ocorreu.
                    // 'erro' é o objeto de exceção capturado pelo bloco 'catch'. Utiliza-se 'erro' para acessar a mensagem de erro.
                    MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
