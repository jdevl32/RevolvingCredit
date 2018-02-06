using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace RevolvingCredit.WebApp.Controller
{

	/// <inheritdoc />
	/// <summary>
	/// The base class for (most of) the controller(s) contained in this application.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class ControllerBase
		:
		JDevl32.Web.Controller.ControllerBase
	{

#region Instance Initialization

#region Implementation of JDevl32.Web.Controller.ControllerBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public ControllerBase(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper)
			:
			base(hostingEnvironment, loggerFactory, mapper)
		{
		}

#endregion

#endregion

	}

}
