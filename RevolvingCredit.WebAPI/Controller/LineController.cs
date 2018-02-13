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
	/// A line (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	[Produces("application/json")]
	[Route("api/line")]
	public class LineController
		:
		InformableUniqueIntEntityControllerBase<RevolvingCreditContext, Line, LineViewModel>
	{

#region Instance Initialization

		// todo|jdevl32: can the repository be refactored (see startup.cs) ???

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LineController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Line> informableUniqueIntEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, LineSower.DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected LineController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Line> informableUniqueIntEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
