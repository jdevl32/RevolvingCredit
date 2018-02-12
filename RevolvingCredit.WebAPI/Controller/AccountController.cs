using AutoMapper;
using JDevl32.Web.Controller.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.ViewModel;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <inheritdoc />
	/// <summary>
	/// A revolving credit account controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	[Produces("application/json")]
	[Route("api/account")]
	public class AccountController
		:
		InformableUniqueGuidEntityControllerBase<RevolvingCreditContext, Account, AccountViewModel>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueGuidEntityContextRepository<RevolvingCreditContext, Account> informableUniqueGuidEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueGuidEntityContextRepository, AccountSower.DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected AccountController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueGuidEntityContextRepository<RevolvingCreditContext, Account> informableUniqueGuidEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueGuidEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
