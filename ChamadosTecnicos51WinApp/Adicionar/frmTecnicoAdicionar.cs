using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmTecnicoAdicionar : Form
    {
        // Define uma variável chamada "_conexao" para armazenar a string de conexão
        string _conexao = Forms.Properties.Settings.Default.Conexao;
        public frmTecnicoAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criação de um objeto Tecnico
            Tecnico tecnico = new Tecnico();
            // Criação de um objeto TecnicoDao
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            // Verifica se algum dos campos está vazio ou em branco
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbEspecialidade.Text))
            {
                // Exibe uma mensagem de erro informando para preencher todos os campos corretamente
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Atribui os valores dos campos de texto aos atributos do objeto Tecnico
                    tecnico.Nome = txbNome.Text;
                    tecnico.Especialidade = txbEspecialidade.Text;

                    // Chama o método IncluiTecnico do objeto TecnicoDao para inserir o técnico no banco de dados
                    tecnicoDao.IncluiTecnico(tecnico);

                    // Fecha o formulário
                    this.Close();
                }
                catch (Exception erro)
                {
                    // Exibe uma mensagem de erro caso ocorra uma exceção durante a inserção do técnico
                    MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Exibe uma mensagem informando que o cadastro foi realizado com sucesso
                    MessageBox.Show("Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}
