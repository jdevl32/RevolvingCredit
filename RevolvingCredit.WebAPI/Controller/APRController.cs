﻿using AutoMapper;
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

	/// <summary>
	/// An APR (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor loggable logger category name.
	/// Add the type of the unique entity item view model.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		// todo|jdevl32: ???
		InformableIntUniqueEntityControllerBase<RevolvingCreditContext, APR, APRViewModel>
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
		/// Refactor loggable logger category name.
		/// </remarks>
		public APRController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueEntityContextRepository<RevolvingCreditContext, APR, int> informableUniqueEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueEntityContextRepository, DefaultDisplayName)
		{
		}

		// todo|jdevl32: ??? is making protected the best solution ???
		// todo|jdevl32: ??? ...and then...how to handle default display name ???
		/// <inheritdoc />
		/// <remarks>
		/// Refactor loggable logger category name.
		/// </remarks>
		protected APRController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueEntityContextRepository<RevolvingCreditContext, APR, int> informableUniqueEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueEntityContextRepository, displayName)
		{
		}

#endregion

		// todo|jdevl32: cleanup...
		/**
		// todo|jdevl32: remove (debug/test only)...
#region Overrides of InformableUniqueEntityControllerBase<RevolvingCreditContext, APR, APRViewModel, int>

		/// <inheritdoc />
		public override Task<IActionResult> Delete([FromBody] APRViewModel uniqueEntityViewModel)
		{
			Logger.LogInformation($"[{nameof(Delete)}:{nameof(uniqueEntityViewModel)}={uniqueEntityViewModel}]");

			return base.Delete(uniqueEntityViewModel);
		}

		/// <inheritdoc />
		public override Task<IActionResult> Post([FromBody] APRViewModel uniqueEntityViewModel)
		{
			Logger.LogInformation($"[{nameof(Post)}:{nameof(uniqueEntityViewModel)}={uniqueEntityViewModel}]");

			return base.Post(uniqueEntityViewModel);
		}

#endregion
		/**/

	}

}
