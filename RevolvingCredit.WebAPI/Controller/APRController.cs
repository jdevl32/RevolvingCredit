using AutoMapper;
using JDevl32.Web.Controller.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.Repository;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <summary>
	/// An APR (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// Add the type of the unique entity item.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		InformableIntUniqueEntityControllerBase<APRController, APRRepository, APR>
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

		// todo|jdevl32: can the repository be refactored (see startup.cs) ???

		/// <inheritdoc />
		/// <remarks>
		/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
		/// Add the type of the unique entity item.
		/// </remarks>
		public APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IInformableUniqueEntityContextRepository<APRRepository, APR, int> informableUniqueEntityContextRepository)
			:
			this(hostingEnvironment, logger, mapper, informableUniqueEntityContextRepository, DefaultDisplayName)
		{
		}

		// todo|jdevl32: ??? is making protected the best solution ???
		// todo|jdevl32: ??? ...and then...how to handle default display name ???
		/// <inheritdoc />
		/// <remarks>
		/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
		/// Add the type of the unique entity item.
		/// </remarks>
		protected APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IInformableUniqueEntityContextRepository<APRRepository, APR, int> informableUniqueEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, logger, mapper, informableUniqueEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
