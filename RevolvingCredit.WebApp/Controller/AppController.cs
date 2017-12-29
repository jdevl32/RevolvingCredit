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

#region ControllerBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Implement instance mapper interface.
		/// </remarks>
		public AppController(IHostingEnvironment hostingEnvironment, ILogger<ControllerBase> logger, IMapper mapper)
			:
			base(hostingEnvironment, logger, mapper)
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

		/// <summary>
		/// GET: App/APR
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public ActionResult APR()
		{
			return View();
		}

	}

}
