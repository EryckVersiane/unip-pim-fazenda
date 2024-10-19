using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models
{
    [Table("pessoa_fisica", Schema = "dbo")]
    public class PessoaFisica : Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }
        
        public List<Telefone> Telefones { get; set; }
    }
}
