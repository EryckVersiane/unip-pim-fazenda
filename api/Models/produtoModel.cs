using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models
{
    [Table("produto", Schema = "dbo")]
    public class ProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("preco")]
        public string Preco { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("peso")]
        public string Peso { get; set; }

        [Column("unidade_medida")]
        public string UnidadeMedida { get; set; }
    }
}