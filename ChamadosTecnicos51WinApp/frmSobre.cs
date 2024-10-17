using System; // Fornece classes base fundamentais e tipos de dados essenciais.
using System.Collections.Generic; // Contém interfaces e classes que definem coleções genéricas, que permitem aos usuários criar coleções fortemente tipadas.
using System.ComponentModel; // Fornece classes que são usadas para implementar o comportamento de componentes e controles em tempo de execução e design.
using System.Data; // Contém classes que representam o acesso a dados e a manipulação de dados. Não utilizado diretamente neste código, mas geralmente incluído para operações de banco de dados.
using System.Drawing; // Fornece acesso a funcionalidades básicas de gráficos e desenho. Usado aqui para manipular propriedades de cor e tamanho de controles.
using System.Linq; // Oferece suporte para consultas integradas à linguagem que podem ser aplicadas a fontes de dados, como arrays ou coleções. Não utilizado diretamente neste código.
using System.Reflection.Emit; // Fornece classes que permitem a emissão de metadados e código de Microsoft Intermediate Language (MSIL). Não utilizado diretamente neste código.
using System.Text; // Contém classes que representam codificações de caracteres ASCII e Unicode, e abstrações para conversão de bytes em caracteres e vice-versa. Não utilizado diretamente neste código.
using System.Threading.Tasks; // Fornece tipos que simplificam a programação assíncrona. Usado aqui para suportar a execução assíncrona de tarefas sem bloquear a thread principal da interface do usuário.
using System.Windows.Forms; // Contém classes para criar aplicações baseadas em Windows, que são usadas para construir a interface do usuário, capturar eventos, etc.

// Define o namespace do projeto, que organiza as classes em uma estrutura lógica.
namespace Forms
{
    // Declara a classe frmSobre, que herda de Form, indicando que representa um formulário no Windows Forms.
    public partial class frmSobre : Form
    {
        // Construtor da classe frmSobre.
        public frmSobre()
        {
            InitializeComponent(); // Chama o método InitializeComponent, que inicializa os componentes do formulário definidos no designer.
        }

        /*
            Este evento é acionado quando o formulário frmSobre é carregado.
            Ele configura e inicia uma animação na label lblSobre, fazendo-a rolar verticalmente.
        */
        private void Sobre_Load(object sender, EventArgs e)
        {
            // Configura a label lblSobre para ter uma largura máxima de 400 pixels e altura dinâmica.
            lblSobre.MaximumSize = new Size(400, 0);

            // Habilita a propriedade AutoSize da label lblSobre, fazendo com que o tamanho dela se ajuste automaticamente ao conteúdo.
            lblSobre.AutoSize = true;

            // Define o intervalo do timer (timer1) como 30 milissegundos, controlando a velocidade da animação.
            timer1.Interval = 30;

            // Adiciona um manipulador de eventos para o evento Tick do timer1.
            // Este evento é acionado a cada intervalo definido anteriormente (30 ms).
            timer1.Tick += (s, ev) =>
            {
                // Incrementa a posição vertical (Top) da label lblSobre, fazendo-a se mover para baixo.
                lblSobre.Top += 1;

                // Verifica se a parte inferior da label (Bottom) ultrapassou a altura do formulário (ClientSize.Height).
                if (lblSobre.Bottom >= this.ClientSize.Height)
                {
                    // Caso tenha ultrapassado, a label é reposicionada para começar novamente do topo.
                    lblSobre.Top = -lblSobre.Height;
                }
            };

            // Inicia o timer1, dando início à animação da label.
            timer1.Start();
        }
    }
}
