using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RevolvingCredit.Entity;
using RevolvingCredit.WebAPI.Repository;
using RevolvingCredit.WebAPI.Repository.Interface;
using StartupBase = JDevl32.Web.Host.StartupBase;

namespace RevolvingCredit.WebAPI
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

		// todo|jdevl32: cleanup...
		/**
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override void Configure(IMapperConfigurationExpression mapperConfigurationExpression)
		{
			base.Configure(mapperConfigurationExpression);

			// todo|jdevl32: is this needed ???
			mapperConfigurationExpression.CreateMap<RevolvingCreditContext, IRevolvingCreditContext>()
				.ConstructUsing
					(
						context => new RevolvingCreditContext
							(
								context.DbContextOptions
								,
								context.ConfigurationRoot
								,
								context.HostingEnvironment
								,
								context.Logger
								,
								context.Mapper
								,
								context.ConnectionStringKey
							)
					)
				.ReverseMap();
		}
		**/

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
		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			services.AddScoped<IAPRRepository, APRRepository>();
		}

#endregion

	}

}
