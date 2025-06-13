namespace ControleEstoqueAPI.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public required Produto Produto { get; set; }
        public TipoMovimentacao Tipo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataMovimentacao { get; set; } = DateTime.UtcNow;
        public string? OrigemDestino { get; set; } //Fornecedor/Cliente
        public string? Observacao { get; set; }

        public enum TipoMovimentacao
        {
            Entrada,
            Saida,
            Ajuste

        }
    }
}
