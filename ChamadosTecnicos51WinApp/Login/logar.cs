using Data; // Importa o namespace que contém as classes relacionadas aos dados dos chamados técnicos
using System; // Importa o namespace principal do C#
using System.ComponentModel; // Importa o namespace que contém os componentes para suporte à vinculação de dados
using System.Data; // Importa o namespace que contém as classes que representam os dados
using System.Diagnostics; // Importa o namespace que contém classes que oferecem suporte à interação com processos do sistema
using System.Drawing; // Importa o namespace que contém classes para a manipulação de imagens, cores e fontes
using System.Linq; // Importa o namespace que fornece classes e interfaces que suportam consultas que usam a linguagem de consulta integrada (LINQ)
using System.Text; // Importa o namespace que contém classes representando codificação de caracteres Unicode e codificação baseada em byte
using System.Threading.Tasks; // Importa o namespace que contém tipos que suportam tarefas paralelas e assíncronas
using System.Windows.Forms; // Importa o namespace que contém classes para criação de aplicativos Windows Forms

namespace Forms.Login
{
    public partial class logar : Form
    {
        // Define uma variável chamada "_conexao" para armazenar a string de conexão
        string _conexao = Forms.Properties.Settings.Default.Conexao;

        public logar()
        {
            InitializeComponent();
            saudacao(); // Chama o método saudacao() para exibir a saudação na tela
        }

        /*
         Função para mostrar saudação na tela conforme horário do sistema 
        */
        private void saudacao()
        {
            // Captura a Hora Atual
            int hora = DateTime.Now.Hour;
            // Captura nome do computador
            string nome = Environment.MachineName;
            // Cria uma String com as possíveis saudações
            var saudacoes = new string[] { "BOA MADRUGADA", "BOM DIA", "BOA TARDE", "BOA NOITE" };
            // Pega a lista da saudações e usa o horário como índice e coloca na label
            lblBemVindo.Text = $"Olá {nome}";
            lblSaudacao.Text = saudacoes[hora / 6]; // Define a saudação com base na hora do dia
        }

        /* 
         Dica: Ao definir o texto de um botão, você pode usar o símbolo "&" para criar um atalho de teclado.
         Quando o usuário pressiona a tecla correspondente ao caractere que vem após o "&", o botão é ativado.
         Por exemplo, ao definir o texto como "&Acessar", o botão pode ser ativado pressionando a tecla "A" no teclado.
        */
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Deseja mesmo sair?", "Sistema de Chamados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgBox == DialogResult.Yes)
            {
                Application.Exit(); // Fecha a aplicação se o usuário confirmar
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            limparErros(); // Limpa os erros antes de validar novamente
            // Verifica se o formulário é válido
            if (validadorCampos())
            {
                try
                {
                    string email = txbEmail.Text;
                    string senha = txbSenha.Text;

                    /*
                    UsuarioDao usuarioDao = new UsuarioDao(_conexao);
                    Usuario usuarioLogado = usuarioDao.LoginUsuario(email, senha);
                    */
                    if (email == "teste@teste.com" && senha == "123")
                    {
                        // Login bem-sucedido, abre o formulário principal
                        var frmPrincipal = new FormPrincipal();
                        frmPrincipal.Show();
                    }
                    else
                    {
                        // Exibe mensagem de erro se o e-mail ou senha forem inválidos
                        MessageBox.Show("Email ou senha inválidos !!",
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    // Exibindo uma mensagem de erro em caso de exceção
                    MessageBox.Show("Ocorreu um erro!!" + erro,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Se o formulário não estiver válido, exibe uma mensagem de erro
                MessageBox.Show("Por favor, corrija os erros no formulário antes de enviar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* 
         Lembre-se: Coloque o componente ErrorProvider para interagir com os TXB
         Método para validar os campos
        */
        private bool validadorCampos()
        {
            bool valido = true;
            string email = txbEmail.Text;
            string senha = txbSenha.Text;
            if (string.IsNullOrEmpty(email) || !emailValido(email))
            {
                // Define a mensagem de erro para o ErrorProvider se o e-mail estiver vazio ou inválido
                errorProvider1.SetError(txbEmail, "Mermão, Cadê o e-mail ? ");
                valido = false;
            }
            if (string.IsNullOrEmpty(senha))
            {
                // Define a mensagem de erro para o ErrorProvider se a senha estiver vazia
                errorProvider1.SetError(txbSenha, "Sem senha não vai acessar ! ");
                valido = false;
            }
            return valido;
        }

        // Função para validar o formato de e-mail usando uma expressão regular simples
        private bool emailValido(string email)
        {
            // Aqui você pode implementar uma validação mais robusta para o formato de e-mail
            // Neste exemplo, usamos uma validação simples com expressão regular
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void limparErros()
        {
            // Se a validação for bem-sucedida, remove a mensagem de erro, se houver
            errorProvider1.SetError(txbEmail, null);
            errorProvider1.SetError(txbSenha, null);
        }
    }
}
