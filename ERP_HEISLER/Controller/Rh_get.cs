using System.Text.Json.Serialization;

namespace ERP_HEISLER.Controller
{
	internal class Rh_get
	{
	public record class Rh(
		[property: JsonPropertyName("id")] int Id,
		[property: JsonPropertyName("nome")] string Nome,
		[property: JsonPropertyName("email")] string Email,
		[property: JsonPropertyName("data")] string Data,
		[property: JsonPropertyName("genero")] string Genero,
		[property: JsonPropertyName("telefone")] int Telefone,
		[property: JsonPropertyName("nif")] int Nif
		);

}
}
