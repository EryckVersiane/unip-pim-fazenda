using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UnipPimFazenda.Models
{
    [Table("funcionario", Schema = "dbo")]
    public class FuncionarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cargo")]
        public string Cargo { get; set; }

        [Column("jornada")]
        public string Jornada { get; set; }
    }
}