using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Windows.Forms;




namespace ERP_HEISLER.Controller
{
	internal class Http_erp
	{

		public static async Task http_getAsync()
		{
			using HttpClient client = new();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
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
					foreach (var r in recursos)
					{
						/**
						int Identificador = r.Id;
						string Nome = r.Nome;
						string Email = r.Email;	
						**/
	
						System.Diagnostics.Debug.WriteLine($"Id: {r.Id}");
						System.Diagnostics.Debug.WriteLine($"Nome: {r.Nome}");
						System.Diagnostics.Debug.WriteLine($"Email: {r.Email}");
						System.Diagnostics.Debug.WriteLine($"Data: {r.Data}");
						System.Diagnostics.Debug.WriteLine($"Genero: {r.Genero}");
						System.Diagnostics.Debug.WriteLine($"Telefone: {r.Telefone}");
						System.Diagnostics.Debug.WriteLine($"Nif: {r.Nif}");


						//string resultado = "\n" + "Nome" + Nome + "\n" + "Email" + Email;



						string e = "teste";
						MessageBox.Show(e);


					}


				}


			}

		}


	}
}
