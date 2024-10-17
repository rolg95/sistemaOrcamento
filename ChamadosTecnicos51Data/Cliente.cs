using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define o namespace que encapsula a classe Cliente.
// Namespaces são usados para organizar e agrupar classes e outros tipos, 
// proporcionando uma estrutura lógica que facilita a manutenção e a compreensão do código.
namespace Data
{
    // Definição da classe Cliente, que modela as informações relacionadas a um cliente no sistema.
    public class Cliente
    {
        // Propriedades da classe Cliente.
        // Cada propriedade possui get e set automáticos, permitindo a leitura (get) e a escrita (set) dos dados.
        // Esse padrão facilita a manipulação e encapsulamento das informações de cada cliente.

        /*
         * OBSERVAÇÃO:
         * 
         * O uso de propriedades com métodos get e set automáticos simplifica a definição de atributos 
         * de uma classe, permitindo encapsular o acesso aos dados e a possibilidade de inserir lógicas 
         * adicionais no futuro (como validação ou processamento) sem alterar a interface da classe.
         * 
         * O método get é chamado ao acessar a propriedade para leitura, e o set é chamado ao atribuir
         * um valor a ela. Isso facilita a implementação de controle sobre como os dados são manipulados
         * pela aplicação.
         */

        // Código único do cliente. Definido como int e não permite valores nulos, garantindo uma identificação única para cada cliente.
        public int CodigoCliente { get; set; }

        // Nome do cliente. Permite nulo, considerando que o nome pode não estar disponível no momento da criação do registro.
        public string Nome { get; set; }

        // Profissão do cliente. O '?' indica que este campo é opcional e pode conter valores nulos.
        public string? Profissao { get; set; }

        // Setor de atuação ou área de interesse do cliente. Também opcional, permitindo a ausência dessa informação.
        public string? Setor { get; set; }

        // CEP (Código de Endereçamento Postal) do cliente. O campo é opcional, já que pode haver casos onde o CEP não é informado.
        public string? Cep { get; set; }

        // Nome da rua do endereço do cliente. Opcional, permitindo endereços incompletos ou desconhecidos.
        public string? Rua { get; set; }

        // Número do endereço. O uso de 'int?' indica que este campo pode ser nulo, 
        // permitindo registrar endereços sem número ou com número desconhecido.
        public int? Numero { get; set; }

        // Nome da cidade onde o cliente reside. Este campo é opcional, permitindo valores nulos.
        public string? Cidade { get; set; }

        // Estado ou região do cliente. Também opcional, permitindo valores nulos.
        public string? Estado { get; set; }

        // Observações adicionais sobre o cliente. Campo opcional para anotações extra ou detalhes adicionais.
        public string? Observacao { get; set; }
    }
}
