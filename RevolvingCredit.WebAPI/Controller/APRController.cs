using AutoMapper;
using JDevl32.Web.Controller.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.Entity.Model.Sower;
using RevolvingCredit.WebAPI.ViewModel;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <inheritdoc />
	/// <summary>
	/// An APR (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor (default) display name (from APR (type) sower).
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		InformableUniqueIntEntityControllerBase<RevolvingCreditContext, APR, APRViewModel>
	{

#region Instance Initialization

		// todo|jdevl32: can the repository be refactored (see startup.cs) ???

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor (default) display name (from APR (type) sower).
		/// </remarks>
		public APRController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, APR> informableUniqueIntEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, APRSower.DefaultDisplayName)
		{
		}

		// todo|jdevl32: ??? is making protected the best solution ???
		// todo|jdevl32: ??? ...and then...how to handle default display name ???
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		protected APRController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, APR> informableUniqueIntEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
