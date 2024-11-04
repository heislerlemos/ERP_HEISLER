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
				foreach (var r in recursos) System.Diagnostics.Debug.WriteLine(r.Email); ;


			}

		}


	}
}
