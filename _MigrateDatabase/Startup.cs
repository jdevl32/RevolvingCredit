using JDevl32.Entity.Model;
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
		public override bool UseAuthentication { get; } = false;

		// todo|jdevl32: is mvc always needed (for automapper) ???
		///// <inheritdoc />
		//public override bool UseMvc { get; } = false;

		/// <inheritdoc />
		public override bool UseStaticFiles { get; } = false;

#endregion

#endregion

#region Instance Initialization

#region StartupBase

		/// <inheritdoc />
		public Startup(IHostingEnvironment hostingEnvironment)
			:
			base(hostingEnvironment)
		{
		}

		/// <inheritdoc />
		public Startup(IHostingEnvironment hostingEnvironment, string configPath)
			:
			base(hostingEnvironment, configPath)
		{
		}

#endregion

#endregion

#region StartupBase

		// todo|jdevl32: obsolete (due to profiles / auto-mapper extension for dependency-injection) ???
		///// <inheritdoc />
		//protected override void Configure(IMapperConfigurationExpression mapperConfigurationExpression)
		//{
		//	base.Configure(mapperConfigurationExpression);

		//	mapperConfigurationExpression
		//		.CreateMap<Account, IAccount>()
		//		.ConstructUsing(account => new Account())
		//		.ReverseMap();
		//	// todo|jdevl32: finish the rest...
		//	// todo|jdevl32: maybe not needed ???
		//	//mapperConfigurationExpression
		//	//	.CreateMap<RevolvingCreditContext, IRevolvingCreditContext>()
		//	//	.ConstructUsing(revolvingCreditContext => new RevolvingCreditContext())
		//	//	.ReverseMap();
		//}

		/// <inheritdoc />
		protected override void ConfigureEntityContext(IServiceCollection serviceCollection)
			=>
			base.ConfigureEntityContext<RevolvingCreditContext, EntityContextBase>(serviceCollection);

#endregion

	}

}
