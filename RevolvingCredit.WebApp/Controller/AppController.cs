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
		/// </remarks>
		public AppController(IHostingEnvironment hostingEnvironment, ILogger<JDevl32.Web.Controller.ControllerBase> logger)
			:
			base(hostingEnvironment, logger)
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
