namespace POC.Business.Models
{
    public class Produto : Entity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DataCadatro { get; set; }
        public bool Ativo { get; set; }
    }
}