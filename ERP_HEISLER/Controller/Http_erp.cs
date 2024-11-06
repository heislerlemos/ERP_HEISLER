using System.Configuration;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text.Json;
using static ERP_HEISLER.Controller.Rh_get;




namespace ERP_HEISLER.Controller
{
	internal class Http_erp
	{

		public static async Task http_getAsync()
		{
			using HttpClient client = new();
			
			await ProcessRepositoriesAsync(client);

			static async Task ProcessRepositoriesAsync(HttpClient client)
			{
				await using Stream stream =
				await client.GetStreamAsync("http://127.0.0.1:8000/api/rh/");
				System.Diagnostics.Debug.WriteLine(stream);
				var recursos = await JsonSerializer.DeserializeAsync<List<Rh_get.Rh>>(stream);
				System.Diagnostics.Debug.WriteLine(recursos);
				if (recursos != null)
				{
					Api form = new Api();
					form.Show();

					foreach (var r in recursos)
					{
					
						System.Diagnostics.Debug.WriteLine($"Id: {r.Id}");
						System.Diagnostics.Debug.WriteLine($"Nome: {r.Nome}");
						System.Diagnostics.Debug.WriteLine($"Email: {r.Email}");
						System.Diagnostics.Debug.WriteLine($"Data: {r.Data}");
						System.Diagnostics.Debug.WriteLine($"Genero: {r.Genero}");
						System.Diagnostics.Debug.WriteLine($"Telefone: {r.Telefone}");
						System.Diagnostics.Debug.WriteLine($"Nif: {r.Nif}");


						
						string colecta = "Id : " + r.Id + "\n" +
										  "Nome :" + r.Nome + "\n" +
										  "Email :" + r.Email + "\n" +
										  "Data :" + r.Data + "\n" +
										  "Genero :" + r.Genero + "\n" +
										  "Telefone :" + r.Telefone + "\n" +
										  "Nif :" + r.Nif + "\n"+
										  "#####################" + "\n";

						form.dados.AppendText(colecta);

					}

					
	

				}
			}

		}

	}
}
