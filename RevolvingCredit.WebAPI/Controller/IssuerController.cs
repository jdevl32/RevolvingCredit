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
	/// An issuer controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	[Produces("application/json")]
	[Route("api/issuer")]
	public class IssuerController
		:
		InformableUniqueIntEntityControllerBase<RevolvingCreditContext, Issuer, IssuerViewModel>
	{

#region Instance Initialization

		// todo|jdevl32: can the repository be refactored (see startup.cs) ???

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IssuerController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Issuer> informableUniqueIntEntityContextRepository)
			:
			this(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, IssuerSower.DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected IssuerController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper, IInformableUniqueIntEntityContextRepository<RevolvingCreditContext, Issuer> informableUniqueIntEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, loggerFactory, mapper, informableUniqueIntEntityContextRepository, displayName)
		{
		}

#endregion

	}

}
