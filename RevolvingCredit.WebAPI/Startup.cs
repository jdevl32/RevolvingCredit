﻿using JDevl32.Entity.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.Repository;
using StartupBase = JDevl32.Web.Host.StartupBase;

namespace RevolvingCredit.WebAPI
{

	/// <inheritdoc />
	/// <summary>
	/// The app startup.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add CORS (and default configuration).
	/// </remarks>
	public class Startup
		:
		StartupBase
	{

#region Property

#region StartupBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override bool UseAuthentication { get; } = false;

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override bool UseCORS { get; } = true;

#endregion

#endregion

#region Instance Initialization

#region StartupBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Startup(IHostingEnvironment hostingEnvironment)
			:
			base(hostingEnvironment)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Startup(IHostingEnvironment hostingEnvironment, string configPath)
			:
			base(hostingEnvironment, configPath)
		{
		}

#endregion

#endregion

#region StartupBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override void ConfigureEntityContext(IServiceCollection serviceCollection)
			=>
			serviceCollection.AddDbContext<RevolvingCreditContext>();

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override void ConfigureRoutes(IRouteBuilder routeBuilder)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Implement revolvling credit account sower (seeder).
		/// </remarks>
		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			// todo|jdevl32: can the repository be refactored (see aprcontroller.cs) ???
			services.AddScoped<IInformableUniqueGuidEntityContextRepository<RevolvingCreditContext, Account>, AccountRepository>();
			services.AddScoped<IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, APR>, APRRepository>();
			services.AddTransient<AccountSower>();
			services.AddTransient<APRSower>();
		}

#endregion

		/// <summary>
		/// Configure (the startup).
		/// </summary>
		/// <param name="applicationBuilder">
		/// An application builder.
		/// </param>
		/// <param name="hostingEnvironment">
		/// A hosting environment.
		/// </param>
		/// <param name="loggerFactory">
		/// A logger factory.
		/// </param>
		/// <param name="accountSower">
		/// A revolving credit account sower.
		/// </param>
		/// <param name="aprSower">
		/// An APR (type) sower.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// Implement revolvling credit account sower (seeder).
		/// </remarks>
		public virtual void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, AccountSower accountSower, APRSower aprSower)
		{
			ConfigureStartup(applicationBuilder, hostingEnvironment, loggerFactory);

			var informableEntityContextSower =
				new InformableEntityContextSowerBase<RevolvingCreditContext>[]
				{
					accountSower
					,
					aprSower
				}
			;

			foreach (var sower in informableEntityContextSower)
			{
				sower.TrySeed().Wait();
			} // foreach
		}

	}

}
