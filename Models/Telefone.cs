using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models 

{
    [Table("telefone", Schema = "dbo")]
    public class Telefone 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set;}
        
        [Column("ddd")]
        public string Ddd {get; set;}
        
        [Column("numero")]
        public string Numero {get; set;}
        
        [Column("pessoa_id")]
        public int PessoaId {get; set;}
    }
}