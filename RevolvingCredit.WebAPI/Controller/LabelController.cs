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
	/// A (major) label controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	[Produces("application/json")]
	[Route("api/label")]
	public class LabelController
		:
		InformableUniqueIntEntityControllerBase<RevolvingCreditContext, Label, LabelViewModel>
	{

#region Instance Initialization

		// todo|jdevl32: can the repository be refactored (see startup.cs) ???

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LabelController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Label> informableUniqueIntEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, LabelSower.DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected LabelController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Label> informableUniqueIntEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
