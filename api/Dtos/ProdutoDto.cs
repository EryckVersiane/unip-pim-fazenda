using System.Text.Json.Serialization;

namespace UnipPimFazenda.Dtos
{
    public class ProdutoDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("preço")]
        public string Preco { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }

        [JsonPropertyName("peso")]
        public string Peso { get; set; }

        [JsonPropertyName("Unidade de medida")]
        public string UnidadeMedida { get; set; }

    }
}