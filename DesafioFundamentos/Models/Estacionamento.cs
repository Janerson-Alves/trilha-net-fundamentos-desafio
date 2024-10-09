using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    //Nome da Classe
    public class Estacionamento
    {
        //Atributos da classe
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        // Lista de Strings.
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        //Métodos da classe.
        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa e adicionar na lista "veículos".
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            //Adicionando na lista de veículos
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa.
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Pedi para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado.
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");              
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                //Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado.
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                //Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);

                //Mostra uma mensagem na tela com a placa que foi removida e o valor total do veiculo que ficou estacionado.
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento.
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Realizando um laço de repetição, para exibir os veículos estacionados.
                foreach(var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
