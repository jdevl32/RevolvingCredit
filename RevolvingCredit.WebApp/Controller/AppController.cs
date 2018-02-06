using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RevolvingCredit.WebApp.Controller
{

	/// <inheritdoc />
	/// <summary>
	/// The app controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AppController
		:
		ControllerBase
	{

#region Instance Initialization

#region Implementation of ControllerBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public AppController(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory, IMapper mapper)
			:
			base(hostingEnvironment, loggerFactory, mapper)
		{
		}

#endregion

#endregion

		/// <summary>
		/// GET: App
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public ActionResult Index()
		{
			return View();
		}

	}

}
