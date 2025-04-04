using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaApiComSQLite.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nome { get; set; } = string.Empty;

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
