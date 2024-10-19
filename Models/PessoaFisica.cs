namespace UnipPimFazenda.Models 
{
    public class PessoaFisica: Pessoa {

        public int Id {get; set;}
        public string CPF {get; set;}
        public List<Telefone> Telefones {get; set;}

    }
}