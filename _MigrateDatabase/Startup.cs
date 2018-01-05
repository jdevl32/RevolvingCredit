using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RevolvingCredit.Entity;
using StartupBase = JDevl32.Web.Host.StartupBase;

namespace _MigrateDatabase
{

	/// <summary>
	/// The app startup.
	/// </summary>
	/// <remarks>
	/// Last modification:
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

		// todo|jdevl32: is mvc always needed (for automapper) ???
		///// <inheritdoc />
		//public override bool UseMvc { get; } = false;

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override bool UseStaticFiles { get; } = false;

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

		// todo|jdevl32: ???
		/**
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Add revolving credit context sower.
		/// </remarks>
		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			// todo|jdevl32: ???
			//services.AddScoped<IAPRRepository, APRRepository>();
			services.AddTransient<APRSower>();
		}

		/// <inheritdoc />
		protected override void InitializeMapper()
		{
			//base.InitializeMapper();
		}
		**/

#endregion

		// todo|jdevl32: ???
		/**
		/// <summary>
		/// Configure.
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
		/// <param name="aprSower">
		/// An APR (type)(s) sower.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, APRSower aprSower)
		{
			Configure(applicationBuilder, hostingEnvironment, loggerFactory);
			aprSower.Seed().Wait();
		}
		**/

	}

}
