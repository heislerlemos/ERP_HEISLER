using System.Text.Json.Serialization;

namespace ERP_HEISLER.Controller
{
	internal class Rh_get
	{
	public record class Rh([property: JsonPropertyName("email")] string Email);

}
}
