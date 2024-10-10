namespace VrumVrumCar.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        // Método para calcular comissão
        public decimal CalcularComissao()
        {
            // Implementar lógica de cálculo de comissão aqui
            return 0; // Retornar o valor calculado
        }
    }
}
