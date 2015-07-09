using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AsyncAwaitinCatchFinally
{
	class Program
	{
		static void Main(string[] args)
		{
			
		}

		public async Task DownloadString(string url)
		{
			WebClient webClient = new WebClient();

			try
			{
				await webClient.DownloadStringTaskAsync(url);
			}
			catch (Exception ex)
			{
				await LogMessageAsync(ex.Message);
			}
		}

		public async Task LogMessageAsync(string errorMessage)
		{
			Console.WriteLine(errorMessage);
		}
	}
}
