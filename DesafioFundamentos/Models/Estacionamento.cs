namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe de dominio estacionamento.
    /// </summary>
    public class Estacionamento
    {
        /// <summary>
        /// O preço inicial.
        /// </summary>
        private decimal precoInicial = 0;
        /// <summary>
        /// O preço por hora.
        /// </summary>
        private decimal precoPorHora = 0;
        /// <summary>
        /// Os veículos.
        /// </summary>
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Estacionamento"/>.
        /// </summary>
        /// <param nome="precoInicial"> o preco inicial.</param>
        /// <param nome="precoPorHora"> o preco por hora.</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adicionar o veiculo.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} adicionado.");
        }
        /// <summary>
        /// Remover o veiculo.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa .
            string placa = Console.ReadLine().Trim();

            // Verifica se o veículo existe.
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = 0;
                decimal valorTotal = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(veiculos.FirstOrDefault(x => x.ToUpper() == placa.ToUpper()));

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        /// <summary>
        /// Listar os veiculos.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Veiculos estacionados: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}