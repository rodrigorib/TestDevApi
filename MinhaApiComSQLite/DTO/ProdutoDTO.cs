namespace MinhaApiComSQLite.DTO
{
    public class ProdutoDTO
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
