using System.Diagnostics; // Permite iniciar processos externos, como abrir aplicativos ou arquivos.
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window; // Fornece acesso a elementos de estilo visual espec�ficos da janela.
using System.Windows.Forms; // Cont�m classes para criar aplica��es baseadas em Windows.
using System.Configuration; // Fornece acesso a configura��es de aplicativos, como strings de conex�o.
using Forms.TelasGerir; // Importa as telas de gerenciamento do namespace especificado.

// Define o namespace da aplica��o, organizando as classes em um pacote l�gico.
namespace Forms
{
    // Declara��o da classe FormPrincipal que herda de Form, representando o formul�rio principal da aplica��o.
    public partial class FormPrincipal : Form
    {
        // Construtor da classe FormPrincipal.
        public FormPrincipal()
        {
            InitializeComponent(); // M�todo gerado automaticamente para inicializar os componentes do formul�rio.
        }

        // Evento de carregamento do FormPrincipal.
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            coresFormularios(); // Chama o m�todo para ajustar as cores dos formul�rios.
        }

        // M�todo respons�vel por ajustar a cor de fundo dos controles do formul�rio.
        public void coresFormularios()
        {
            foreach (Control ctrl in this.Controls) // Percorre todos os controles no formul�rio.
            {
                try // Tenta executar o c�digo que pode gerar exce��es.
                {
                    if (ctrl is MdiClient) // Verifica se o controle atual � do tipo MdiClient.
                    {
                        ctrl.BackColor = System.Drawing.Color.AliceBlue; // Define a cor de fundo do MdiClient.
                    }
                }
                catch (Exception a) // Captura exce��es geradas no bloco try.
                {
                    MessageBox.Show("Erro :" + a); // Exibe uma mensagem de erro se ocorrer uma exce��o.
                }
            }
        }

        /*
         * No C#, Show e ShowDialog s�o m�todos usados para exibir formul�rios, 
         * mas eles servem prop�sitos ligeiramente diferentes e operam de maneiras distintas.
         * 
         * M�todo Show:
         * 
         * Uso: O m�todo Show � usado para exibir o formul�rio de maneira n�o modal. 
         * Isso significa que, depois de abrir o formul�rio com Show, 
         * o usu�rio pode interagir tanto com o formul�rio rec�m-aberto quanto com outros formul�rios da aplica��o (se houver). 
         * O formul�rio aberto com Show n�o bloqueia a execu��o do c�digo subsequente no m�todo que o chamou.
         * 
         * Comportamento: Quando voc� usa o Show, o c�digo seguinte ao m�todo Show continua a executar imediatamente.
         * O formul�rio aberto fica independente dos outros formul�rios da aplica��o.
         * 
         * M�todo ShowDialog :
         * 
         * Uso: O m�todo ShowDialog � usado para exibir o formul�rio de maneira modal. 
         * Isso significa que, ao abrir um formul�rio com ShowDialog,
         * o usu�rio deve interagir e fechar esse formul�rio antes de poder interagir com qualquer outro formul�rio da aplica��o. 
         * O formul�rio aberto com ShowDialog bloqueia a execu��o do c�digo subsequente no m�todo que o chamou at� que o formul�rio seja fechado.
         * 
         * Comportamento: O c�digo ap�s a chamada ao ShowDialog n�o � executado at� que o formul�rio modal seja fechado. 
         * Isso � �til quando voc� precisa que o usu�rio termine de interagir com o formul�rio aberto antes de prosseguir.
         */


        // Evento de clique do item de menu "Cliente".
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClienteCad = new frmClienteAdicionar(); // Instancia o formul�rio de adicionar cliente.
            frmClienteCad.MdiParent = this; // Define o formul�rio atual como o pai do formul�rio de adicionar cliente.
            frmClienteCad.Show(); // Exibe o formul�rio de adicionar cliente.
        }

        // Evento de clique do item de menu "T�cnicos".
        private void t�cnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTecnicoCad = new frmTecnicoAdicionar(); // Instancia o formul�rio de cadastro de t�cnicos.
            frmTecnicoCad.MdiParent = this; // Define o formul�rio atual como o pai do formul�rio de cadastro de t�cnicos.
            frmTecnicoCad.Show(); // Exibe o formul�rio de cadastro de t�cnicos.
        }

        // Evento de clique do item de menu "Gestor de Chamados".
        private void gestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGestorChamados = new frmGerirOrcamento(); // Instancia o formul�rio de gest�o de chamados.
            frmGestorChamados.MdiParent = this; // Define o formul�rio atual como o pai do formul�rio de gest�o de chamados.
            frmGestorChamados.Show(); // Exibe o formul�rio de gest�o de chamados.
        }

        // Evento de clique do item de menu "Gestor de Clientes".
        private void gestorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClienteCad = new frmGerirClientes(); // Instancia o formul�rio de gerenciamento de clientes.
            frmClienteCad.MdiParent = this; // Define o formul�rio atual como o pai do formul�rio de gerenciamento de clientes.
            frmClienteCad.Show(); // Exibe o formul�rio de gerenciamento de clientes.
        }

        // O evento para o item de menu "Gestor de T�cnicos" est� vazio e pode ser implementado conforme necess�rio.

        // Evento de clique do item de menu "Calculadora".
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc"); // Inicia o processo da calculadora do sistema operacional.
        }

        // Evento de clique do item de menu "Documenta��o".
        private void documenta��oToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo // Inicia um novo processo para abrir o site no navegador padr�o.
            {
                FileName = @"http://sp.senac.br",
                UseShellExecute = true // Usa o shell padr�o para executar o comando.
            });
        }

        // Evento de clique do item de menu "Sobre".
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSobre = new frmSobre(); // Instancia o formul�rio "Sobre".
            frmSobre.MdiParent = this; // Define o formul�rio atual como o pai do formul�rio "Sobre".
            frmSobre.Show(); // Exibe o formul�rio "Sobre".
        }

        // Evento de clique do item de menu "Fechar Solu��o".
        private void fecharSolu��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Deseja mesmo sair?", "Sistema de Chamados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgBox == DialogResult.Yes) // Verifica se o usu�rio escolheu "Sim".
            {
                Application.Exit(); // Fecha a aplica��o.
            }
        }
    }
}
