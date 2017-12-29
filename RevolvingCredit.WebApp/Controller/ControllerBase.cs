using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace RevolvingCredit.WebApp.Controller
{

	/// <inheritdoc />
	/// <summary>
	/// The base class for (most) controllers contained in this application.
	/// </summary>
	public class ControllerBase
		:
		JDevl32.Web.Controller.ControllerBase
	{

#region Instance Initialization

#region JDevl32.Web.Controller.ControllerBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Implement instance mapper interface.
		/// </remarks>
		public ControllerBase(IHostingEnvironment hostingEnvironment, ILogger<JDevl32.Web.Controller.ControllerBase> logger, IMapper mapper)
			:
			base(hostingEnvironment, logger, mapper)
		{
		}

#endregion

#endregion

	}

}
