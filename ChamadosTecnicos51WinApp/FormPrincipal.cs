using System.Diagnostics; // Permite iniciar processos externos, como abrir aplicativos ou arquivos.
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window; // Fornece acesso a elementos de estilo visual específicos da janela.
using System.Windows.Forms; // Contém classes para criar aplicações baseadas em Windows.
using System.Configuration; // Fornece acesso a configurações de aplicativos, como strings de conexão.
using Forms.TelasGerir; // Importa as telas de gerenciamento do namespace especificado.

// Define o namespace da aplicação, organizando as classes em um pacote lógico.
namespace Forms
{
    // Declaração da classe FormPrincipal que herda de Form, representando o formulário principal da aplicação.
    public partial class FormPrincipal : Form
    {
        // Construtor da classe FormPrincipal.
        public FormPrincipal()
        {
            InitializeComponent(); // Método gerado automaticamente para inicializar os componentes do formulário.
        }

        // Evento de carregamento do FormPrincipal.
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            coresFormularios(); // Chama o método para ajustar as cores dos formulários.
        }

        // Método responsável por ajustar a cor de fundo dos controles do formulário.
        public void coresFormularios()
        {
            foreach (Control ctrl in this.Controls) // Percorre todos os controles no formulário.
            {
                try // Tenta executar o código que pode gerar exceções.
                {
                    if (ctrl is MdiClient) // Verifica se o controle atual é do tipo MdiClient.
                    {
                        ctrl.BackColor = System.Drawing.Color.AliceBlue; // Define a cor de fundo do MdiClient.
                    }
                }
                catch (Exception a) // Captura exceções geradas no bloco try.
                {
                    MessageBox.Show("Erro :" + a); // Exibe uma mensagem de erro se ocorrer uma exceção.
                }
            }
        }

        /*
         * No C#, Show e ShowDialog são métodos usados para exibir formulários, 
         * mas eles servem propósitos ligeiramente diferentes e operam de maneiras distintas.
         * 
         * Método Show:
         * 
         * Uso: O método Show é usado para exibir o formulário de maneira não modal. 
         * Isso significa que, depois de abrir o formulário com Show, 
         * o usuário pode interagir tanto com o formulário recém-aberto quanto com outros formulários da aplicação (se houver). 
         * O formulário aberto com Show não bloqueia a execução do código subsequente no método que o chamou.
         * 
         * Comportamento: Quando você usa o Show, o código seguinte ao método Show continua a executar imediatamente.
         * O formulário aberto fica independente dos outros formulários da aplicação.
         * 
         * Método ShowDialog :
         * 
         * Uso: O método ShowDialog é usado para exibir o formulário de maneira modal. 
         * Isso significa que, ao abrir um formulário com ShowDialog,
         * o usuário deve interagir e fechar esse formulário antes de poder interagir com qualquer outro formulário da aplicação. 
         * O formulário aberto com ShowDialog bloqueia a execução do código subsequente no método que o chamou até que o formulário seja fechado.
         * 
         * Comportamento: O código após a chamada ao ShowDialog não é executado até que o formulário modal seja fechado. 
         * Isso é útil quando você precisa que o usuário termine de interagir com o formulário aberto antes de prosseguir.
         */


        // Evento de clique do item de menu "Cliente".
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClienteCad = new frmClienteAdicionar(); // Instancia o formulário de adicionar cliente.
            frmClienteCad.MdiParent = this; // Define o formulário atual como o pai do formulário de adicionar cliente.
            frmClienteCad.Show(); // Exibe o formulário de adicionar cliente.
        }

        // Evento de clique do item de menu "Técnicos".
        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTecnicoCad = new frmTecnicoAdicionar(); // Instancia o formulário de cadastro de técnicos.
            frmTecnicoCad.MdiParent = this; // Define o formulário atual como o pai do formulário de cadastro de técnicos.
            frmTecnicoCad.Show(); // Exibe o formulário de cadastro de técnicos.
        }

        // Evento de clique do item de menu "Gestor de Chamados".
        private void gestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGestorChamados = new frmGerirOrcamento(); // Instancia o formulário de gestão de chamados.
            frmGestorChamados.MdiParent = this; // Define o formulário atual como o pai do formulário de gestão de chamados.
            frmGestorChamados.Show(); // Exibe o formulário de gestão de chamados.
        }

        // Evento de clique do item de menu "Gestor de Clientes".
        private void gestorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClienteCad = new frmGerirClientes(); // Instancia o formulário de gerenciamento de clientes.
            frmClienteCad.MdiParent = this; // Define o formulário atual como o pai do formulário de gerenciamento de clientes.
            frmClienteCad.Show(); // Exibe o formulário de gerenciamento de clientes.
        }

        // O evento para o item de menu "Gestor de Técnicos" está vazio e pode ser implementado conforme necessário.

        // Evento de clique do item de menu "Calculadora".
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc"); // Inicia o processo da calculadora do sistema operacional.
        }

        // Evento de clique do item de menu "Documentação".
        private void documentaçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo // Inicia um novo processo para abrir o site no navegador padrão.
            {
                FileName = @"http://sp.senac.br",
                UseShellExecute = true // Usa o shell padrão para executar o comando.
            });
        }

        // Evento de clique do item de menu "Sobre".
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSobre = new frmSobre(); // Instancia o formulário "Sobre".
            frmSobre.MdiParent = this; // Define o formulário atual como o pai do formulário "Sobre".
            frmSobre.Show(); // Exibe o formulário "Sobre".
        }

        // Evento de clique do item de menu "Fechar Solução".
        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Deseja mesmo sair?", "Sistema de Chamados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgBox == DialogResult.Yes) // Verifica se o usuário escolheu "Sim".
            {
                Application.Exit(); // Fecha a aplicação.
            }
        }
    }
}
