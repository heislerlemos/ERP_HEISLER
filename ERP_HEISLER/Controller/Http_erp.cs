using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;


namespace ERP_HEISLER.Controller
{
	internal class Http_erp
	{

		public static async Task http_getAsync()
		{
			using HttpClient client = new();
			client.DefaultRequestHeaders.Accept.Clear();
			await  ProcessRepositoriesAsync(client);



			static async Task ProcessRepositoriesAsync(HttpClient client)
			{
				var json = await client.GetStringAsync(
				"http://127.0.0.1:8000/api/rh/");
				System.Diagnostics.Debug.WriteLine(json);

			}

		}


	}
}
