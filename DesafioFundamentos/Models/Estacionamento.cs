namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Usuário digita a plca e adiciona na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string  placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Solicita ao usuário uma placa para armazenar na variavel "placa"
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Solicita a o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                // cálcula o valor Inicial + precoPorHora * horas para a variável valorTotal                
                int horas = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;
                decimal valorTotal = precoInicial+precoPorHora*horas;

                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (string carros in veiculos) {
                    Console.WriteLine(carros);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}