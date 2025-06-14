namespace ControleEstoqueAPI.Models
{
    public class EstoqueViewModel
    {
        public int ProdutoId { get; set; }
        public string? ProdutoNome { get; set; }
        public int Entradas { get; set; }
        public int Saidas { get; set; }
        public int SaldoAtual { get; set; }
        public DateTime ultimaAtualizacao { get; set; } 


    }
}
