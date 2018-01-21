using AutoMapper;
using JDevl32.Web.Controller.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.Repository;
using RevolvingCredit.WebAPI.ViewModel;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <summary>
	/// The APR (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add repository type.
	/// Add unique item type.
	/// Add unique item view model type.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		UniqueInformableControllerBase<APRController, APRRepository, APR, APRViewModel>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "APR (type)";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Replace derived class with repository type.
		/// Add unique item type.
		/// </remarks>
		public APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IUniqueInformableEntityContextRepository<APRRepository, APR> uniqueInformableEntityContextRepository)
			:
			this(hostingEnvironment, logger, mapper, uniqueInformableEntityContextRepository, DefaultDisplayName)
		{
		}

		// todo|jdevl32: ??? is making protected the best solution ???
		// todo|jdevl32: ??? ...and then...how to handle default display name ???
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Replace derived class with repository type.
		/// Add unique item type.
		/// </remarks>
		protected APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IUniqueInformableEntityContextRepository<APRRepository, APR> uniqueInformableEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, logger, mapper, uniqueInformableEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
