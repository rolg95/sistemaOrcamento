// As linhas abaixo indicam quais "ferramentas" ou "bibliotecas" do sistema estamos usando.
// Essas ferramentas contêm funções e utilitários prontos que nos ajudam a realizar várias tarefas, como manipulação de texto, coleções e outros tipos de dados.
using System; // Inclui funções básicas como data/hora e manipulação de erros.
using System.Collections.Generic; // Inclui funcionalidades para lidar com coleções de dados, como listas.
using System.Linq; // Inclui funções para manipular dados de forma eficiente (consultas sobre listas, por exemplo).
using System.Text; // Inclui funções para manipular e trabalhar com textos.
using System.Threading.Tasks; // Inclui funcionalidades para executar tarefas em segundo plano ou ao mesmo tempo (paralelismo).

// Aqui estamos criando um "espaço de nome" (namespace). Um namespace é como uma "caixa organizadora" que agrupa o código relacionado. 
// Nesse caso, o nome "ChamadosTecnicos51Data" foi escolhido para representar uma área específica do sistema que lida com técnicos e dados de chamados técnicos.
namespace Data
{
    // Definição de uma "classe". Uma classe é como um "molde" ou "modelo" que define um objeto.
    // Aqui, a classe "Tecnico" define o que é um técnico, com base em algumas características (propriedades) que ele possui.
    public class Tecnico
    {
        // Abaixo estão as "propriedades" da classe. Propriedades são características ou atributos que os objetos da classe terão.
        // No caso, a classe Técnico tem três propriedades: Código do Técnico, Nome e Especialidade.

        // Esta propriedade armazena um número inteiro que identificará cada técnico de forma única. 
        // Por exemplo, pense em um número de matrícula em uma empresa.
        public int CodigoTecnico { get; set; }

        // Abaixo, temos uma propriedade para armazenar o nome do técnico.
        // O tipo "string" indica que a informação será um texto, como "João da Silva".
        // O ponto de interrogação (?) ao lado de "string" indica que essa informação é opcional, ou seja, o nome pode ser deixado em branco ou nulo (não preenchido).
        public string? Nome { get; set; }

        // Esta propriedade armazena a especialidade do técnico, ou seja, em que área ele é mais habilidoso. 
        // Por exemplo, um técnico pode ter como especialidade "Redes de Computadores" ou "Suporte em Hardware".
        // Assim como a propriedade "Nome", a especialidade também é opcional, por isso o uso do "?" após "string", permitindo que seja deixada em branco.
        public string? Especialidade { get; set; }
    }
}
