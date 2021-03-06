﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace _MigrateDatabase
{

	/// <summary>
	/// The program.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Program
	{

		/// <summary>
		/// Builds the web host.
		/// </summary>
		/// <param name="args">
		/// The arguments passed to the app.
		/// </param>
		/// <returns>
		/// The web host.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static IWebHost BuildWebHost(string[] args)
			=>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();

		/// <summary>
		/// The main entry point for the app.
		/// </summary>
		/// <param name="args">
		/// The arguments passed to the app.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static void Main(string[] args) => BuildWebHost(args).Run();

	}

}
