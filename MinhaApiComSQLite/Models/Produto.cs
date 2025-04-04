using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaApiComSQLite.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
