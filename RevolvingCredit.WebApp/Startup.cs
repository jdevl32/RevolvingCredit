using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using StartupBase = JDevl32.Web.Host.StartupBase;

namespace RevolvingCredit.WebApp
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

		// todo|jdevl32: ??? here (instead of web-api) ???
		/**
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
		/// Add revolving credit context APR (type)(s) sower.
		/// </remarks>
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		/// </remarks>
		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			services.AddScoped<IAPRRepository, APRRepository>();
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
		/// <param name="aprSower">
		/// An APR (type)(s) sower.
		/// </param>
		/// <remarks>
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// Last modification:
		/// Rename (base class) configure methods (to avoid possible collisions).
		/// </remarks>
		public virtual void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, APRSower aprSower)
		{
			ConfigureStartup(applicationBuilder, hostingEnvironment, loggerFactory);
			aprSower.Seed().Wait();
		}
		**/

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
		/// <remarks>
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// Last modification:
		/// Rename (base class) configure methods (to avoid possible collisions).
		/// </remarks>
		public virtual void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
		{
			ConfigureStartup(applicationBuilder, hostingEnvironment, loggerFactory);
		}

	}

}
